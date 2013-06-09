using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VS2
{
    public partial class hocphan : Form
    {
        String strConnet = @"Data Source=.\SQLEXPRESS;Initial Catalog=quanlylichthi;Integrated Security=True";
        SqlConnection con = null;
        SqlDataAdapter datb = null;
        DataTable dttb = null;
        public hocphan()
        {
            InitializeComponent();
        }

        private void hocphan_Load(object sender, EventArgs e)
        {
            try
            {

                con = new SqlConnection(strConnet);
                datb = new SqlDataAdapter(@"Select * from MON_THI",con);
                dttb = new DataTable();
                dttb.Clear();
                datb.Fill(dttb);
                dataGridViewX1.DataSource = dttb;
                dataGridViewX1.AutoResizeColumns();

            }
            catch(SqlException) { 
                MessageBox.Show(@"Không lấy được nội dung trong table. Lỗi rồi!!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form addhocphan = new addHocphan();
            addhocphan.ShowDialog();
        }
    }
}
