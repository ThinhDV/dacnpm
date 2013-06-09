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
    public partial class addHocphan : Form
    {
        string strConnSQL;
        SqlConnection connSQL;
        DataTable dtTable;
        //private String[] strExport;
        //public event InsertHandler OnInsertHandler;
        private String[] strExport;
        public addHocphan()
        {
            InitializeComponent();
        }

        private void addHocphan_Load(object sender, EventArgs e)
        {
            strConnSQL = @"Data Source=.\SQLEXPRESS;Initial Catalog=quanlylichthi;Integrated Security=True";
            connSQL = new SqlConnection(strConnSQL);
            strExport = new String[4];
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            connSQL.Open();
            try
            {
                strExport[0] = txtID.Text;
                strExport[1] = txtMaHP.Text;
                strExport[2] = txtMaMH.Text;
                strExport[3] = txtGhichu.Text;
                

                DialogResult rs = MessageBox.Show("Bạn muốn thêm vào CSDL?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (rs == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connSQL;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = System.String.Concat("Insert Into MON_THI Values" + "'" + strExport + "')");
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã thêm xong!"); 

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
