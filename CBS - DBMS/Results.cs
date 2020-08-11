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
    public partial class Codes : Form
    {
        public Codes()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            SqlConnection COn = new SqlConnection("SERVER=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\CBS_DB.mdf;Integrated Security=True;User Instance=True");


           string sql = null;


           COn.Open();

           sql = "SELECT cName, cPosition, cParty, cVotes FROM candidates";
           SqlDataAdapter dscmd = new SqlDataAdapter(sql, COn);
           COn.Close();

 

           DataSet1 ds = new DataSet1();
           dscmd.Fill(ds, "candidates");

 

           CrystalReport3 objRpt = new CrystalReport3();
           objRpt.SetDataSource(ds.Tables[0]);
           crystalReportViewer2.ReportSource = objRpt;
           crystalReportViewer2.Refresh();

        }
    }   
}
