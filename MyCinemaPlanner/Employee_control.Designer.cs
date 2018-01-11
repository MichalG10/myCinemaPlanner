namespace MyCinemaPlanner
{
    partial class Employee_control
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
            this.Employees_grid = new System.Windows.Forms.DataGridView();
            this.Employees_label = new System.Windows.Forms.Label();
            this.Staff_grid = new System.Windows.Forms.DataGridView();
            this.Technicians_grid = new System.Windows.Forms.DataGridView();
            this.Staff_label = new System.Windows.Forms.Label();
            this.Technicians_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Position_label = new System.Windows.Forms.Label();
            this.Country_label = new System.Windows.Forms.Label();
            this.CountrytextBox = new System.Windows.Forms.TextBox();
            this.City_label = new System.Windows.Forms.Label();
            this.Adress_label = new System.Windows.Forms.Label();
            this.DateOfBirth_label = new System.Windows.Forms.Label();
            this.Pesel_label = new System.Windows.Forms.Label();
            this.LastName_label = new System.Windows.Forms.Label();
            this.FirstName_label = new System.Windows.Forms.Label();
            this.FirstNametextBox = new System.Windows.Forms.TextBox();
            this.CitytextBox = new System.Windows.Forms.TextBox();
            this.DateOFBirthtextBox = new System.Windows.Forms.TextBox();
            this.AdresstextBox = new System.Windows.Forms.TextBox();
            this.PeseltextBox = new System.Windows.Forms.TextBox();
            this.LastNametextBox = new System.Windows.Forms.TextBox();
            this.PositioncomboBox = new System.Windows.Forms.ComboBox();
            this.Add_button = new System.Windows.Forms.Button();
            this.Modify_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.exceptionLabel = new System.Windows.Forms.Label();
            this.PositiongroupBox = new System.Windows.Forms.GroupBox();
            this.Experience3DcomboBox = new System.Windows.Forms.ComboBox();
            this.SanepidcomboBox = new System.Windows.Forms.ComboBox();
            this.TScomboBox = new System.Windows.Forms.ComboBox();
            this.TSlabel = new System.Windows.Forms.Label();
            this.Paymentlabel = new System.Windows.Forms.Label();
            this.PaymenttextBox = new System.Windows.Forms.TextBox();
            this.Experience3Dlabel = new System.Windows.Forms.Label();
            this.Sanepidlabel = new System.Windows.Forms.Label();
            this.WorkedHourslabel = new System.Windows.Forms.Label();
            this.perHourBruttolabel = new System.Windows.Forms.Label();
            this.perHourNettolabel = new System.Windows.Forms.Label();
            this.perHourNettotextBox = new System.Windows.Forms.TextBox();
            this.WorkedHourstextBox = new System.Windows.Forms.TextBox();
            this.perHourBruttotextBox = new System.Windows.Forms.TextBox();
            this.TSbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Employees_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Staff_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Technicians_grid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.PositiongroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Employees_grid
            // 
            this.Employees_grid.AllowUserToAddRows = false;
            this.Employees_grid.AllowUserToDeleteRows = false;
            this.Employees_grid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.Employees_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Employees_grid.Location = new System.Drawing.Point(40, 40);
            this.Employees_grid.Name = "Employees_grid";
            this.Employees_grid.ReadOnly = true;
            this.Employees_grid.Size = new System.Drawing.Size(716, 191);
            this.Employees_grid.TabIndex = 0;
            this.Employees_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Employees_grid_CellClick);
            // 
            // Employees_label
            // 
            this.Employees_label.AutoSize = true;
            this.Employees_label.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Employees_label.Location = new System.Drawing.Point(34, 2);
            this.Employees_label.Name = "Employees_label";
            this.Employees_label.Size = new System.Drawing.Size(125, 35);
            this.Employees_label.TabIndex = 1;
            this.Employees_label.Text = "Employees";
            // 
            // Staff_grid
            // 
            this.Staff_grid.AllowUserToAddRows = false;
            this.Staff_grid.AllowUserToDeleteRows = false;
            this.Staff_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Staff_grid.Location = new System.Drawing.Point(40, 313);
            this.Staff_grid.Name = "Staff_grid";
            this.Staff_grid.ReadOnly = true;
            this.Staff_grid.Size = new System.Drawing.Size(532, 175);
            this.Staff_grid.TabIndex = 2;
            this.Staff_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Staff_grid_CellClick);
            // 
            // Technicians_grid
            // 
            this.Technicians_grid.AllowUserToAddRows = false;
            this.Technicians_grid.AllowUserToDeleteRows = false;
            this.Technicians_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Technicians_grid.Location = new System.Drawing.Point(702, 313);
            this.Technicians_grid.Name = "Technicians_grid";
            this.Technicians_grid.ReadOnly = true;
            this.Technicians_grid.Size = new System.Drawing.Size(532, 175);
            this.Technicians_grid.TabIndex = 3;
            this.Technicians_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Technicians_grid_CellClick);
            // 
            // Staff_label
            // 
            this.Staff_label.AutoSize = true;
            this.Staff_label.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Staff_label.Location = new System.Drawing.Point(34, 261);
            this.Staff_label.Name = "Staff_label";
            this.Staff_label.Size = new System.Drawing.Size(64, 35);
            this.Staff_label.TabIndex = 4;
            this.Staff_label.Text = "Staff";
            // 
            // Technicians_label
            // 
            this.Technicians_label.AutoSize = true;
            this.Technicians_label.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Technicians_label.Location = new System.Drawing.Point(696, 261);
            this.Technicians_label.Name = "Technicians_label";
            this.Technicians_label.Size = new System.Drawing.Size(133, 35);
            this.Technicians_label.TabIndex = 5;
            this.Technicians_label.Text = "Technicians";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Position_label);
            this.groupBox1.Controls.Add(this.Country_label);
            this.groupBox1.Controls.Add(this.CountrytextBox);
            this.groupBox1.Controls.Add(this.City_label);
            this.groupBox1.Controls.Add(this.Modify_button);
            this.groupBox1.Controls.Add(this.Delete_button);
            this.groupBox1.Controls.Add(this.Add_button);
            this.groupBox1.Controls.Add(this.Adress_label);
            this.groupBox1.Controls.Add(this.DateOfBirth_label);
            this.groupBox1.Controls.Add(this.Pesel_label);
            this.groupBox1.Controls.Add(this.LastName_label);
            this.groupBox1.Controls.Add(this.FirstName_label);
            this.groupBox1.Controls.Add(this.FirstNametextBox);
            this.groupBox1.Controls.Add(this.CitytextBox);
            this.groupBox1.Controls.Add(this.DateOFBirthtextBox);
            this.groupBox1.Controls.Add(this.AdresstextBox);
            this.groupBox1.Controls.Add(this.PeseltextBox);
            this.groupBox1.Controls.Add(this.LastNametextBox);
            this.groupBox1.Controls.Add(this.PositioncomboBox);
            this.groupBox1.Location = new System.Drawing.Point(762, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 218);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Delete Employee";
            // 
            // Position_label
            // 
            this.Position_label.AutoSize = true;
            this.Position_label.Location = new System.Drawing.Point(312, 137);
            this.Position_label.Name = "Position_label";
            this.Position_label.Size = new System.Drawing.Size(44, 13);
            this.Position_label.TabIndex = 15;
            this.Position_label.Text = "Position";
            // 
            // Country_label
            // 
            this.Country_label.AutoSize = true;
            this.Country_label.Location = new System.Drawing.Point(310, 101);
            this.Country_label.Name = "Country_label";
            this.Country_label.Size = new System.Drawing.Size(43, 13);
            this.Country_label.TabIndex = 14;
            this.Country_label.Text = "Country";
            // 
            // CountrytextBox
            // 
            this.CountrytextBox.Location = new System.Drawing.Point(372, 98);
            this.CountrytextBox.Name = "CountrytextBox";
            this.CountrytextBox.Size = new System.Drawing.Size(121, 20);
            this.CountrytextBox.TabIndex = 13;
            // 
            // City_label
            // 
            this.City_label.AutoSize = true;
            this.City_label.Location = new System.Drawing.Point(310, 62);
            this.City_label.Name = "City_label";
            this.City_label.Size = new System.Drawing.Size(24, 13);
            this.City_label.TabIndex = 12;
            this.City_label.Text = "City";
            // 
            // Adress_label
            // 
            this.Adress_label.AutoSize = true;
            this.Adress_label.Location = new System.Drawing.Point(310, 27);
            this.Adress_label.Name = "Adress_label";
            this.Adress_label.Size = new System.Drawing.Size(39, 13);
            this.Adress_label.TabIndex = 11;
            this.Adress_label.Text = "Adress";
            // 
            // DateOfBirth_label
            // 
            this.DateOfBirth_label.AutoSize = true;
            this.DateOfBirth_label.Location = new System.Drawing.Point(55, 134);
            this.DateOfBirth_label.Name = "DateOfBirth_label";
            this.DateOfBirth_label.Size = new System.Drawing.Size(66, 13);
            this.DateOfBirth_label.TabIndex = 10;
            this.DateOfBirth_label.Text = "Date of Birth";
            // 
            // Pesel_label
            // 
            this.Pesel_label.AutoSize = true;
            this.Pesel_label.Location = new System.Drawing.Point(55, 97);
            this.Pesel_label.Name = "Pesel_label";
            this.Pesel_label.Size = new System.Drawing.Size(33, 13);
            this.Pesel_label.TabIndex = 9;
            this.Pesel_label.Text = "Pesel";
            // 
            // LastName_label
            // 
            this.LastName_label.AutoSize = true;
            this.LastName_label.Location = new System.Drawing.Point(55, 58);
            this.LastName_label.Name = "LastName_label";
            this.LastName_label.Size = new System.Drawing.Size(58, 13);
            this.LastName_label.TabIndex = 8;
            this.LastName_label.Text = "Last Name";
            // 
            // FirstName_label
            // 
            this.FirstName_label.AutoSize = true;
            this.FirstName_label.Location = new System.Drawing.Point(55, 23);
            this.FirstName_label.Name = "FirstName_label";
            this.FirstName_label.Size = new System.Drawing.Size(57, 13);
            this.FirstName_label.TabIndex = 7;
            this.FirstName_label.Text = "First Name";
            // 
            // FirstNametextBox
            // 
            this.FirstNametextBox.Location = new System.Drawing.Point(146, 20);
            this.FirstNametextBox.Name = "FirstNametextBox";
            this.FirstNametextBox.Size = new System.Drawing.Size(121, 20);
            this.FirstNametextBox.TabIndex = 6;
            // 
            // CitytextBox
            // 
            this.CitytextBox.Location = new System.Drawing.Point(372, 62);
            this.CitytextBox.Name = "CitytextBox";
            this.CitytextBox.Size = new System.Drawing.Size(121, 20);
            this.CitytextBox.TabIndex = 5;
            // 
            // DateOFBirthtextBox
            // 
            this.DateOFBirthtextBox.Location = new System.Drawing.Point(146, 131);
            this.DateOFBirthtextBox.Name = "DateOFBirthtextBox";
            this.DateOFBirthtextBox.Size = new System.Drawing.Size(121, 20);
            this.DateOFBirthtextBox.TabIndex = 4;
            // 
            // AdresstextBox
            // 
            this.AdresstextBox.Location = new System.Drawing.Point(372, 20);
            this.AdresstextBox.Name = "AdresstextBox";
            this.AdresstextBox.Size = new System.Drawing.Size(121, 20);
            this.AdresstextBox.TabIndex = 3;
            // 
            // PeseltextBox
            // 
            this.PeseltextBox.Location = new System.Drawing.Point(146, 94);
            this.PeseltextBox.Name = "PeseltextBox";
            this.PeseltextBox.Size = new System.Drawing.Size(121, 20);
            this.PeseltextBox.TabIndex = 2;
            // 
            // LastNametextBox
            // 
            this.LastNametextBox.Location = new System.Drawing.Point(146, 55);
            this.LastNametextBox.Name = "LastNametextBox";
            this.LastNametextBox.Size = new System.Drawing.Size(121, 20);
            this.LastNametextBox.TabIndex = 1;
            // 
            // PositioncomboBox
            // 
            this.PositioncomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PositioncomboBox.FormattingEnabled = true;
            this.PositioncomboBox.Items.AddRange(new object[] {
            "Staff",
            "Technician"});
            this.PositioncomboBox.Location = new System.Drawing.Point(372, 134);
            this.PositioncomboBox.Name = "PositioncomboBox";
            this.PositioncomboBox.Size = new System.Drawing.Size(121, 21);
            this.PositioncomboBox.TabIndex = 0;
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(58, 180);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(95, 23);
            this.Add_button.TabIndex = 7;
            this.Add_button.Text = "Add Employee";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Modify_button
            // 
            this.Modify_button.Location = new System.Drawing.Point(388, 180);
            this.Modify_button.Name = "Modify_button";
            this.Modify_button.Size = new System.Drawing.Size(95, 23);
            this.Modify_button.TabIndex = 8;
            this.Modify_button.Text = "Modify Employee";
            this.Modify_button.UseVisualStyleBackColor = true;
            this.Modify_button.Click += new System.EventHandler(this.Modify_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(230, 180);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(95, 23);
            this.Delete_button.TabIndex = 9;
            this.Delete_button.Text = "Delete Employee";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // exceptionLabel
            // 
            this.exceptionLabel.AutoSize = true;
            this.exceptionLabel.Location = new System.Drawing.Point(246, 19);
            this.exceptionLabel.Name = "exceptionLabel";
            this.exceptionLabel.Size = new System.Drawing.Size(45, 13);
            this.exceptionLabel.TabIndex = 10;
            this.exceptionLabel.Text = "Wyjątki:";
            // 
            // PositiongroupBox
            // 
            this.PositiongroupBox.Controls.Add(this.Experience3DcomboBox);
            this.PositiongroupBox.Controls.Add(this.SanepidcomboBox);
            this.PositiongroupBox.Controls.Add(this.TScomboBox);
            this.PositiongroupBox.Controls.Add(this.TSlabel);
            this.PositiongroupBox.Controls.Add(this.Paymentlabel);
            this.PositiongroupBox.Controls.Add(this.PaymenttextBox);
            this.PositiongroupBox.Controls.Add(this.Experience3Dlabel);
            this.PositiongroupBox.Controls.Add(this.Sanepidlabel);
            this.PositiongroupBox.Controls.Add(this.WorkedHourslabel);
            this.PositiongroupBox.Controls.Add(this.perHourBruttolabel);
            this.PositiongroupBox.Controls.Add(this.perHourNettolabel);
            this.PositiongroupBox.Controls.Add(this.perHourNettotextBox);
            this.PositiongroupBox.Controls.Add(this.WorkedHourstextBox);
            this.PositiongroupBox.Controls.Add(this.perHourBruttotextBox);
            this.PositiongroupBox.Location = new System.Drawing.Point(333, 517);
            this.PositiongroupBox.Name = "PositiongroupBox";
            this.PositiongroupBox.Size = new System.Drawing.Size(670, 134);
            this.PositiongroupBox.TabIndex = 11;
            this.PositiongroupBox.TabStop = false;
            this.PositiongroupBox.Text = "Technician/Staff";
            // 
            // Experience3DcomboBox
            // 
            this.Experience3DcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Experience3DcomboBox.FormattingEnabled = true;
            this.Experience3DcomboBox.Items.AddRange(new object[] {
            "true",
            "false"});
            this.Experience3DcomboBox.Location = new System.Drawing.Point(359, 52);
            this.Experience3DcomboBox.Name = "Experience3DcomboBox";
            this.Experience3DcomboBox.Size = new System.Drawing.Size(121, 21);
            this.Experience3DcomboBox.TabIndex = 32;
            // 
            // SanepidcomboBox
            // 
            this.SanepidcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SanepidcomboBox.FormattingEnabled = true;
            this.SanepidcomboBox.Items.AddRange(new object[] {
            "true",
            "false"});
            this.SanepidcomboBox.Location = new System.Drawing.Point(359, 91);
            this.SanepidcomboBox.Name = "SanepidcomboBox";
            this.SanepidcomboBox.Size = new System.Drawing.Size(121, 21);
            this.SanepidcomboBox.TabIndex = 31;
            // 
            // TScomboBox
            // 
            this.TScomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TScomboBox.FormattingEnabled = true;
            this.TScomboBox.Items.AddRange(new object[] {
            "Staff",
            "Technician"});
            this.TScomboBox.Location = new System.Drawing.Point(528, 34);
            this.TScomboBox.Name = "TScomboBox";
            this.TScomboBox.Size = new System.Drawing.Size(121, 21);
            this.TScomboBox.TabIndex = 30;
            // 
            // TSlabel
            // 
            this.TSlabel.AutoSize = true;
            this.TSlabel.Location = new System.Drawing.Point(544, 18);
            this.TSlabel.Name = "TSlabel";
            this.TSlabel.Size = new System.Drawing.Size(87, 13);
            this.TSlabel.TabIndex = 29;
            this.TSlabel.Text = "Technician/Staff";
            // 
            // Paymentlabel
            // 
            this.Paymentlabel.AutoSize = true;
            this.Paymentlabel.Location = new System.Drawing.Point(280, 24);
            this.Paymentlabel.Name = "Paymentlabel";
            this.Paymentlabel.Size = new System.Drawing.Size(48, 13);
            this.Paymentlabel.TabIndex = 28;
            this.Paymentlabel.Text = "Payment";
            // 
            // PaymenttextBox
            // 
            this.PaymenttextBox.Location = new System.Drawing.Point(359, 21);
            this.PaymenttextBox.Name = "PaymenttextBox";
            this.PaymenttextBox.Size = new System.Drawing.Size(121, 20);
            this.PaymenttextBox.TabIndex = 27;
            // 
            // Experience3Dlabel
            // 
            this.Experience3Dlabel.AutoSize = true;
            this.Experience3Dlabel.Location = new System.Drawing.Point(280, 60);
            this.Experience3Dlabel.Name = "Experience3Dlabel";
            this.Experience3Dlabel.Size = new System.Drawing.Size(74, 13);
            this.Experience3Dlabel.TabIndex = 26;
            this.Experience3Dlabel.Text = "Experience3D";
            // 
            // Sanepidlabel
            // 
            this.Sanepidlabel.AutoSize = true;
            this.Sanepidlabel.Location = new System.Drawing.Point(282, 94);
            this.Sanepidlabel.Name = "Sanepidlabel";
            this.Sanepidlabel.Size = new System.Drawing.Size(46, 13);
            this.Sanepidlabel.TabIndex = 25;
            this.Sanepidlabel.Text = "Sanepid";
            // 
            // WorkedHourslabel
            // 
            this.WorkedHourslabel.AutoSize = true;
            this.WorkedHourslabel.Location = new System.Drawing.Point(25, 95);
            this.WorkedHourslabel.Name = "WorkedHourslabel";
            this.WorkedHourslabel.Size = new System.Drawing.Size(73, 13);
            this.WorkedHourslabel.TabIndex = 23;
            this.WorkedHourslabel.Text = "WorkedHours";
            // 
            // perHourBruttolabel
            // 
            this.perHourBruttolabel.AutoSize = true;
            this.perHourBruttolabel.Location = new System.Drawing.Point(25, 56);
            this.perHourBruttolabel.Name = "perHourBruttolabel";
            this.perHourBruttolabel.Size = new System.Drawing.Size(73, 13);
            this.perHourBruttolabel.TabIndex = 22;
            this.perHourBruttolabel.Text = "perHourBrutto";
            // 
            // perHourNettolabel
            // 
            this.perHourNettolabel.AutoSize = true;
            this.perHourNettolabel.Location = new System.Drawing.Point(25, 21);
            this.perHourNettolabel.Name = "perHourNettolabel";
            this.perHourNettolabel.Size = new System.Drawing.Size(71, 13);
            this.perHourNettolabel.TabIndex = 21;
            this.perHourNettolabel.Text = "perHourNetto";
            // 
            // perHourNettotextBox
            // 
            this.perHourNettotextBox.Location = new System.Drawing.Point(116, 18);
            this.perHourNettotextBox.Name = "perHourNettotextBox";
            this.perHourNettotextBox.Size = new System.Drawing.Size(121, 20);
            this.perHourNettotextBox.TabIndex = 20;
            // 
            // WorkedHourstextBox
            // 
            this.WorkedHourstextBox.Location = new System.Drawing.Point(116, 92);
            this.WorkedHourstextBox.Name = "WorkedHourstextBox";
            this.WorkedHourstextBox.Size = new System.Drawing.Size(121, 20);
            this.WorkedHourstextBox.TabIndex = 16;
            // 
            // perHourBruttotextBox
            // 
            this.perHourBruttotextBox.Location = new System.Drawing.Point(116, 53);
            this.perHourBruttotextBox.Name = "perHourBruttotextBox";
            this.perHourBruttotextBox.Size = new System.Drawing.Size(121, 20);
            this.perHourBruttotextBox.TabIndex = 15;
            // 
            // TSbutton
            // 
            this.TSbutton.Location = new System.Drawing.Point(592, 372);
            this.TSbutton.Name = "TSbutton";
            this.TSbutton.Size = new System.Drawing.Size(95, 49);
            this.TSbutton.TabIndex = 12;
            this.TSbutton.Text = "Modify Technician/Staff";
            this.TSbutton.UseVisualStyleBackColor = true;
            this.TSbutton.Click += new System.EventHandler(this.TSbutton_Click);
            // 
            // Employee_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.TSbutton);
            this.Controls.Add(this.PositiongroupBox);
            this.Controls.Add(this.Employees_grid);
            this.Controls.Add(this.exceptionLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Technicians_label);
            this.Controls.Add(this.Staff_label);
            this.Controls.Add(this.Technicians_grid);
            this.Controls.Add(this.Staff_grid);
            this.Controls.Add(this.Employees_label);
            this.Name = "Employee_control";
            this.Size = new System.Drawing.Size(1313, 670);
            ((System.ComponentModel.ISupportInitialize)(this.Employees_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Staff_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Technicians_grid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PositiongroupBox.ResumeLayout(false);
            this.PositiongroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Employees_grid;
        private System.Windows.Forms.Label Employees_label;
        private System.Windows.Forms.DataGridView Staff_grid;
        private System.Windows.Forms.DataGridView Technicians_grid;
        private System.Windows.Forms.Label Staff_label;
        private System.Windows.Forms.Label Technicians_label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox PositioncomboBox;
        private System.Windows.Forms.TextBox AdresstextBox;
        private System.Windows.Forms.TextBox PeseltextBox;
        private System.Windows.Forms.TextBox LastNametextBox;
        private System.Windows.Forms.TextBox FirstNametextBox;
        private System.Windows.Forms.TextBox CitytextBox;
        private System.Windows.Forms.TextBox DateOFBirthtextBox;
        private System.Windows.Forms.Label City_label;
        private System.Windows.Forms.Label Adress_label;
        private System.Windows.Forms.Label DateOfBirth_label;
        private System.Windows.Forms.Label Pesel_label;
        private System.Windows.Forms.Label LastName_label;
        private System.Windows.Forms.Label FirstName_label;
        private System.Windows.Forms.Label Position_label;
        private System.Windows.Forms.Label Country_label;
        private System.Windows.Forms.TextBox CountrytextBox;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Modify_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Label exceptionLabel;
        private System.Windows.Forms.GroupBox PositiongroupBox;
        private System.Windows.Forms.ComboBox Experience3DcomboBox;
        private System.Windows.Forms.ComboBox SanepidcomboBox;
        private System.Windows.Forms.ComboBox TScomboBox;
        private System.Windows.Forms.Label TSlabel;
        private System.Windows.Forms.Label Paymentlabel;
        private System.Windows.Forms.TextBox PaymenttextBox;
        private System.Windows.Forms.Label Experience3Dlabel;
        private System.Windows.Forms.Label Sanepidlabel;
        private System.Windows.Forms.Label WorkedHourslabel;
        private System.Windows.Forms.Label perHourBruttolabel;
        private System.Windows.Forms.Label perHourNettolabel;
        private System.Windows.Forms.TextBox perHourNettotextBox;
        private System.Windows.Forms.TextBox WorkedHourstextBox;
        private System.Windows.Forms.TextBox perHourBruttotextBox;
        private System.Windows.Forms.Button TSbutton;
    }
}
