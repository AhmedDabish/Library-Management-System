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
using user_interface;

namespace WindowsFormsApplication1
{
    public partial class librarian_interface : Form
    {
        SqlConnection conn = new SqlConnection(@"Server = LENOVO-LEGION-5 ; Database = lib_sys ; Integrated Security = true");
        SqlCommand cmd;
        public librarian_interface()
        {
            InitializeComponent();
        }

        private void librarian_interface_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            main_panel.Controls.Clear();
            Add_books frm = new Add_books();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.main_panel.Controls.Add(frm);
            this.main_panel.Tag = frm;
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            main_panel.Controls.Clear();
            Delete_Books frm = new Delete_Books();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.main_panel.Controls.Add(frm);
            this.main_panel.Tag = frm;
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            main_panel.Controls.Clear();
            Return_Books frm = new Return_Books();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.main_panel.Controls.Add(frm);
            this.main_panel.Tag = frm;
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            main_panel.Controls.Clear();
            BorrowedBooks frm = new BorrowedBooks();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.main_panel.Controls.Add(frm);
            this.main_panel.Tag = frm;
            frm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            main_panel.Controls.Clear();
            searchForm frm = new searchForm();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.main_panel.Controls.Add(frm);
            this.main_panel.Tag = frm;
            frm.Show();
        }

        private void show_books_Click(object sender, EventArgs e)
        {
            main_panel.Controls.Clear();
            showform frm = new showform();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.main_panel.Controls.Add(frm);
            this.main_panel.Tag = frm;
            frm.Show();
        }

        private void Log_out_Click(object sender, EventArgs e)
        {
            Login_Form frm = new Login_Form();

            DialogResult res = MessageBox.Show("are you sure want log out?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Login_Form frm2 = new Login_Form();
                frm2.Show();
                this.Hide();

            }
        }
    }
}
