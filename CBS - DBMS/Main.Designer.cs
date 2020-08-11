namespace CBS___DBMS
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.mnuS1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnulo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMI_rec = new System.Windows.Forms.ToolStripMenuItem();
            this.vTSMI_newCan = new System.Windows.Forms.ToolStripMenuItem();
            this.vTSMI_view = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_elec = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_results = new System.Windows.Forms.ToolStripMenuItem();
            this.stat1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsluser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reZeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuS1.SuspendLayout();
            this.stat1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuS1
            // 
            this.mnuS1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.tSMI_rec,
            this.testToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.mnuS1.Location = new System.Drawing.Point(0, 0);
            this.mnuS1.Name = "mnuS1";
            this.mnuS1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mnuS1.Size = new System.Drawing.Size(685, 24);
            this.mnuS1.TabIndex = 2;
            this.mnuS1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnulo,
            this.mnuExit});
            this.fileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fileToolStripMenuItem.Image")));
            this.fileToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // mnulo
            // 
            this.mnulo.Image = ((System.Drawing.Image)(resources.GetObject("mnulo.Image")));
            this.mnulo.Name = "mnulo";
            this.mnulo.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt)
                        | System.Windows.Forms.Keys.L)));
            this.mnulo.Size = new System.Drawing.Size(175, 22);
            this.mnulo.Text = "&Logout";
            this.mnulo.Click += new System.EventHandler(this.mnulo_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Image = ((System.Drawing.Image)(resources.GetObject("mnuExit.Image")));
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuExit.Size = new System.Drawing.Size(175, 22);
            this.mnuExit.Text = "&Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // tSMI_rec
            // 
            this.tSMI_rec.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vTSMI_newCan,
            this.vTSMI_view});
            this.tSMI_rec.Image = ((System.Drawing.Image)(resources.GetObject("tSMI_rec.Image")));
            this.tSMI_rec.Name = "tSMI_rec";
            this.tSMI_rec.Size = new System.Drawing.Size(77, 20);
            this.tSMI_rec.Text = "&Records";
            // 
            // vTSMI_newCan
            // 
            this.vTSMI_newCan.Image = global::CBS___DBMS.Properties.Resources.add;
            this.vTSMI_newCan.Name = "vTSMI_newCan";
            this.vTSMI_newCan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.vTSMI_newCan.Size = new System.Drawing.Size(198, 22);
            this.vTSMI_newCan.Text = "&New Candidate";
            this.vTSMI_newCan.Click += new System.EventHandler(this.vTSMI_newCan_Click);
            // 
            // vTSMI_view
            // 
            this.vTSMI_view.Image = ((System.Drawing.Image)(resources.GetObject("vTSMI_view.Image")));
            this.vTSMI_view.Name = "vTSMI_view";
            this.vTSMI_view.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
            this.vTSMI_view.Size = new System.Drawing.Size(198, 22);
            this.vTSMI_view.Text = "&View";
            this.vTSMI_view.Click += new System.EventHandler(this.vTSMI_view_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateCodeToolStripMenuItem,
            this.tsm_elec,
            this.tsm_results});
            this.testToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("testToolStripMenuItem.Image")));
            this.testToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.testToolStripMenuItem.Text = "&Election";
            // 
            // generateCodeToolStripMenuItem
            // 
            this.generateCodeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateToolStripMenuItem,
            this.printToolStripMenuItem});
            this.generateCodeToolStripMenuItem.Name = "generateCodeToolStripMenuItem";
            this.generateCodeToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.generateCodeToolStripMenuItem.Text = "Voter\'s Code";
            // 
            // generateToolStripMenuItem
            // 
            this.generateToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("generateToolStripMenuItem.Image")));
            this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            this.generateToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.generateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.generateToolStripMenuItem.Text = "Generate";
            this.generateToolStripMenuItem.Click += new System.EventHandler(this.generateToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.printToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // tsm_elec
            // 
            this.tsm_elec.Image = ((System.Drawing.Image)(resources.GetObject("tsm_elec.Image")));
            this.tsm_elec.Name = "tsm_elec";
            this.tsm_elec.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.tsm_elec.Size = new System.Drawing.Size(173, 22);
            this.tsm_elec.Text = "Election Proper";
            this.tsm_elec.Click += new System.EventHandler(this.tsm_elec_Click);
            // 
            // tsm_results
            // 
            this.tsm_results.Image = ((System.Drawing.Image)(resources.GetObject("tsm_results.Image")));
            this.tsm_results.Name = "tsm_results";
            this.tsm_results.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.tsm_results.Size = new System.Drawing.Size(173, 22);
            this.tsm_results.Text = "Results";
            this.tsm_results.Click += new System.EventHandler(this.tsm_results_Click);
            // 
            // stat1
            // 
            this.stat1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsluser,
            this.toolStripStatusLabel2,
            this.tslDate});
            this.stat1.Location = new System.Drawing.Point(0, 368);
            this.stat1.Name = "stat1";
            this.stat1.Size = new System.Drawing.Size(685, 24);
            this.stat1.TabIndex = 3;
            this.stat1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(87, 19);
            this.toolStripStatusLabel1.Text = "LOGGED IN AS:";
            // 
            // tsluser
            // 
            this.tsluser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsluser.ForeColor = System.Drawing.Color.Red;
            this.tsluser.Name = "tsluser";
            this.tsluser.Size = new System.Drawing.Size(157, 19);
            this.tsluser.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(199, 19);
            this.toolStripStatusLabel2.Text = "                                                  TODAY:";
            // 
            // tslDate
            // 
            this.tslDate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslDate.ForeColor = System.Drawing.Color.Blue;
            this.tslDate.Name = "tslDate";
            this.tslDate.Size = new System.Drawing.Size(140, 19);
            this.tslDate.Text = "toolStripStatusLabel3";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reZeroToolStripMenuItem});
            this.toolsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("toolsToolStripMenuItem.Image")));
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // reZeroToolStripMenuItem
            // 
            this.reZeroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reZeroToolStripMenuItem.Image")));
            this.reZeroToolStripMenuItem.Name = "reZeroToolStripMenuItem";
            this.reZeroToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reZeroToolStripMenuItem.Text = "Re-Zero";
            this.reZeroToolStripMenuItem.Click += new System.EventHandler(this.reZeroToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(685, 392);
            this.ControlBox = false;
            this.Controls.Add(this.mnuS1);
            this.Controls.Add(this.stat1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CBS Automated Election 1.6";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.mnuS1.ResumeLayout(false);
            this.mnuS1.PerformLayout();
            this.stat1.ResumeLayout(false);
            this.stat1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuS1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnulo;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem tSMI_rec;
        private System.Windows.Forms.ToolStripMenuItem vTSMI_view;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsm_elec;
        private System.Windows.Forms.ToolStripMenuItem tsm_results;
        private System.Windows.Forms.StatusStrip stat1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsluser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tslDate;
        private System.Windows.Forms.ToolStripMenuItem vTSMI_newCan;
        private System.Windows.Forms.ToolStripMenuItem generateCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reZeroToolStripMenuItem;
    }
}