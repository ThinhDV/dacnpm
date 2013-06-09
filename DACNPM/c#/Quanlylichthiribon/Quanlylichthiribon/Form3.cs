using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace VS2
{
    public partial class Form3 : DevComponents.DotNetBar.Office2007Form
    {
       
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if ((this.txtUser.Text == "Admin") && (this.txtPass.Text == "Admin"))
            {
                
                this.Close();
            }

            else
            {
                MessageBox.Show("Không đúng tên người dùng / mật khẩu !!!", "Thông báo");
                this.txtUser.Focus();
            } 
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn muốn thoát khỏi chương trình", "Exit",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit(); 
        }
    }
}