using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Data.Sql;
using System.Data.OleDb;

namespace VS2
{
    public partial class Frmmon : DevComponents.DotNetBar.Office2007Form
    {
        String strConnet = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLLT;Integrated Security=True";
        SqlConnection con = null;
        SqlDataAdapter datb = null;
        DataTable dttb = null;
        
        public Frmmon()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {

                con = new SqlConnection(strConnet);
                datb = new SqlDataAdapter(@"Select * from MON_HOC", con);
                dttb = new DataTable();
                dttb.Clear();
                datb.Fill(dttb);
                datamon.DataSource = dttb;
                datamon.AutoResizeColumns();
                con.Close();

            }
            catch (SqlException)
            {
                MessageBox.Show(@"Không lấy được nội dung trong table. Lỗi rồi!!!");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            addMonhoc frmadmon = new addMonhoc();
           // frmadmon.MdiParent = from Form1;
            frmadmon.Show();
        
        }

    }
}
