using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace user_interface
{
    public partial class adminform : Form
    {
        public adminform()
        {
            InitializeComponent();
        }

        private void delete_lib_Click(object sender, EventArgs e)
        {
            adminpanel.Controls.Clear();
            deleteformcs frm = new deleteformcs();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.adminpanel.Controls.Add(frm);
            this.adminpanel.Tag = frm;
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("are you sure want log out?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Login_Form frmlog = new Login_Form();
                this.Hide();
                frmlog.Show();

            }
        }

        private void Add_lib_Click(object sender, EventArgs e)
        {
            Register frm = new Register();
            frm.hideitem("User");
            frm.HideButton();
            frm.Show();
            
        }
    }
}
