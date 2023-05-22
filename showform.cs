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

namespace user_interface
{
    public partial class showform : Form
    {
        SqlConnection conn = new SqlConnection(@"Server = LENOVO-LEGION-5 ; Database = lib_sys ; Integrated Security = true");
        SqlDataAdapter adapter;
        DataSet ds = new DataSet();


        public showform()
        {
            InitializeComponent();

            string select_query = "select * from Books\r\norder by ID,section asc;";
            adapter = new SqlDataAdapter(select_query, conn);

            adapter.Fill(ds, "Books");

            dataGridViewbooks.DataSource = ds.Tables["Books"];

        }

        private void showform_Load(object sender, EventArgs e)
        {


        }
    }
}
