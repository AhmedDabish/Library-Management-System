using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{


    public partial class Register : Form
    {
        SqlConnection conn = new SqlConnection(@"Server = LENOVO-LEGION-5 ; Database = lib_sys ; Integrated Security = true");
        SqlCommand cmd;
        SqlDataReader reader;
        public Register()
        {
            InitializeComponent();
            //typ_txt.Hide();
            //label8.Hide();
        }

        private class EmailException : Exception
        {
            public EmailException(string message) : base(message)
            {

            }
        }

        private class UniqueEmailException : Exception
        {
            public UniqueEmailException(string message) : base(message)
            {

            }
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            this.Close();
        }


        public void hideitem(string type)// this function  hide the item of librarian when the User click the sign up button
        {
            if (typ_txt.Items.Contains(type))
            {
                typ_txt.Items.Remove(type);
            }
        }
        public void HideButton()
        {
            button2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string pattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            Regex check = new Regex(pattern);
            string phone = phone_txt.Text;
            string status = "";
            bool ismatch = check.IsMatch(email_txt.Text);



            try
            {

                if (user_txt.Text == "" || pass_txt.Text == "" || phone_txt.Text == "" || email_txt.Text == "" || adr_txt.Text == "" || typ_txt.Text == "")
                {
                    throw new Exception("please fill all the Data");
                }

                if (!ismatch)
                {
                    throw new EmailException("Enter the correct format of the Email");
                }


                string select_qr = $"select Email from Users\r\nwhere Email = '{email_txt.Text}';\r\n";
                cmd = new SqlCommand(select_qr, conn);
                conn.Open();
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    if (reader.GetString(0) == email_txt.Text)
                    {
                        throw new UniqueEmailException("The Email is Already exist \ntry another one");
                    }
                }
                reader.Close();





                if (phone.Length != 11)
                {
                    throw new Exception("Phone number must be at least 11 digits.");
                }

                string insert_qr = "insert into Users (Username, password,Email,phone,address,type) values('" + user_txt.Text + "','" + pass_txt.Text + "','" + email_txt.Text + "','" + phone_txt.Text + "','" + adr_txt.Text + "','" + typ_txt.Text + "')";
                cmd = new SqlCommand(insert_qr, conn);

                cmd.ExecuteNonQuery();
                MessageBox.Show("sign up sucessufully !", "sign up", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);


            }

            catch (EmailException ex)
            {
                status = ex.Message;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UniqueEmailException ex)
            {
                status = ex.Message;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                status = ex.Message;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }




            finally
            {

                if (status == "Phone number must be at least 11 digits.")
                {
                    conn.Close();
                    phone_txt.Clear();
                }
                else if (status == "Enter the correct format of the Email")
                {
                    conn.Close();
                    email_txt.Clear();
                }
                else if (status == "The Email is Already exist \ntry another one")
                {
                    conn.Close();
                    reader.Close();
                    email_txt.Clear();
                }
                else
                {
                    conn.Close();
                    user_txt.Clear();
                    pass_txt.Clear();
                    email_txt.Clear();
                    phone_txt.Clear();
                    adr_txt.Clear();
                    typ_txt.SelectedIndex = -1;

                }









            }
        }
    }
}
