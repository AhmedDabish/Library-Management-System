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
    public partial class BorrowedBooks : Form
    {
        SqlConnection conn = new SqlConnection(@"Server = LENOVO-LEGION-5 ; Database = lib_sys ; Integrated Security = true");
        SqlDataAdapter adapter;
        DataSet ds = new DataSet();
        public BorrowedBooks()
        {
            InitializeComponent();
            string select_query = "select * from bowrrowed_books\r\norder by status asc;";
            adapter = new SqlDataAdapter(select_query, conn);

            adapter.Fill(ds, "Borrowed Books");

            dataGridViewBorrow.DataSource = ds.Tables["Borrowed Books"];
        }
    }
}
