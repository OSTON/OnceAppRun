namespace OnceRunApp
{
    partial class GroupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupForm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.lblGroupDescription = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pbTitle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::OnceRunApp.Properties.Resources.cancel;
            this.btnCancel.Location = new System.Drawing.Point(228, 163);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(32, 32);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Image = global::OnceRunApp.Properties.Resources.confirm;
            this.btnOK.Location = new System.Drawing.Point(150, 163);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(32, 32);
            this.btnOK.TabIndex = 0;
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(14, 35);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(378, 21);
            this.txtGroupName.TabIndex = 2;
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Location = new System.Drawing.Point(12, 20);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(65, 12);
            this.lblGroupName.TabIndex = 3;
            this.lblGroupName.Text = "Group Name";
            // 
            // lblGroupDescription
            // 
            this.lblGroupDescription.AutoSize = true;
            this.lblGroupDescription.Location = new System.Drawing.Point(12, 74);
            this.lblGroupDescription.Name = "lblGroupDescription";
            this.lblGroupDescription.Size = new System.Drawing.Size(71, 12);
            this.lblGroupDescription.TabIndex = 4;
            this.lblGroupDescription.Text = "Description";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 89);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(378, 60);
            this.textBox1.TabIndex = 5;
            // 
            // pbTitle
            // 
            this.pbTitle.Image = global::OnceRunApp.Properties.Resources.tab_add;
            this.pbTitle.InitialImage = null;
            this.pbTitle.Location = new System.Drawing.Point(14, 163);
            this.pbTitle.Name = "pbTitle";
            this.pbTitle.Size = new System.Drawing.Size(32, 32);
            this.pbTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbTitle.TabIndex = 6;
            this.pbTitle.TabStop = false;
            // 
            // GroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(408, 202);
            this.Controls.Add(this.pbTitle);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblGroupDescription);
            this.Controls.Add(this.lblGroupName);
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GroupForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GroupForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.Label lblGroupDescription;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pbTitle;
    }
}