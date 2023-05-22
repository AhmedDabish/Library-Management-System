using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Delete_Books : Form
    {
        SqlConnection conn = new SqlConnection(@"Server = LENOVO-LEGION-5 ; Database = lib_sys ; Integrated Security = true");
        SqlCommand cmd;
        SqlDataReader reader;
        public Delete_Books()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void delte_txt_Click(object sender, EventArgs e)
        {
            try
            {
                if(IDbk_txt.Text == "")
                {
                    throw new Exception("Enter Book ID");
                }



                string select_qr = $"select ID from  Books\r\n where ID ={Convert.ToInt32(IDbk_txt.Text)};";
                cmd = new SqlCommand(select_qr, conn);
                conn.Open();
                reader = cmd.ExecuteReader();
                reader.Read();

                if (reader.HasRows)
                {
                    string delete_qr = $"delete Books from Books \r\nwhere Books.ID = {Convert.ToInt32(IDbk_txt.Text)};";
                    reader.Close();
                    cmd = new SqlCommand(delete_qr, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted Succefully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Book is not exist", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }

            catch(SqlException ex)  
            {
                MessageBox.Show("the problem is " + ex.Message,"Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                conn.Close();
                IDbk_txt.Clear();
            }
        }
    }
}
