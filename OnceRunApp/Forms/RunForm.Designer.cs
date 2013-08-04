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
            this.pnlAppTab = new System.Windows.Forms.Panel();
            this.tabApp = new System.Windows.Forms.TabControl();
            this.tsOperation = new System.Windows.Forms.ToolStrip();
            this.btnRunApps = new System.Windows.Forms.ToolStripButton();
            this.btnShortcut = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddGroup = new System.Windows.Forms.ToolStripButton();
            this.btnEditGroup = new System.Windows.Forms.ToolStripButton();
            this.btnRemoveGroup = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAbout = new System.Windows.Forms.ToolStripButton();
            this.pnlAppTab.SuspendLayout();
            this.tsOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAppTab
            // 
            this.pnlAppTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAppTab.Controls.Add(this.tabApp);
            this.pnlAppTab.Location = new System.Drawing.Point(0, 28);
            this.pnlAppTab.Name = "pnlAppTab";
            this.pnlAppTab.Size = new System.Drawing.Size(664, 383);
            this.pnlAppTab.TabIndex = 2;
            // 
            // tabApp
            // 
            this.tabApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabApp.Location = new System.Drawing.Point(0, 0);
            this.tabApp.Name = "tabApp";
            this.tabApp.SelectedIndex = 0;
            this.tabApp.ShowToolTips = true;
            this.tabApp.Size = new System.Drawing.Size(664, 383);
            this.tabApp.TabIndex = 0;
            // 
            // tsOperation
            // 
            this.tsOperation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRunApps,
            this.btnShortcut,
            this.toolStripSeparator1,
            this.btnAddGroup,
            this.btnEditGroup,
            this.btnRemoveGroup,
            this.toolStripSeparator2,
            this.btnAbout});
            this.tsOperation.Location = new System.Drawing.Point(0, 0);
            this.tsOperation.Name = "tsOperation";
            this.tsOperation.Size = new System.Drawing.Size(664, 25);
            this.tsOperation.TabIndex = 3;
            this.tsOperation.Text = "toolStrip";
            // 
            // btnRunApps
            // 
            this.btnRunApps.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRunApps.Image = global::OnceRunApp.Properties.Resources.run;
            this.btnRunApps.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRunApps.Name = "btnRunApps";
            this.btnRunApps.Size = new System.Drawing.Size(23, 22);
            this.btnRunApps.Text = "Run Group Apps";
            // 
            // btnShortcut
            // 
            this.btnShortcut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnShortcut.Image = global::OnceRunApp.Properties.Resources.shortcut;
            this.btnShortcut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShortcut.Name = "btnShortcut";
            this.btnShortcut.Size = new System.Drawing.Size(23, 22);
            this.btnShortcut.Text = "Create Group Shortcut";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddGroup.Image = global::OnceRunApp.Properties.Resources.tab_add;
            this.btnAddGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(23, 22);
            this.btnAddGroup.Text = "Add Group";
            // 
            // btnEditGroup
            // 
            this.btnEditGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditGroup.Image = global::OnceRunApp.Properties.Resources.tab_edit;
            this.btnEditGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditGroup.Name = "btnEditGroup";
            this.btnEditGroup.Size = new System.Drawing.Size(23, 22);
            this.btnEditGroup.Text = "Edit Group";
            // 
            // btnRemoveGroup
            // 
            this.btnRemoveGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRemoveGroup.Image = global::OnceRunApp.Properties.Resources.tab_remove;
            this.btnRemoveGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemoveGroup.Name = "btnRemoveGroup";
            this.btnRemoveGroup.Size = new System.Drawing.Size(23, 22);
            this.btnRemoveGroup.Text = "Remove Group";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.ClientSize = new System.Drawing.Size(664, 411);
            this.Controls.Add(this.tsOperation);
            this.Controls.Add(this.pnlAppTab);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RunForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OnceRunApp Settings";
            this.pnlAppTab.ResumeLayout(false);
            this.tsOperation.ResumeLayout(false);
            this.tsOperation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAppTab;
        private System.Windows.Forms.ToolStrip tsOperation;
        private System.Windows.Forms.ToolStripButton btnAddGroup;
        private System.Windows.Forms.ToolStripButton btnEditGroup;
        private System.Windows.Forms.ToolStripButton btnRemoveGroup;
        private System.Windows.Forms.ToolStripButton btnAbout;
        private System.Windows.Forms.ToolStripButton btnRunApps;
        private System.Windows.Forms.ToolStripButton btnShortcut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TabControl tabApp;


    }
}

