namespace MyCinemaPlanner
{
    partial class Manager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moviesAnDistributionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.dailyViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeVersionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeesToolStripMenuItem,
            this.moviesAnDistributionsToolStripMenuItem,
            this.dailyViewToolStripMenuItem,
            this.employeeVersionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1146, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.employeesToolStripMenuItem.Text = "Employees";
            this.employeesToolStripMenuItem.Click += new System.EventHandler(this.employeesToolStripMenuItem_Click);
            // 
            // moviesAnDistributionsToolStripMenuItem
            // 
            this.moviesAnDistributionsToolStripMenuItem.AutoSize = false;
            this.moviesAnDistributionsToolStripMenuItem.Name = "moviesAnDistributionsToolStripMenuItem";
            this.moviesAnDistributionsToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.moviesAnDistributionsToolStripMenuItem.Text = "Movies";
            this.moviesAnDistributionsToolStripMenuItem.Click += new System.EventHandler(this.moviesAnDistributionsToolStripMenuItem_Click);
            // 
            // panel
            // 
            this.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel.Location = new System.Drawing.Point(0, 27);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(449, 164);
            this.panel.TabIndex = 1;
            // 
            // dailyViewToolStripMenuItem
            // 
            this.dailyViewToolStripMenuItem.Name = "dailyViewToolStripMenuItem";
            this.dailyViewToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.dailyViewToolStripMenuItem.Text = "Daily View";
            this.dailyViewToolStripMenuItem.Click += new System.EventHandler(this.dailyViewToolStripMenuItem_Click);
            // 
            // employeeVersionToolStripMenuItem
            // 
            this.employeeVersionToolStripMenuItem.Name = "employeeVersionToolStripMenuItem";
            this.employeeVersionToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.employeeVersionToolStripMenuItem.Text = "Employee Version";
            this.employeeVersionToolStripMenuItem.Click += new System.EventHandler(this.employeeVersionToolStripMenuItem_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1146, 691);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moviesAnDistributionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeVersionToolStripMenuItem;
    }
}