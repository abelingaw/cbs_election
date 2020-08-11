using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace CBS___DBMS
{
    public partial class Code : Form
    {

        SqlConnection COn = new SqlConnection("SERVER=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\CBS_DB.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter rs = new SqlDataAdapter();

        public string userid;

        public Code()
        {
            InitializeComponent();
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            if (txt_code.Text !="")
            {

                COn.Open();
                string SQL = "SELECT * FROM Codes WHERE Vcode ='" + txt_code.Text + "'";

                SqlCommand cmd = new SqlCommand(SQL, COn);
                SqlDataReader rd = cmd.ExecuteReader();


                if (rd.Read() == false)
                {
                    MessageBox.Show("Invalid Voter's code.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_code.Text = "";
                    txt_code.Focus();
                    COn.Close();
                }
                else
                {
                    userid = txt_code.Text;

                    //MessageBox.Show("Welcome to the System, sir " + userid, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    COn.Close();
                    txt_code.Text = "";
                    //this.Hide();


                    Voting VoteForm = new Voting();
                    VoteForm.ShowDialog();
                }
            }
            else
                MessageBox.Show("Voter's code Required.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txt_code.Focus();
        }

        private void Code_Load(object sender, EventArgs e)
        {

        }
    }
}