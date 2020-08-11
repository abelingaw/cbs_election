using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CBS___DBMS
{
    public partial class Voting : Form
    {

        SqlConnection COn = new SqlConnection("SERVER=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\CBS_DB.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd2 = new SqlCommand();
        SqlDataAdapter rs = new SqlDataAdapter();
        SqlDataReader rdr;


        public string CanID;
        public int COUNTER = 0;

        public Voting()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            string ExitVote = System.Convert.ToString(MessageBox.Show("Are you sure to cancel your vote?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (ExitVote == Convert.ToString(DialogResult.Yes))
            {
                this.Close();
            }
            else
            {

            }
        }

        private void Voting_Load(object sender, EventArgs e)
        {
            cmd.Connection = COn;
            cmd2.Connection = COn;


        }

        private void picPres_Click(object sender, EventArgs e)
        {
            
            string SureVote = System.Convert.ToString(MessageBox.Show("Vote for this Candidate?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (SureVote == Convert.ToString(DialogResult.Yes))
            {
                CanID = "DCCP-CBS-2014-001";
                Vote();
                tbc_candidate.TabPages.Remove(tabPage1);
                tbc_candidate.SelectedTab = tabPage2;
            }
            else
            {
                return;
            }
        }


        public void Vote()

        {
            COn.Open();

            string SQL = "SELECT * FROM candidates";
            SqlCommand cmd = new SqlCommand(SQL, COn);
            SqlCommand cmd2 = new SqlCommand(SQL, COn);

            rdr = cmd2.ExecuteReader();

            rdr.Read();
            COUNTER = Convert.ToInt32(rdr["cVotes"]) + 1;
            rdr.Close();

            cmd.CommandText = "UPDATE candidates SET [cVotes] = @COUNTER WHERE CID = '" + CanID + "' ";
            cmd.Parameters.AddWithValue("@COUNTER", COUNTER);

            cmd.ExecuteNonQuery();
            cmd.Clone();

            MessageBox.Show("Vote Casted.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            COn.Close();

        }

        private void picpres2_Click(object sender, EventArgs e)
        {
            string SureVote = System.Convert.ToString(MessageBox.Show("Vote for this Candidate?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (SureVote == Convert.ToString(DialogResult.Yes))
            {
                CanID = "DCCP-CBS-2014-002";
                Vote();
                tbc_candidate.TabPages.Remove(tabPage1);
                tbc_candidate.SelectedTab = tabPage2;
            }
            else
            {
                return;
            }
        }

        private void vp1_Click(object sender, EventArgs e)
        {
            CanID = "DCCP-CBS-2014-003";
            Vote();
            tbc_candidate.TabPages.Remove(tabPage2);
            tbc_candidate.SelectedTab = tabPage3;
        }

        private void vp2_Click(object sender, EventArgs e)
        {
            CanID = "DCCP-CBS-2014-004";
            Vote();
            tbc_candidate.TabPages.Remove(tabPage2);
            tbc_candidate.SelectedTab = tabPage3;
        }

        private void sec1_Click(object sender, EventArgs e)
        {
            CanID = "DCCP-CBS-2014-005";
            Vote();
            tbc_candidate.TabPages.Remove(tabPage3);
            tbc_candidate.SelectedTab = tabPage4;
        }

        private void sec2_Click(object sender, EventArgs e)
        {
            CanID = "DCCP-CBS-2014-006";
            Vote();
            tbc_candidate.TabPages.Remove(tabPage3);
            tbc_candidate.SelectedTab = tabPage4;
        }

        private void asec1_Click(object sender, EventArgs e)
        {
            CanID = "DCCP-CBS-2014-007";
            Vote();
            tbc_candidate.TabPages.Remove(tabPage4);
            tbc_candidate.SelectedTab = tabPage5;
        }

        private void asec2_Click(object sender, EventArgs e)
        {
            CanID = "DCCP-CBS-2014-008";
            Vote();
            tbc_candidate.TabPages.Remove(tabPage4);
            tbc_candidate.SelectedTab = tabPage5;
        }

        private void treas1_Click(object sender, EventArgs e)
        {
            CanID = "DCCP-CBS-2014-009";
            Vote();
            tbc_candidate.TabPages.Remove(tabPage5);
            tbc_candidate.SelectedTab = tabPage6;
        }

        private void treas2_Click(object sender, EventArgs e)
        {
            CanID = "DCCP-CBS-2014-0010";
            Vote();
            tbc_candidate.TabPages.Remove(tabPage5);
            tbc_candidate.SelectedTab = tabPage6;
        }

        private void at1_Click(object sender, EventArgs e)
        {
            CanID = "DCCP-CBS-2014-0011";
            Vote();
            tbc_candidate.TabPages.Remove(tabPage6);
            tbc_candidate.SelectedTab = tabPage7;
        }

        private void at2_Click(object sender, EventArgs e)
        {
            CanID = "DCCP-CBS-2014-0012";
            Vote();
            tbc_candidate.TabPages.Remove(tabPage6);
            tbc_candidate.SelectedTab = tabPage7;
        }

        private void aud1_Click(object sender, EventArgs e)
        {
            CanID = "DCCP-CBS-2014-0013";
            Vote();
            tbc_candidate.TabPages.Remove(tabPage7);
            tbc_candidate.SelectedTab = tabPage8;
        }

        private void aud2_Click(object sender, EventArgs e)
        {
            CanID = "DCCP-CBS-2014-0014";
            Vote();
            tbc_candidate.TabPages.Remove(tabPage7);
            tbc_candidate.SelectedTab = tabPage8;
        }

        private void pio1_Click(object sender, EventArgs e)
        {
            CanID = "DCCP-CBS-2014-0015";
            Vote();
            tbc_candidate.TabPages.Remove(tabPage8);
            tbc_candidate.SelectedTab = tabPage9;
        }

        private void pio2_Click(object sender, EventArgs e)
        {
            CanID = "DCCP-CBS-2014-0016";
            Vote();
            tbc_candidate.TabPages.Remove(tabPage8);
            tbc_candidate.SelectedTab = tabPage9;
        }

        private void sm1_Click(object sender, EventArgs e)
        {
            CanID = "DCCP-CBS-2014-0017";
            Vote();
            tbc_candidate.TabPages.Remove(tabPage9);
            this.Close();
        }

        private void sm2_Click(object sender, EventArgs e)
        {
            CanID = "DCCP-CBS-2014-0018";
            Vote();
            tbc_candidate.TabPages.Remove(tabPage9);
            this.Close();
        }

        private void Load_Data()
        {
            rs = new SqlDataAdapter("SELECT * FROM candidates", COn);


        }
    }
}