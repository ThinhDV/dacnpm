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
    public partial class Qlkhoa : DevComponents.DotNetBar.Office2007Form
    {
        String strConnet = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLLT;Integrated Security=True";
        SqlConnection con = null;
        SqlDataAdapter datb = null;
        DataTable dttb = null;
        public Qlkhoa()
        {
            InitializeComponent();
        }

        private void Qlkhoa_Load(object sender, EventArgs e)
        {
            try
            {

                con = new SqlConnection(strConnet);
                datb = new SqlDataAdapter(@"Select makhoa as [Mã khoa], tenkhoa as [Tên khoa] from KHOA", con);
                dttb = new DataTable();
                dttb.Clear();
                datb.Fill(dttb);
                datakhoa.DataSource = dttb;
                datakhoa.AutoResizeColumns();
                con.Close();

            }
            catch (SqlException)
            {
                MessageBox.Show(@"Không lấy được nội dung trong table. Lỗi rồi!!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            Form adk = new addkhoa();
            adk.ShowDialog();
            dttb.Clear();
            datb.Fill(dttb);
            datakhoa.DataSource = dttb;
            datakhoa.AutoResizeColumns();
            con.Close();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (datakhoa.Rows.Count >= 1)
            {
                try
                {
                    con.Open();

                    SqlCommand cmdXoa = new SqlCommand();
                    cmdXoa.CommandType = CommandType.Text;
                    cmdXoa.Connection = con;

                    int r = datakhoa.CurrentCell.RowIndex;

                    string strCompare = datakhoa.Rows[r].Cells[0].Value.ToString();
                    cmdXoa.CommandText = string.Concat("DELETE FROM KHOA WHERE makhoa='" + strCompare + "'");
                    cmdXoa.ExecuteNonQuery();
                    DialogResult ok;
                    ok = MessageBox.Show("Đã xóa thành công");
                    dttb.Clear();
                    datb.Fill(dttb);
                    datakhoa.DataSource = dttb;
                    datakhoa.AutoResizeColumns();
                    con.Close();
                    con.Close();

                    //loadDataToGridviewGV();
                }
                catch (SqlException)
                {
                    //lbstatus.Text = "Can't delete";
                    con.Close();
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
