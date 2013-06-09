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
    public partial class addkhoa : Form
    {
        string strConnSQL;
        SqlConnection connSQL;
        DataTable dtTable;
        //private String[] strExport;
        //public event InsertHandler OnInsertHandler;
        private String[] strExport;
        public addkhoa()
        {
            InitializeComponent();
        }

        private void addkhoa_Load(object sender, EventArgs e)
        {
            strConnSQL = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLLT;Integrated Security=True";
            connSQL = new SqlConnection(strConnSQL);
            //strExport = new String[4];
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            //connSQL.Open();
            try
            {
                    connSQL.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connSQL;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = System.String.Concat("Insert Into KHOA Values('"+txtmakhoa.Text.ToString()+"','"+txttenkhoa.Text.ToString()+"')");
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã thêm xong!");
                    this.Close();

                
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            txttenkhoa.Text = "";
            txtmakhoa.Text = "";
        }
    }
}
