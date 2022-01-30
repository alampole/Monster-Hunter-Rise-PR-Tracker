
namespace Monster_Hunter_Rise___PR_Tracker
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FilterMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.QuestResultTable = new System.Windows.Forms.DataGridView();
            this.newButton = new System.Windows.Forms.Button();
            this.QuestNameLabel = new System.Windows.Forms.Label();
            this.CreatureNameLabel = new System.Windows.Forms.Label();
            this.StarLabel = new System.Windows.Forms.Label();
            this.InfoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuestResultTable)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.FilterMenuItem,
            this.InfoMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenMenuItem,
            this.SaveMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileMenuItem.Text = "File";
            // 
            // OpenMenuItem
            // 
            this.OpenMenuItem.Name = "OpenMenuItem";
            this.OpenMenuItem.Size = new System.Drawing.Size(138, 22);
            this.OpenMenuItem.Text = "Open";
            // 
            // SaveMenuItem
            // 
            this.SaveMenuItem.Name = "SaveMenuItem";
            this.SaveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveMenuItem.Size = new System.Drawing.Size(138, 22);
            this.SaveMenuItem.Text = "Save";
            this.SaveMenuItem.Click += new System.EventHandler(this.SaveForm);
            // 
            // FilterMenuItem
            // 
            this.FilterMenuItem.Name = "FilterMenuItem";
            this.FilterMenuItem.Size = new System.Drawing.Size(50, 20);
            this.FilterMenuItem.Text = "Filters";
            this.FilterMenuItem.Click += new System.EventHandler(this.FilterClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 426);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.QuestResultTable);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "All Hunts";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // QuestResultTable
            // 
            this.QuestResultTable.AllowUserToAddRows = false;
            this.QuestResultTable.AllowUserToDeleteRows = false;
            this.QuestResultTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QuestResultTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuestResultTable.Location = new System.Drawing.Point(3, 3);
            this.QuestResultTable.Name = "QuestResultTable";
            this.QuestResultTable.ReadOnly = true;
            this.QuestResultTable.RowTemplate.Height = 25;
            this.QuestResultTable.Size = new System.Drawing.Size(786, 392);
            this.QuestResultTable.TabIndex = 0;
            this.QuestResultTable.MouseClick += new System.Windows.Forms.MouseEventHandler(this.QuestResultTable_MouseClick);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(706, 15);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 23);
            this.newButton.TabIndex = 0;
            this.newButton.Text = "New Run";
            this.newButton.UseVisualStyleBackColor = true;
            // 
            // QuestNameLabel
            // 
            this.QuestNameLabel.AutoSize = true;
            this.QuestNameLabel.Location = new System.Drawing.Point(6, -3);
            this.QuestNameLabel.Name = "QuestNameLabel";
            this.QuestNameLabel.Size = new System.Drawing.Size(38, 15);
            this.QuestNameLabel.TabIndex = 1;
            // 
            // CreatureNameLabel
            // 
            this.CreatureNameLabel.AutoSize = true;
            this.CreatureNameLabel.Location = new System.Drawing.Point(6, 15);
            this.CreatureNameLabel.Name = "CreatureNameLabel";
            this.CreatureNameLabel.Size = new System.Drawing.Size(38, 15);
            this.CreatureNameLabel.TabIndex = 2;
            // 
            // StarLabel
            // 
            this.StarLabel.AutoSize = true;
            this.StarLabel.Location = new System.Drawing.Point(6, 32);
            this.StarLabel.Name = "StarLabel";
            this.StarLabel.Size = new System.Drawing.Size(38, 15);
            this.StarLabel.TabIndex = 3;
            // 
            // InfoMenuItem
            // 
            this.InfoMenuItem.Name = "InfoMenuItem";
            this.InfoMenuItem.Size = new System.Drawing.Size(40, 20);
            this.InfoMenuItem.Text = "Info";
            this.InfoMenuItem.Click += new System.EventHandler(this.InfoClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Monster Hunter Rise: PR Tracker";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QuestResultTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FilterMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView QuestResultTable;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Label QuestNameLabel;
        private System.Windows.Forms.Label CreatureNameLabel;
        private System.Windows.Forms.Label StarLabel;
        private System.Windows.Forms.ToolStripMenuItem InfoMenuItem;
    }
}