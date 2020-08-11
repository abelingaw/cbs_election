using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace CBS___DBMS
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void vTSMI_newCan_Click(object sender, EventArgs e)
        {
            Candidate Candd8 = new Candidate();
            Candd8.ShowDialog();
        }

        private void vTSMI_view_Click(object sender, EventArgs e)
        {
            CandidateList cdlist = new CandidateList();
            cdlist.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            DateTime datenow = DateTime.Today;
            this.tsluser.Text = Login.userid;
            this.tslDate.Text = datenow.ToString("MMMM dd, yyyy") + " " + DateAndTime.TimeOfDay.TimeOfDay;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            string exit_app = System.Convert.ToString(MessageBox.Show("Quit Application?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (exit_app == Convert.ToString(DialogResult.Yes))
            {
                Application.Exit();
            }
            else
            {

            }
        }


        private void mnulo_Click(object sender, EventArgs e)
        {
            string log_out = System.Convert.ToString(MessageBox.Show("Are you sure to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (log_out == Convert.ToString(DialogResult.Yes))
            {
                this.Hide();
                Login frmLog = new Login();
                frmLog.Show();
            }
            else
            {
               
            }
        }

        private void tsm_elec_Click(object sender, EventArgs e)
        {
            Code VoteForm = new Code();
            VoteForm.ShowDialog();
        }

        private void generateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateCode Genform = new GenerateCode();
            Genform.ShowDialog();
        }


        private void tsm_results_Click(object sender, EventArgs e)
        {
            Codes RForm = new Codes();
            RForm.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.ShowDialog();
        }

        private void reZeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tools TForm = new Tools();
            TForm.ShowDialog();
        }


    }
}