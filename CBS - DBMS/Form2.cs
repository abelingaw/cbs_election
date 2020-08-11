using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using CrystalDecisions.CrystalReports.Engine;
namespace CBS___DBMS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection COn = new SqlConnection("SERVER=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\CBS_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");


            string sql = null;


            COn.Open();

            sql = "SELECT Vcode FROM Codes";
            SqlDataAdapter dscmd = new SqlDataAdapter(sql, COn);
            COn.Close();



            DataSet1 ds = new DataSet1();
            dscmd.Fill(ds, "Codes");



            CrystalReport4 objRpt = new CrystalReport4();
            objRpt.SetDataSource(ds.Tables[1]);
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
