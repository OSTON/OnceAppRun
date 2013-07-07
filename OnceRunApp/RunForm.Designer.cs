namespace OnceRunApp
{
    partial class RunForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;



        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RunForm));
            this.tabAppGroup = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAddAppGroup = new System.Windows.Forms.Button();
            this.pnlAppTab = new System.Windows.Forms.Panel();
            this.tsOperation = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tabAppGroup.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlAppTab.SuspendLayout();
            this.tsOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAppGroup
            // 
            this.tabAppGroup.Controls.Add(this.tabPage1);
            this.tabAppGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAppGroup.Location = new System.Drawing.Point(0, 0);
            this.tabAppGroup.Name = "tabAppGroup";
            this.tabAppGroup.SelectedIndex = 0;
            this.tabAppGroup.Size = new System.Drawing.Size(664, 333);
            this.tabAppGroup.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAddAppGroup);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(656, 306);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "OnceRunApp";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAddAppGroup
            // 
            this.btnAddAppGroup.Location = new System.Drawing.Point(8, 33);
            this.btnAddAppGroup.Name = "btnAddAppGroup";
            this.btnAddAppGroup.Size = new System.Drawing.Size(76, 23);
            this.btnAddAppGroup.TabIndex = 0;
            this.btnAddAppGroup.Text = "Add Group";
            this.btnAddAppGroup.UseVisualStyleBackColor = true;
            this.btnAddAppGroup.Click += new System.EventHandler(this.btnAddAppGroup_Click);
            // 
            // pnlAppTab
            // 
            this.pnlAppTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAppTab.Controls.Add(this.tabAppGroup);
            this.pnlAppTab.Location = new System.Drawing.Point(0, 28);
            this.pnlAppTab.Name = "pnlAppTab";
            this.pnlAppTab.Size = new System.Drawing.Size(664, 333);
            this.pnlAppTab.TabIndex = 2;
            // 
            // tsOperation
            // 
            this.tsOperation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.tsOperation.Location = new System.Drawing.Point(0, 0);
            this.tsOperation.Name = "tsOperation";
            this.tsOperation.Size = new System.Drawing.Size(664, 25);
            this.tsOperation.TabIndex = 3;
            this.tsOperation.Text = "toolStrip";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(64, 22);
            this.toolStripButton1.Text = "Group";
            // 
            // RunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 361);
            this.Controls.Add(this.tsOperation);
            this.Controls.Add(this.pnlAppTab);
            this.Name = "RunForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OnceRunApp Settings";
            this.Load += new System.EventHandler(this.RunForm_Load);
            this.tabAppGroup.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pnlAppTab.ResumeLayout(false);
            this.tsOperation.ResumeLayout(false);
            this.tsOperation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabAppGroup;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pnlAppTab;
        private System.Windows.Forms.Button btnAddAppGroup;
        private System.Windows.Forms.ToolStrip tsOperation;
        private System.Windows.Forms.ToolStripButton toolStripButton1;


    }
}

