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
            this.tabAppGroup = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlAppTab = new System.Windows.Forms.Panel();
            this.tsOperation = new System.Windows.Forms.ToolStrip();
            this.btnRun = new System.Windows.Forms.ToolStripButton();
            this.btnAddGroup = new System.Windows.Forms.ToolStripButton();
            this.btnEditGroup = new System.Windows.Forms.ToolStripButton();
            this.btnRemoveGroup = new System.Windows.Forms.ToolStripButton();
            this.btnAbout = new System.Windows.Forms.ToolStripButton();
            this.tabAppGroup.SuspendLayout();
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
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(656, 307);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "OnceRunApp";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.btnRun,
            this.btnAddGroup,
            this.btnEditGroup,
            this.btnRemoveGroup,
            this.btnAbout});
            this.tsOperation.Location = new System.Drawing.Point(0, 0);
            this.tsOperation.Name = "tsOperation";
            this.tsOperation.Size = new System.Drawing.Size(664, 25);
            this.tsOperation.TabIndex = 3;
            this.tsOperation.Text = "toolStrip";
            // 
            // btnRun
            // 
            this.btnRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRun.Image = global::OnceRunApp.Properties.Resources.run;
            this.btnRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(23, 22);
            this.btnRun.Text = "Run Apps";
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddGroup.Image = global::OnceRunApp.Properties.Resources.tab_add;
            this.btnAddGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(23, 22);
            this.btnAddGroup.Text = "Add Group";
            this.btnAddGroup.Click += new System.EventHandler(this.BtnAddGroup_Click);
            // 
            // btnEditGroup
            // 
            this.btnEditGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditGroup.Image = global::OnceRunApp.Properties.Resources.tab_edit;
            this.btnEditGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditGroup.Name = "btnEditGroup";
            this.btnEditGroup.Size = new System.Drawing.Size(23, 22);
            this.btnEditGroup.Text = "Edit Group";
            this.btnEditGroup.Click += new System.EventHandler(this.BtnEditGroup_Click);
            // 
            // btnRemoveGroup
            // 
            this.btnRemoveGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRemoveGroup.Image = global::OnceRunApp.Properties.Resources.tab_remove;
            this.btnRemoveGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemoveGroup.Name = "btnRemoveGroup";
            this.btnRemoveGroup.Size = new System.Drawing.Size(23, 22);
            this.btnRemoveGroup.Text = "Remove Group";
            this.btnRemoveGroup.Click += new System.EventHandler(this.BtnRemoveGroup_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAbout.Image = global::OnceRunApp.Properties.Resources.about;
            this.btnAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(23, 22);
            this.btnAbout.Text = "About";
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
        private System.Windows.Forms.ToolStrip tsOperation;
        private System.Windows.Forms.ToolStripButton btnAddGroup;
        private System.Windows.Forms.ToolStripButton btnEditGroup;
        private System.Windows.Forms.ToolStripButton btnRemoveGroup;
        private System.Windows.Forms.ToolStripButton btnAbout;
        private System.Windows.Forms.ToolStripButton btnRun;


    }
}

