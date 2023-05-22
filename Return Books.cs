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
    public partial class Return_Books : Form
    {
        SqlConnection conn = new SqlConnection(@"Server = LENOVO-LEGION-5 ; Database = lib_sys ; Integrated Security = true");
        SqlCommand cmd;
        SqlDataReader reader;


        public Return_Books()
        {
            InitializeComponent();
        }

        private int returnprice(DateTime firstdate, DateTime lastdate, int price)
        {
            int numofdays = 0;
            TimeSpan difference = lastdate - firstdate;
            numofdays = difference.Days;
            return numofdays * price;
        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            string status = "Returned";

            // this userdata

            string username = "";
            string Title = "";
            string statusresult = "";
            DateTime firstdate;
            DateTime lastdate;
            int price = 0;

            //

            int qnt = 1;
            try
            {
                string select_qr = $"SELECT Users.Username, Books.Title, bowrrowed_books.first_date, bowrrowed_books.end_date, Books.Price, bowrrowed_books.status " +
                "FROM bowrrowed_books " +
                "JOIN Users ON Users.UserID = bowrrowed_books.UserID_borrow " +
                $"JOIN Books ON Books.ID = bowrrowed_books.BookID_borrow " +
                $"WHERE BookID_borrow = {Convert.ToInt32(IDBook_txt.Text)} AND Users.UserID = {Convert.ToInt32(iduser_txt.Text)};";
                cmd = new SqlCommand(select_qr, conn);
                conn.Open();
                reader = cmd.ExecuteReader();
                if (!reader.Read())
                {

                    throw new Exception("the Book ID or UserID Invalid\nmake sure you entered correct data");

                }
                username = reader.GetString(0);
                Title = reader.GetString(1);
                firstdate = reader.GetDateTime(2);
                lastdate = reader.GetDateTime(3);
                price = reader.GetInt32(4);
                statusresult = reader.GetString(5);
                TimeSpan difference = lastdate - firstdate;
                reader.Close();



                string update_qr = $"update bowrrowed_books\r\nset status = '{status}'\r\nwhere BookID_borrow = {Convert.ToInt32(IDBook_txt.Text)};";
                cmd = new SqlCommand(update_qr, conn);
                cmd.ExecuteNonQuery();

                if (statusresult == status)
                {
                    MessageBox.Show("the book is already returned", "Return", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string update_qr2 = $"update Books\r\nset Quantity +={qnt}\r\nwhere ID ={Convert.ToInt32(IDBook_txt.Text)};";
                    cmd = new SqlCommand(update_qr2, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"Username: {username}\nTitle: {Title}\nUnit Price: {price}\nNumber of Days: {difference.Days}\nTotal Price: {returnprice(firstdate, lastdate, price)} EGP\nStatus: {status}", "Return", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                


            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                iduser_txt.Clear();
                IDBook_txt.Clear();
            }

        }
    }
}
