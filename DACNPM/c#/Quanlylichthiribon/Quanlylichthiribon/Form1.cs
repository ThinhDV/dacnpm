using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VS2
{
    public partial class Form1 : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public void frmLogin() {
            Form frm = new Form3();
            frm.ShowDialog();
        }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmLogin();
           
        }

        private void buttonItem18_Click(object sender, EventArgs e)
        {
            //this.closeAllMdi();
            Frmmon frmMH = new Frmmon();
            //frmMH.WindowState = FormWindowState.Maximized;
            frmMH.MdiParent = this;
            frmMH.Show();
        }
       

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            Form frmK = new Qlkhoa();
            //frmMH.WindowState = FormWindowState.Maximized;
            frmK.MdiParent = this;
            frmK.Show();
        }

        private void buttonItem20_Click(object sender, EventArgs e)
        {
            //this.closeAllMdi();
            hocphan frmHP = new hocphan();
            //frmMH.WindowState = FormWindowState.Maximized;
            frmHP.MdiParent = this;
            frmHP.Show();
        }

        private void buttonItem15_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem17_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem9_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem11_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem4_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem5_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem7_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem8_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem13_Click(object sender, EventArgs e)
        {
            Form ab = new about();
            ab.ShowDialog();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem21_Click(object sender, EventArgs e)
        {
            frmLogin();
        }

        private void bthoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn muốn thoát khỏi chương trình", "Exit",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit(); 
        }

       

        
    }
}
