using System.Data.SqlClient;
using WindowsFormsApplication1;
using Microsoft.VisualBasic.ApplicationServices;


namespace user_interface
{
    public partial class User:Form
    {
        public string email_login { get; set; }
        SqlConnection conn = new SqlConnection(@"Server = LENOVO-LEGION-5 ; Database = lib_sys ; Integrated Security = true");
        SqlCommand cmd;
        SqlDataReader reader;
        public User()
        {
            InitializeComponent();
        }
       

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logopanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void search_book_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            searchForm frm = new searchForm();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(frm);
            this.mainpanel.Tag = frm;
            frm.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void show_books_Click(object sender, EventArgs e)
        {


            mainpanel.Controls.Clear();
            showform frm = new showform();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(frm);
            this.mainpanel.Tag = frm;
            frm.Show();

        }

        private void issu_book_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            Issueform frm = new Issueform();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(frm);
            this.mainpanel.Tag = frm;
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void headerpanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void bottompanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void log_out_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("are you sure want log out?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Login_Form login_Form = new Login_Form();
                this.Hide();
                login_Form.Show();

            }
        }

        private void show_id_Click(object sender, EventArgs e)
        {
            string select_qr = $"select UserID from Users\r\nwhere Email = '{email_login}';";
            cmd = new SqlCommand(select_qr,conn);
            conn.Open();
            reader = cmd.ExecuteReader();
            reader.Read();
          
            
            MessageBox.Show($"Your ID is: {reader.GetInt32(0)}","ID",MessageBoxButtons.OK,MessageBoxIcon.Information);

            conn.Close();
            
            

        }
    }
}