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
    
    
       
    public partial class addMonhoc : Form
    {
        string strConnSQL;
        SqlConnection connSQL;
        DataTable dtTable;
        private String[] strExport;
        public addMonhoc()
        {
            InitializeComponent();
        }

        private void addMonhoc_Load(object sender, EventArgs e)
        {
            strConnSQL = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\db_QLLT.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            connSQL = new SqlConnection(strConnSQL);
            dtTable = new DataTable();

            strExport = new String[9];
        }
    }
}
