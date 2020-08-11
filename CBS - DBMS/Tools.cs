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
    public partial class Tools : Form
    {

        SqlConnection COn = new SqlConnection("SERVER=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\CBS_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd2= new SqlCommand();

        public Tools()
        {
            InitializeComponent();
        }

        private void Tools_Load(object sender, EventArgs e)
        {
            cmd.Connection = COn;
        }

        private void btn_auth_Click(object sender, EventArgs e)
        {
            
            if (txtcode.Text != "")
            {

                COn.Open();
                string SQL = "SELECT * FROM Authenticate WHERE aCode='" + txtcode.Text + "'";

                SqlCommand cmd = new SqlCommand(SQL, COn);
                SqlDataReader rd = cmd.ExecuteReader();


                if (rd.Read() == false)
                {
                    MessageBox.Show("Invalid authentication code.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtcode.Text = "";
                    COn.Close();
                    txtcode.Focus();
                }
                else
                {
                    rd.Close();

                    string rezero = System.Convert.ToString(MessageBox.Show("Perform Re-Zero of all votes?", "Confirm Re-Zero", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                    if (rezero == Convert.ToString(DialogResult.Yes))
                    {
                        string SQL2 = "UPDATE candidates SET cVotes = 0";

                        SqlCommand cmd2= new SqlCommand(SQL2, COn);

                        cmd2.ExecuteNonQuery();
                        cmd2.Clone();

                        MessageBox.Show("Re-Zero successfully completed.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        COn.Close();
                        this.Close();
                    }
                    else
                    {
                        this.Close();
                    }
                    

                }
            }
            else
                MessageBox.Show("Enter username and password", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtcode.Focus();
        }
    }
}
