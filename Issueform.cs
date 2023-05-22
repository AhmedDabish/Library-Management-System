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
    public partial class Issueform : Form
    {

        SqlConnection conn = new SqlConnection(@"Server = LENOVO-LEGION-5 ; Database = lib_sys ; Integrated Security = true");
        SqlCommand cmd;
        SqlDataReader reader;
        public Issueform()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Issue_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int qnt = 1;
                string status = "Borrowed";

                string select_qr = $"select Quantity \r\nfrom Books  \r\nwhere ID = {Convert.ToInt32(Bkid_txt.Text)}and Title ='{Title_txt.Text}';";
                cmd = new SqlCommand(select_qr, conn);
                conn.Open();
                reader = cmd.ExecuteReader();
                if (!reader.Read())
                {
                    throw new Exception("the Book not found or You entered the Data Wrong\nmake sure you Entered the Correct Book ID and it's Title");
                }
                else if (reader.GetInt32(0) <= 0)
                {
                    throw (new Exception("the Book is unavaliable"));
                }
                reader.Close();

                string update_qr2 = $"update Books\r\nset Quantity -={qnt}\r\nwhere ID ={Convert.ToInt32(Bkid_txt.Text)};";
                cmd = new SqlCommand(update_qr2, conn);
                cmd.ExecuteNonQuery();
                

                string select_qr3 = $"select BookID_borrow from bowrrowed_books\r\nwhere UserID_borrow ={Convert.ToInt32(userid_txt.Text)} and BookID_borrow = {Convert.ToInt32(Bkid_txt.Text)};";

                cmd = new SqlCommand(select_qr3, conn);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                { 
                    reader.Close();
                    throw new Exception("you already borrow this book");

                }
                else
                {
                    reader.Close();
                    string insert_qr = $"insert into bowrrowed_books(BookID_borrow,ID,UserID_borrow,first_date,end_date,status) values({Convert.ToInt32(Bkid_txt.Text)},{Convert.ToInt32(Bkid_txt.Text)},{Convert.ToInt32(userid_txt.Text)},'{dateTimePickerfirst.Value.ToString("yyyy-MM-dd")}','{enddate.Value.ToString("yyyy-MM-dd")}','{status}')";
                    cmd = new SqlCommand(insert_qr, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The Book is Borrowed Succefully","Borrow", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                
               

               

            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message,"Error" , MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                conn.Close();
            }
        }
    }
}
