namespace MyCinemaPlanner
{
    partial class User_Seances
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
            this.Seances_grid = new System.Windows.Forms.DataGridView();
            this.DistributionIDcomboBox = new System.Windows.Forms.ComboBox();
            this.DistributionIDlabel = new System.Windows.Forms.Label();
            this.DistributionDetailstextBox = new System.Windows.Forms.TextBox();
            this.Datelabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartTimelabel = new System.Windows.Forms.Label();
            this.EndTimelabel = new System.Windows.Forms.Label();
            this.StartTimedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndTimetextBox = new System.Windows.Forms.TextBox();
            this.Roomlabel = new System.Windows.Forms.Label();
            this.RoomIDcomboBox = new System.Windows.Forms.ComboBox();
            this.TechncicianIDlabel = new System.Windows.Forms.Label();
            this.TechniciancomboBox = new System.Windows.Forms.ComboBox();
            this.Addbutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.Modifybutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exceptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Seances_grid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Seances_grid
            // 
            this.Seances_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Seances_grid.Location = new System.Drawing.Point(32, 23);
            this.Seances_grid.Name = "Seances_grid";
            this.Seances_grid.Size = new System.Drawing.Size(728, 547);
            this.Seances_grid.TabIndex = 0;
            this.Seances_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Seances_grid_CellClick);
            // 
            // DistributionIDcomboBox
            // 
            this.DistributionIDcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DistributionIDcomboBox.FormattingEnabled = true;
            this.DistributionIDcomboBox.Location = new System.Drawing.Point(104, 37);
            this.DistributionIDcomboBox.Name = "DistributionIDcomboBox";
            this.DistributionIDcomboBox.Size = new System.Drawing.Size(121, 21);
            this.DistributionIDcomboBox.TabIndex = 2;
            this.DistributionIDcomboBox.DropDown += new System.EventHandler(this.DistributionIDcomboBox_DropDown);
            this.DistributionIDcomboBox.SelectionChangeCommitted += new System.EventHandler(this.DistributionIDcomboBox_SelectedIndexChanged);
            // 
            // DistributionIDlabel
            // 
            this.DistributionIDlabel.AutoSize = true;
            this.DistributionIDlabel.Location = new System.Drawing.Point(15, 40);
            this.DistributionIDlabel.Name = "DistributionIDlabel";
            this.DistributionIDlabel.Size = new System.Drawing.Size(70, 13);
            this.DistributionIDlabel.TabIndex = 3;
            this.DistributionIDlabel.Text = "DistributionID";
            // 
            // DistributionDetailstextBox
            // 
            this.DistributionDetailstextBox.Location = new System.Drawing.Point(247, 35);
            this.DistributionDetailstextBox.Name = "DistributionDetailstextBox";
            this.DistributionDetailstextBox.Size = new System.Drawing.Size(250, 20);
            this.DistributionDetailstextBox.TabIndex = 4;
            // 
            // Datelabel
            // 
            this.Datelabel.AutoSize = true;
            this.Datelabel.Location = new System.Drawing.Point(792, 71);
            this.Datelabel.Name = "Datelabel";
            this.Datelabel.Size = new System.Drawing.Size(30, 13);
            this.Datelabel.TabIndex = 5;
            this.Datelabel.Text = "Date";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(104, 67);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(217, 20);
            this.dateTimePicker.TabIndex = 7;
            // 
            // StartTimelabel
            // 
            this.StartTimelabel.AutoSize = true;
            this.StartTimelabel.Location = new System.Drawing.Point(15, 108);
            this.StartTimelabel.Name = "StartTimelabel";
            this.StartTimelabel.Size = new System.Drawing.Size(52, 13);
            this.StartTimelabel.TabIndex = 10;
            this.StartTimelabel.Text = "StartTime";
            // 
            // EndTimelabel
            // 
            this.EndTimelabel.AutoSize = true;
            this.EndTimelabel.Location = new System.Drawing.Point(15, 140);
            this.EndTimelabel.Name = "EndTimelabel";
            this.EndTimelabel.Size = new System.Drawing.Size(49, 13);
            this.EndTimelabel.TabIndex = 11;
            this.EndTimelabel.Text = "EndTime";
            // 
            // StartTimedateTimePicker
            // 
            this.StartTimedateTimePicker.Location = new System.Drawing.Point(104, 101);
            this.StartTimedateTimePicker.Name = "StartTimedateTimePicker";
            this.StartTimedateTimePicker.Size = new System.Drawing.Size(217, 20);
            this.StartTimedateTimePicker.TabIndex = 12;
            this.StartTimedateTimePicker.ValueChanged += new System.EventHandler(this.StartTimedateTimePicker_ValueChanged);
            // 
            // EndTimetextBox
            // 
            this.EndTimetextBox.Location = new System.Drawing.Point(104, 137);
            this.EndTimetextBox.Name = "EndTimetextBox";
            this.EndTimetextBox.Size = new System.Drawing.Size(217, 20);
            this.EndTimetextBox.TabIndex = 14;
            // 
            // Roomlabel
            // 
            this.Roomlabel.AutoSize = true;
            this.Roomlabel.Location = new System.Drawing.Point(15, 174);
            this.Roomlabel.Name = "Roomlabel";
            this.Roomlabel.Size = new System.Drawing.Size(46, 13);
            this.Roomlabel.TabIndex = 15;
            this.Roomlabel.Text = "RoomID";
            // 
            // RoomIDcomboBox
            // 
            this.RoomIDcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoomIDcomboBox.FormattingEnabled = true;
            this.RoomIDcomboBox.Location = new System.Drawing.Point(104, 171);
            this.RoomIDcomboBox.Name = "RoomIDcomboBox";
            this.RoomIDcomboBox.Size = new System.Drawing.Size(217, 21);
            this.RoomIDcomboBox.TabIndex = 16;
            this.RoomIDcomboBox.DropDown += new System.EventHandler(this.RoomIDcomboBox_DropDown);
            // 
            // TechncicianIDlabel
            // 
            this.TechncicianIDlabel.AutoSize = true;
            this.TechncicianIDlabel.Location = new System.Drawing.Point(15, 206);
            this.TechncicianIDlabel.Name = "TechncicianIDlabel";
            this.TechncicianIDlabel.Size = new System.Drawing.Size(60, 13);
            this.TechncicianIDlabel.TabIndex = 17;
            this.TechncicianIDlabel.Text = "Technician";
            // 
            // TechniciancomboBox
            // 
            this.TechniciancomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TechniciancomboBox.FormattingEnabled = true;
            this.TechniciancomboBox.Location = new System.Drawing.Point(104, 203);
            this.TechniciancomboBox.Name = "TechniciancomboBox";
            this.TechniciancomboBox.Size = new System.Drawing.Size(217, 21);
            this.TechniciancomboBox.TabIndex = 18;
            this.TechniciancomboBox.DropDown += new System.EventHandler(this.TechniciancomboBox_DropDown);
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(18, 250);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(126, 26);
            this.Addbutton.TabIndex = 20;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.Location = new System.Drawing.Point(195, 250);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(126, 26);
            this.Deletebutton.TabIndex = 21;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // Modifybutton
            // 
            this.Modifybutton.Location = new System.Drawing.Point(371, 250);
            this.Modifybutton.Name = "Modifybutton";
            this.Modifybutton.Size = new System.Drawing.Size(126, 26);
            this.Modifybutton.TabIndex = 22;
            this.Modifybutton.Text = "Modify";
            this.Modifybutton.UseVisualStyleBackColor = true;
            this.Modifybutton.Click += new System.EventHandler(this.Modifybutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DistributionDetailstextBox);
            this.groupBox1.Controls.Add(this.DistributionIDlabel);
            this.groupBox1.Controls.Add(this.DistributionIDcomboBox);
            this.groupBox1.Controls.Add(this.Modifybutton);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.Deletebutton);
            this.groupBox1.Controls.Add(this.StartTimelabel);
            this.groupBox1.Controls.Add(this.Addbutton);
            this.groupBox1.Controls.Add(this.EndTimelabel);
            this.groupBox1.Controls.Add(this.StartTimedateTimePicker);
            this.groupBox1.Controls.Add(this.TechniciancomboBox);
            this.groupBox1.Controls.Add(this.EndTimetextBox);
            this.groupBox1.Controls.Add(this.TechncicianIDlabel);
            this.groupBox1.Controls.Add(this.Roomlabel);
            this.groupBox1.Controls.Add(this.RoomIDcomboBox);
            this.groupBox1.Location = new System.Drawing.Point(777, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 297);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Delete/Modify Seances";
            // 
            // exceptionLabel
            // 
            this.exceptionLabel.AutoSize = true;
            this.exceptionLabel.Location = new System.Drawing.Point(781, 331);
            this.exceptionLabel.Name = "exceptionLabel";
            this.exceptionLabel.Size = new System.Drawing.Size(60, 13);
            this.exceptionLabel.TabIndex = 24;
            this.exceptionLabel.Text = "Technician";
            // 
            // User_Seances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.exceptionLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Datelabel);
            this.Controls.Add(this.Seances_grid);
            this.Name = "User_Seances";
            this.Size = new System.Drawing.Size(1313, 670);
            ((System.ComponentModel.ISupportInitialize)(this.Seances_grid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Seances_grid;
        private System.Windows.Forms.ComboBox DistributionIDcomboBox;
        private System.Windows.Forms.Label DistributionIDlabel;
        private System.Windows.Forms.TextBox DistributionDetailstextBox;
        private System.Windows.Forms.Label Datelabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label StartTimelabel;
        private System.Windows.Forms.Label EndTimelabel;
        private System.Windows.Forms.DateTimePicker StartTimedateTimePicker;
        private System.Windows.Forms.TextBox EndTimetextBox;
        private System.Windows.Forms.Label Roomlabel;
        private System.Windows.Forms.ComboBox RoomIDcomboBox;
        private System.Windows.Forms.Label TechncicianIDlabel;
        private System.Windows.Forms.ComboBox TechniciancomboBox;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button Modifybutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label exceptionLabel;
    }
}
