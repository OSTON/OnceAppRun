namespace OnceRunApp
{
    partial class AboutBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblApplication = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblContactMe = new System.Windows.Forms.Label();
            this.lblHomePage = new System.Windows.Forms.Label();
            this.linkHomePage = new System.Windows.Forms.LinkLabel();
            this.linkEmail = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCopyRight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::OnceRunApp.Properties.Resources.App;
            this.pbLogo.Location = new System.Drawing.Point(36, 20);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(32, 32);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // lblApplication
            // 
            this.lblApplication.AutoSize = true;
            this.lblApplication.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblApplication.Location = new System.Drawing.Point(87, 31);
            this.lblApplication.Name = "lblApplication";
            this.lblApplication.Size = new System.Drawing.Size(124, 12);
            this.lblApplication.TabIndex = 1;
            this.lblApplication.Text = "OnceRunApp V1.0.0";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(36, 70);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(71, 12);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // lblContactMe
            // 
            this.lblContactMe.AutoSize = true;
            this.lblContactMe.Location = new System.Drawing.Point(36, 99);
            this.lblContactMe.Name = "lblContactMe";
            this.lblContactMe.Size = new System.Drawing.Size(71, 12);
            this.lblContactMe.TabIndex = 3;
            this.lblContactMe.Text = "Contact Me:";
            // 
            // lblHomePage
            // 
            this.lblHomePage.AutoSize = true;
            this.lblHomePage.Location = new System.Drawing.Point(36, 122);
            this.lblHomePage.Name = "lblHomePage";
            this.lblHomePage.Size = new System.Drawing.Size(83, 12);
            this.lblHomePage.TabIndex = 4;
            this.lblHomePage.Text = "Project Page:";
            // 
            // linkHomePage
            // 
            this.linkHomePage.AutoSize = true;
            this.linkHomePage.Location = new System.Drawing.Point(127, 122);
            this.linkHomePage.Name = "linkHomePage";
            this.linkHomePage.Size = new System.Drawing.Size(215, 12);
            this.linkHomePage.TabIndex = 5;
            this.linkHomePage.TabStop = true;
            this.linkHomePage.Text = "https://github.com/OSTON/OnceAppRun";
            this.linkHomePage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkHomePage_LinkClicked);
            // 
            // linkEmail
            // 
            this.linkEmail.AutoSize = true;
            this.linkEmail.Location = new System.Drawing.Point(127, 99);
            this.linkEmail.Name = "linkEmail";
            this.linkEmail.Size = new System.Drawing.Size(131, 12);
            this.linkEmail.TabIndex = 6;
            this.linkEmail.TabStop = true;
            this.linkEmail.Text = "OSTONBETTER@GMAIL.COM";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = global::OnceRunApp.Properties.Resources.cancel;
            this.btnClose.Location = new System.Drawing.Point(166, 173);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.TabIndex = 7;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.AutoSize = true;
            this.lblCopyRight.Location = new System.Drawing.Point(36, 150);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(65, 12);
            this.lblCopyRight.TabIndex = 8;
            this.lblCopyRight.Text = "Copy Right";
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(374, 214);
            this.Controls.Add(this.lblCopyRight);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.linkEmail);
            this.Controls.Add(this.linkHomePage);
            this.Controls.Add(this.lblHomePage);
            this.Controls.Add(this.lblContactMe);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblApplication);
            this.Controls.Add(this.pbLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About OnceRunApp";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblApplication;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblContactMe;
        private System.Windows.Forms.Label lblHomePage;
        private System.Windows.Forms.LinkLabel linkHomePage;
        private System.Windows.Forms.LinkLabel linkEmail;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCopyRight;


    }
}
