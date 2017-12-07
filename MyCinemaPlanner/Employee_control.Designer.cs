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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.FirstName_label = new System.Windows.Forms.Label();
            this.LastName_label = new System.Windows.Forms.Label();
            this.Pesel_label = new System.Windows.Forms.Label();
            this.DateOfBirth_label = new System.Windows.Forms.Label();
            this.Adress_label = new System.Windows.Forms.Label();
            this.City_label = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.Country_label = new System.Windows.Forms.Label();
            this.Position_label = new System.Windows.Forms.Label();
            this.Add_button = new System.Windows.Forms.Button();
            this.Modify_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Employees_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Staff_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Technicians_grid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Employees_grid
            // 
            this.Employees_grid.AllowUserToAddRows = false;
            this.Employees_grid.AllowUserToDeleteRows = false;
            this.Employees_grid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.Employees_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Employees_grid.Location = new System.Drawing.Point(40, 62);
            this.Employees_grid.Name = "Employees_grid";
            this.Employees_grid.ReadOnly = true;
            this.Employees_grid.Size = new System.Drawing.Size(716, 317);
            this.Employees_grid.TabIndex = 0;
            this.Employees_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Employees_grid_CellClick);
            // 
            // Employees_label
            // 
            this.Employees_label.AutoSize = true;
            this.Employees_label.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Employees_label.Location = new System.Drawing.Point(34, 24);
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
            this.Staff_grid.Location = new System.Drawing.Point(40, 434);
            this.Staff_grid.Name = "Staff_grid";
            this.Staff_grid.ReadOnly = true;
            this.Staff_grid.Size = new System.Drawing.Size(532, 212);
            this.Staff_grid.TabIndex = 2;
            this.Staff_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Staff_grid_CellClick);
            // 
            // Technicians_grid
            // 
            this.Technicians_grid.AllowUserToAddRows = false;
            this.Technicians_grid.AllowUserToDeleteRows = false;
            this.Technicians_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Technicians_grid.Location = new System.Drawing.Point(594, 434);
            this.Technicians_grid.Name = "Technicians_grid";
            this.Technicians_grid.ReadOnly = true;
            this.Technicians_grid.Size = new System.Drawing.Size(532, 212);
            this.Technicians_grid.TabIndex = 3;
            this.Technicians_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Technicians_grid_CellClick);
            // 
            // Staff_label
            // 
            this.Staff_label.AutoSize = true;
            this.Staff_label.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Staff_label.Location = new System.Drawing.Point(34, 396);
            this.Staff_label.Name = "Staff_label";
            this.Staff_label.Size = new System.Drawing.Size(64, 35);
            this.Staff_label.TabIndex = 4;
            this.Staff_label.Text = "Staff";
            // 
            // Technicians_label
            // 
            this.Technicians_label.AutoSize = true;
            this.Technicians_label.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Technicians_label.Location = new System.Drawing.Point(588, 396);
            this.Technicians_label.Name = "Technicians_label";
            this.Technicians_label.Size = new System.Drawing.Size(133, 35);
            this.Technicians_label.TabIndex = 5;
            this.Technicians_label.Text = "Technicians";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Position_label);
            this.groupBox1.Controls.Add(this.Country_label);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.City_label);
            this.groupBox1.Controls.Add(this.Adress_label);
            this.groupBox1.Controls.Add(this.DateOfBirth_label);
            this.groupBox1.Controls.Add(this.Pesel_label);
            this.groupBox1.Controls.Add(this.LastName_label);
            this.groupBox1.Controls.Add(this.FirstName_label);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(813, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 317);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Delete Employee";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Staff",
            "Technician"});
            this.comboBox1.Location = new System.Drawing.Point(146, 285);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(146, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(146, 167);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(146, 131);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 20);
            this.textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(146, 203);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(121, 20);
            this.textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(146, 20);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(121, 20);
            this.textBox6.TabIndex = 6;
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
            // LastName_label
            // 
            this.LastName_label.AutoSize = true;
            this.LastName_label.Location = new System.Drawing.Point(55, 58);
            this.LastName_label.Name = "LastName_label";
            this.LastName_label.Size = new System.Drawing.Size(58, 13);
            this.LastName_label.TabIndex = 8;
            this.LastName_label.Text = "Last Name";
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
            // DateOfBirth_label
            // 
            this.DateOfBirth_label.AutoSize = true;
            this.DateOfBirth_label.Location = new System.Drawing.Point(55, 134);
            this.DateOfBirth_label.Name = "DateOfBirth_label";
            this.DateOfBirth_label.Size = new System.Drawing.Size(66, 13);
            this.DateOfBirth_label.TabIndex = 10;
            this.DateOfBirth_label.Text = "Date of Birth";
            // 
            // Adress_label
            // 
            this.Adress_label.AutoSize = true;
            this.Adress_label.Location = new System.Drawing.Point(55, 170);
            this.Adress_label.Name = "Adress_label";
            this.Adress_label.Size = new System.Drawing.Size(39, 13);
            this.Adress_label.TabIndex = 11;
            this.Adress_label.Text = "Adress";
            // 
            // City_label
            // 
            this.City_label.AutoSize = true;
            this.City_label.Location = new System.Drawing.Point(55, 206);
            this.City_label.Name = "City_label";
            this.City_label.Size = new System.Drawing.Size(24, 13);
            this.City_label.TabIndex = 12;
            this.City_label.Text = "City";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(146, 246);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(121, 20);
            this.textBox7.TabIndex = 13;
            // 
            // Country_label
            // 
            this.Country_label.AutoSize = true;
            this.Country_label.Location = new System.Drawing.Point(55, 249);
            this.Country_label.Name = "Country_label";
            this.Country_label.Size = new System.Drawing.Size(43, 13);
            this.Country_label.TabIndex = 14;
            this.Country_label.Text = "Country";
            // 
            // Position_label
            // 
            this.Position_label.AutoSize = true;
            this.Position_label.Location = new System.Drawing.Point(55, 288);
            this.Position_label.Name = "Position_label";
            this.Position_label.Size = new System.Drawing.Size(44, 13);
            this.Position_label.TabIndex = 15;
            this.Position_label.Text = "Position";
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(806, 396);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(95, 23);
            this.Add_button.TabIndex = 7;
            this.Add_button.Text = "Add Employee";
            this.Add_button.UseVisualStyleBackColor = true;
            // 
            // Modify_button
            // 
            this.Modify_button.Location = new System.Drawing.Point(1042, 396);
            this.Modify_button.Name = "Modify_button";
            this.Modify_button.Size = new System.Drawing.Size(95, 23);
            this.Modify_button.TabIndex = 8;
            this.Modify_button.Text = "Modify Employee";
            this.Modify_button.UseVisualStyleBackColor = true;
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(925, 396);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(95, 23);
            this.Delete_button.TabIndex = 9;
            this.Delete_button.Text = "Delete Employee";
            this.Delete_button.UseVisualStyleBackColor = true;
            // 
            // Employee_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Modify_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Technicians_label);
            this.Controls.Add(this.Staff_label);
            this.Controls.Add(this.Technicians_grid);
            this.Controls.Add(this.Staff_grid);
            this.Controls.Add(this.Employees_label);
            this.Controls.Add(this.Employees_grid);
            this.Name = "Employee_control";
            this.Size = new System.Drawing.Size(1162, 664);
            ((System.ComponentModel.ISupportInitialize)(this.Employees_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Staff_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Technicians_grid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label City_label;
        private System.Windows.Forms.Label Adress_label;
        private System.Windows.Forms.Label DateOfBirth_label;
        private System.Windows.Forms.Label Pesel_label;
        private System.Windows.Forms.Label LastName_label;
        private System.Windows.Forms.Label FirstName_label;
        private System.Windows.Forms.Label Position_label;
        private System.Windows.Forms.Label Country_label;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Modify_button;
        private System.Windows.Forms.Button Delete_button;
    }
}
