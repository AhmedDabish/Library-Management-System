using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using user_interface;
using System.Diagnostics.Eventing.Reader;

namespace WindowsFormsApplication1
{
    public partial class Login_Form : Form
    {


        SqlConnection conn = new SqlConnection(@"Server = LENOVO-LEGION-5 ; Database = lib_sys ; Integrated Security = true");
        SqlCommand cmd;
        SqlDataReader reader;




        public Login_Form()
        {
            InitializeComponent();


        }



        private void Login_Form_Load(object sender, EventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(200, 0, 0, 0);
        }

        private void sign_up_btn_Click(object sender, EventArgs e)
        {
            Register frm2 = new Register();
            frm2.hideitem("Librarian");

            frm2.Show();
        }




        private void login_btn_Click(object sender, EventArgs e)
        {
            string select_qr = "";
            try
            {

                string user = user_txt.Text;
                string password = password_txt.Text;
                string type = "";



                if (type_box.SelectedItem == null)
                {
                    throw new Exception("Please, choose the Type");
                }
                else
                {
                    type = type_box.SelectedItem.ToString();
                }

                select_qr = $"select Username , password , type , Email  from Users\r\n where Username = '{user}' and password ='{password}' and type = '{type}';";

                cmd = new SqlCommand(select_qr, conn);
                conn.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {


                        if (user == reader.GetString(0) && password == reader.GetString(1))
                        {

                            if ("Librarian" == reader.GetString(2))
                            {

                                MessageBox.Show($"login succefully\nwelcome {user}", "login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                librarian_interface frm1 = new librarian_interface();
                                frm1.Show();
                                this.Hide();
                                break;
                            }
                            else if ("User" == reader.GetString(2))
                            {

                                MessageBox.Show($"login succefully\nwelcome {user}", "login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                User frm2 = new User();
                                frm2.email_login = reader.GetString(3);
                                frm2.Show();
                                this.Hide();
                                break;
                            }
                            else if ("Admin" == reader.GetString(2))
                            {
                                MessageBox.Show($"login succefully\nwelcome {user}", "login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                adminform frm3 = new adminform();
                                frm3.Show();
                                this.Hide();
                                break;
                            }


                        }

                    }

                }
                else
                {
                    MessageBox.Show("invalid Login", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                
                conn.Close();
                user_txt.Clear();
                password_txt.Clear();
                type_box.SelectedIndex = -1;
            }


        }




        private void user_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
