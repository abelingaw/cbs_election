namespace CBS___DBMS
{
    partial class Code
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Code));
            this.btn_log = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_log
            // 
            this.btn_log.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_log.Location = new System.Drawing.Point(581, 375);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(134, 41);
            this.btn_log.TabIndex = 1;
            this.btn_log.Text = "&Let Me Vote";
            this.btn_log.UseVisualStyleBackColor = true;
            this.btn_log.Click += new System.EventHandler(this.btn_log_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(579, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "ENTER CODE";
            // 
            // txt_code
            // 
            this.txt_code.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_code.Location = new System.Drawing.Point(493, 321);
            this.txt_code.Name = "txt_code";
            this.txt_code.PasswordChar = '*';
            this.txt_code.Size = new System.Drawing.Size(309, 36);
            this.txt_code.TabIndex = 0;
            this.txt_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Code
            // 
            this.AcceptButton = this.btn_log;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(932, 551);
            this.ControlBox = false;
            this.Controls.Add(this.btn_log);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_code);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Code";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Code_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_log;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_code;
    }
}