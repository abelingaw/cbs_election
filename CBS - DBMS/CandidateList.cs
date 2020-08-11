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
    public partial class CandidateList : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd2 = new SqlCommand();
  
        public CandidateList()
        {
            InitializeComponent();
            cn.ConnectionString = "SERVER=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\CBS_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CandidateList_Load(object sender, EventArgs e)
        {
            lvwCandidate.Items.Clear();

            cn.Open();

            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM candidates ORDER BY CID ASC";

            try
            {
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    ListViewItem item = new ListViewItem(rdr["CID"].ToString());

                    item.SubItems.Add(rdr["cName"].ToString());
                    item.SubItems.Add(rdr["cCourse"].ToString());
                    item.SubItems.Add(rdr["cYL"].ToString());
                    item.SubItems.Add(rdr["cPosition"].ToString());
                    item.SubItems.Add(rdr["cParty"].ToString());

                    lvwCandidate.Items.Add(item);

                }

                cn.Close();
                
            }


            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            string DelRec = System.Convert.ToString(MessageBox.Show("Delete Record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (DelRec == Convert.ToString(DialogResult.Yes))
            {
                foreach (int i in lvwCandidate.SelectedIndices)
                {
                    string Selected = lvwCandidate.Items[i].Text;
                    lvwCandidate.Items.Remove(lvwCandidate.Items[i]);

                    cn.Open();
                    cmd = new SqlCommand();
                    cmd.Connection = cn;

                    cmd.CommandText = "DELETE FROM candidates WHERE CID = '" + Selected + "' ";
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    
                    MessageBox.Show("Record deleted.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                lvwCandidate.Refresh();
            }
            else
            {
                return;
            } 
        }

        private void btn_srch_Click(object sender, EventArgs e)
        {
            cn.Open();
            lvwCandidate.Items.Clear();
            cmd2 = new SqlCommand();
            cmd2.Connection = cn;

            if (cmbFilter.Text == "")
            {
                MessageBox.Show("Select filter first.");
                txtsearch.Text = "";
                cn.Close();
                cmbFilter.Focus();
                return;
            }

            if (cmbFilter.Text == "Name")
            {
                cmd2.CommandText = "SELECT * FROM candidates WHERE cName = '" + txtsearch.Text + "' ";
                cmd2.ExecuteNonQuery();
                txtsearch.Focus();
            }

            if (cmbFilter.Text == "Position")
            {
                cmd2.CommandText = "SELECT * FROM candidates WHERE cPosition = '" + txtsearch.Text + "' ";
                cmd2.ExecuteNonQuery();
                txtsearch.Focus();
            }

            if (cmbFilter.Text == "Party")
            {
                cmd2.CommandText = "SELECT * FROM candidates WHERE cParty = '" + txtsearch.Text + "' ";
                cmd2.ExecuteNonQuery();
                txtsearch.Focus();
            }

            try
            {
                SqlDataReader rdr = cmd2.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        ListViewItem item = new ListViewItem(rdr["CID"].ToString());

                        item.SubItems.Add(rdr["cName"].ToString());
                        item.SubItems.Add(rdr["cCourse"].ToString());
                        item.SubItems.Add(rdr["cYL"].ToString());
                        item.SubItems.Add(rdr["cPosition"].ToString());
                        item.SubItems.Add(rdr["cParty"].ToString());

                        lvwCandidate.Items.Add(item);

                    }

                }

                else
                {
                    MessageBox.Show("No such record.");
                    txtsearch.Text = "";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            cn.Close();
        }




    }
}