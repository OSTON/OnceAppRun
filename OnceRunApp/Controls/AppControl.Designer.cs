namespace OnceRunApp.Controls
{
    partial class AppControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtExePath = new System.Windows.Forms.TextBox();
            this.btnChooseExe = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlOperation = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pnlOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtExePath
            // 
            this.txtExePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExePath.Location = new System.Drawing.Point(117, 10);
            this.txtExePath.Name = "txtExePath";
            this.txtExePath.ReadOnly = true;
            this.txtExePath.Size = new System.Drawing.Size(252, 21);
            this.txtExePath.TabIndex = 0;
            // 
            // btnChooseExe
            // 
            this.btnChooseExe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChooseExe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseExe.Location = new System.Drawing.Point(375, 9);
            this.btnChooseExe.Name = "btnChooseExe";
            this.btnChooseExe.Size = new System.Drawing.Size(75, 23);
            this.btnChooseExe.TabIndex = 1;
            this.btnChooseExe.Text = "Browse...";
            this.btnChooseExe.UseVisualStyleBackColor = true;
            this.btnChooseExe.Click += new System.EventHandler(this.BtnChooseExe_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(23, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // pnlOperation
            // 
            this.pnlOperation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOperation.AutoSize = true;
            this.pnlOperation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlOperation.BackColor = System.Drawing.SystemColors.Control;
            this.pnlOperation.Controls.Add(this.btnAdd);
            this.pnlOperation.Controls.Add(this.btnRemove);
            this.pnlOperation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlOperation.Location = new System.Drawing.Point(460, 9);
            this.pnlOperation.Name = "pnlOperation";
            this.pnlOperation.Size = new System.Drawing.Size(46, 23);
            this.pnlOperation.TabIndex = 3;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(23, 0);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(23, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "-";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(3, 10);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(105, 21);
            this.txtName.TabIndex = 4;
            // 
            // AppControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.pnlOperation);
            this.Controls.Add(this.btnChooseExe);
            this.Controls.Add(this.txtExePath);
            this.Name = "AppControl";
            this.Size = new System.Drawing.Size(512, 42);
            this.pnlOperation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtExePath;
        private System.Windows.Forms.Button btnChooseExe;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.FlowLayoutPanel pnlOperation;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtName;

    }
}
