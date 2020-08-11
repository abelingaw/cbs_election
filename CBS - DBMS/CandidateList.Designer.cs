namespace CBS___DBMS
{
    partial class CandidateList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CandidateList));
            this.btn_exit = new System.Windows.Forms.Button();
            this.lvwCandidate = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_del = new System.Windows.Forms.Button();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_srch = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.SystemColors.Control;
            this.btn_exit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.Location = new System.Drawing.Point(868, 430);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(97, 32);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "&EXIT";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lvwCandidate
            // 
            this.lvwCandidate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwCandidate.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvwCandidate.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwCandidate.GridLines = true;
            this.lvwCandidate.Location = new System.Drawing.Point(14, 64);
            this.lvwCandidate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvwCandidate.MultiSelect = false;
            this.lvwCandidate.Name = "lvwCandidate";
            this.lvwCandidate.Size = new System.Drawing.Size(950, 358);
            this.lvwCandidate.TabIndex = 47;
            this.lvwCandidate.UseCompatibleStateImageBehavior = false;
            this.lvwCandidate.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Candidate Name";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Course";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Year Level";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Position";
            this.columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Party";
            this.columnHeader6.Width = 150;
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.SystemColors.Control;
            this.btn_del.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.Image = ((System.Drawing.Image)(resources.GetObject("btn_del.Image")));
            this.btn_del.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_del.Location = new System.Drawing.Point(764, 430);
            this.btn_del.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(97, 32);
            this.btn_del.TabIndex = 3;
            this.btn_del.Text = "DELETE";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // cmbFilter
            // 
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "Position",
            "Lastname",
            "Party"});
            this.cmbFilter.Location = new System.Drawing.Point(378, 14);
            this.cmbFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(210, 31);
            this.cmbFilter.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(278, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 56;
            this.label1.Text = "Search By:";
            // 
            // btn_srch
            // 
            this.btn_srch.BackColor = System.Drawing.SystemColors.Control;
            this.btn_srch.FlatAppearance.BorderSize = 0;
            this.btn_srch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_srch.Image = ((System.Drawing.Image)(resources.GetObject("btn_srch.Image")));
            this.btn_srch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_srch.Location = new System.Drawing.Point(868, 14);
            this.btn_srch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_srch.Name = "btn_srch";
            this.btn_srch.Size = new System.Drawing.Size(97, 32);
            this.btn_srch.TabIndex = 2;
            this.btn_srch.Text = "&Search";
            this.btn_srch.UseVisualStyleBackColor = true;
            this.btn_srch.Click += new System.EventHandler(this.btn_srch_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtsearch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(622, 14);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsearch.MaxLength = 35;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(239, 30);
            this.txtsearch.TabIndex = 1;
            // 
            // CandidateList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(978, 476);
            this.ControlBox = false;
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_srch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.lvwCandidate);
            this.Controls.Add(this.btn_exit);
            this.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CandidateList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CANDIDATE LIST";
            this.Load += new System.EventHandler(this.CandidateList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ListView lvwCandidate;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_srch;
        private System.Windows.Forms.TextBox txtsearch;
    }
}