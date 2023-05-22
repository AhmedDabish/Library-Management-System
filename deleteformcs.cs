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

namespace user_interface
{
    public partial class deleteformcs : Form
    {
        SqlConnection conn = new SqlConnection(@"Server = LENOVO-LEGION-5 ; Database = lib_sys ; Integrated Security = true");
        SqlCommand cmd;
        SqlDataReader reader;
        public deleteformcs()
        {
            InitializeComponent();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (deletelib_txt.Text == "")
                {
                    throw new Exception("please Enter Librarian ID");

                }


                string Librarian = "Librarian";
                string select_qr = $"select UserID , type from  Users\r\n where UserID ={Convert.ToInt32(deletelib_txt.Text)} and type = '{Librarian}';";
                cmd = new SqlCommand(select_qr, conn);
                conn.Open();
                reader = cmd.ExecuteReader();
                reader.Read();

                if (reader.HasRows)
                {
                    string delete_qr = $"delete from Users where UserID ={Convert.ToInt32(deletelib_txt.Text)} and type = '{reader[1]}'";
                    reader.Close();
                    cmd = new SqlCommand(delete_qr, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted Succefully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("there is no librarian", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }

            catch (SqlException ex)
            {
                MessageBox.Show("the problem is " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            finally
            {


                conn.Close();
                deletelib_txt.Clear();


            }
        }
    }
}
