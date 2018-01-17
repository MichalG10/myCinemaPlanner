namespace MyCinemaPlanner
{
    partial class TicketsManagment
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
            this.label1 = new System.Windows.Forms.Label();
            this.ticketOrderGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.sprzedazDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.calosciowaCheckBox = new System.Windows.Forms.CheckBox();
            this.odswiezButton = new System.Windows.Forms.Button();
            this.mostPopularButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateOD = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateDO = new System.Windows.Forms.DateTimePicker();
            this.ticketsGrid = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.ComboBox();
            this.typeCheckBox = new System.Windows.Forms.CheckBox();
            this.timeCheckBox = new System.Windows.Forms.CheckBox();
            this.priceNumeric = new System.Windows.Forms.NumericUpDown();
            this.ticketModifyButton = new System.Windows.Forms.Button();
            this.ticketAddButton = new System.Windows.Forms.Button();
            this.ticketRemoveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ticketOrderGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Menadżer sprzedaży biletów";
            // 
            // ticketOrderGrid
            // 
            this.ticketOrderGrid.AllowUserToAddRows = false;
            this.ticketOrderGrid.AllowUserToDeleteRows = false;
            this.ticketOrderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketOrderGrid.Location = new System.Drawing.Point(7, 60);
            this.ticketOrderGrid.Name = "ticketOrderGrid";
            this.ticketOrderGrid.ReadOnly = true;
            this.ticketOrderGrid.Size = new System.Drawing.Size(643, 401);
            this.ticketOrderGrid.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(4, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Sprzedaż z dnia:";
            // 
            // sprzedazDateTimePicker
            // 
            this.sprzedazDateTimePicker.Location = new System.Drawing.Point(133, 37);
            this.sprzedazDateTimePicker.Name = "sprzedazDateTimePicker";
            this.sprzedazDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.sprzedazDateTimePicker.TabIndex = 26;
            // 
            // calosciowaCheckBox
            // 
            this.calosciowaCheckBox.AutoSize = true;
            this.calosciowaCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.calosciowaCheckBox.ForeColor = System.Drawing.Color.White;
            this.calosciowaCheckBox.Location = new System.Drawing.Point(341, 37);
            this.calosciowaCheckBox.Name = "calosciowaCheckBox";
            this.calosciowaCheckBox.Size = new System.Drawing.Size(100, 20);
            this.calosciowaCheckBox.TabIndex = 27;
            this.calosciowaCheckBox.Text = "Całościowa";
            this.calosciowaCheckBox.UseVisualStyleBackColor = true;
            // 
            // odswiezButton
            // 
            this.odswiezButton.Location = new System.Drawing.Point(574, 33);
            this.odswiezButton.Name = "odswiezButton";
            this.odswiezButton.Size = new System.Drawing.Size(75, 23);
            this.odswiezButton.TabIndex = 28;
            this.odswiezButton.Text = "Odśwież";
            this.odswiezButton.UseVisualStyleBackColor = true;
            this.odswiezButton.Click += new System.EventHandler(this.odswiezButton_Click);
            // 
            // mostPopularButton
            // 
            this.mostPopularButton.Location = new System.Drawing.Point(7, 467);
            this.mostPopularButton.Name = "mostPopularButton";
            this.mostPopularButton.Size = new System.Drawing.Size(181, 50);
            this.mostPopularButton.TabIndex = 29;
            this.mostPopularButton.Text = "Pokaż najbardziej popularne seanse";
            this.mostPopularButton.UseVisualStyleBackColor = true;
            this.mostPopularButton.Click += new System.EventHandler(this.mostPopularButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(194, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "W dniach od:";
            // 
            // dateOD
            // 
            this.dateOD.Location = new System.Drawing.Point(299, 467);
            this.dateOD.Name = "dateOD";
            this.dateOD.Size = new System.Drawing.Size(200, 20);
            this.dateOD.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(263, 499);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 18);
            this.label4.TabIndex = 32;
            this.label4.Text = "do:";
            // 
            // dateDO
            // 
            this.dateDO.Location = new System.Drawing.Point(299, 499);
            this.dateDO.Name = "dateDO";
            this.dateDO.Size = new System.Drawing.Size(200, 20);
            this.dateDO.TabIndex = 33;
            // 
            // ticketsGrid
            // 
            this.ticketsGrid.AllowUserToAddRows = false;
            this.ticketsGrid.AllowUserToDeleteRows = false;
            this.ticketsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketsGrid.Location = new System.Drawing.Point(674, 60);
            this.ticketsGrid.Name = "ticketsGrid";
            this.ticketsGrid.ReadOnly = true;
            this.ticketsGrid.Size = new System.Drawing.Size(568, 270);
            this.ticketsGrid.TabIndex = 34;
            this.ticketsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ticketsGrid_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(671, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 18);
            this.label5.TabIndex = 35;
            this.label5.Text = "Dostępne bilety:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ticketRemoveButton);
            this.groupBox1.Controls.Add(this.ticketAddButton);
            this.groupBox1.Controls.Add(this.ticketModifyButton);
            this.groupBox1.Controls.Add(this.priceNumeric);
            this.groupBox1.Controls.Add(this.timeCheckBox);
            this.groupBox1.Controls.Add(this.typeCheckBox);
            this.groupBox1.Controls.Add(this.nameBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(674, 337);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 124);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj/Modyfikuj/Usuń Bilet";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(6, 42);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(38, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Typ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(6, 18);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Rodzaj:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(6, 69);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Pora dnia:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(6, 95);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Cena:";
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.nameBox.FormattingEnabled = true;
            this.nameBox.Location = new System.Drawing.Point(92, 19);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(169, 21);
            this.nameBox.TabIndex = 5;
            // 
            // typeCheckBox
            // 
            this.typeCheckBox.AutoSize = true;
            this.typeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.typeCheckBox.Location = new System.Drawing.Point(92, 45);
            this.typeCheckBox.Name = "typeCheckBox";
            this.typeCheckBox.Size = new System.Drawing.Size(169, 24);
            this.typeCheckBox.TabIndex = 6;
            this.typeCheckBox.Text = "Seans weekendowy";
            this.typeCheckBox.UseVisualStyleBackColor = true;
            // 
            // timeCheckBox
            // 
            this.timeCheckBox.AutoSize = true;
            this.timeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeCheckBox.Location = new System.Drawing.Point(92, 69);
            this.timeCheckBox.Name = "timeCheckBox";
            this.timeCheckBox.Size = new System.Drawing.Size(147, 24);
            this.timeCheckBox.TabIndex = 7;
            this.timeCheckBox.Text = "Seans wieczorny";
            this.timeCheckBox.UseVisualStyleBackColor = true;
            // 
            // priceNumeric
            // 
            this.priceNumeric.DecimalPlaces = 2;
            this.priceNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.priceNumeric.Location = new System.Drawing.Point(92, 95);
            this.priceNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.priceNumeric.Name = "priceNumeric";
            this.priceNumeric.Size = new System.Drawing.Size(169, 21);
            this.priceNumeric.TabIndex = 8;
            // 
            // ticketModifyButton
            // 
            this.ticketModifyButton.ForeColor = System.Drawing.Color.Black;
            this.ticketModifyButton.Location = new System.Drawing.Point(332, 12);
            this.ticketModifyButton.Name = "ticketModifyButton";
            this.ticketModifyButton.Size = new System.Drawing.Size(230, 50);
            this.ticketModifyButton.TabIndex = 9;
            this.ticketModifyButton.Text = "Modyfikuj bilet";
            this.ticketModifyButton.UseVisualStyleBackColor = true;
            this.ticketModifyButton.Click += new System.EventHandler(this.ticketModifyButton_Click);
            // 
            // ticketAddButton
            // 
            this.ticketAddButton.ForeColor = System.Drawing.Color.Black;
            this.ticketAddButton.Location = new System.Drawing.Point(332, 65);
            this.ticketAddButton.Name = "ticketAddButton";
            this.ticketAddButton.Size = new System.Drawing.Size(114, 50);
            this.ticketAddButton.TabIndex = 10;
            this.ticketAddButton.Text = "Dodaj bilet";
            this.ticketAddButton.UseVisualStyleBackColor = true;
            this.ticketAddButton.Click += new System.EventHandler(this.ticketAddButton_Click);
            // 
            // ticketRemoveButton
            // 
            this.ticketRemoveButton.ForeColor = System.Drawing.Color.Black;
            this.ticketRemoveButton.Location = new System.Drawing.Point(452, 65);
            this.ticketRemoveButton.Name = "ticketRemoveButton";
            this.ticketRemoveButton.Size = new System.Drawing.Size(110, 50);
            this.ticketRemoveButton.TabIndex = 11;
            this.ticketRemoveButton.Text = "Usuń bilet";
            this.ticketRemoveButton.UseVisualStyleBackColor = true;
            this.ticketRemoveButton.Click += new System.EventHandler(this.ticketRemoveButton_Click);
            // 
            // TicketsManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ticketsGrid);
            this.Controls.Add(this.dateDO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateOD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mostPopularButton);
            this.Controls.Add(this.odswiezButton);
            this.Controls.Add(this.calosciowaCheckBox);
            this.Controls.Add(this.sprzedazDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ticketOrderGrid);
            this.Controls.Add(this.label1);
            this.Name = "TicketsManagment";
            this.Size = new System.Drawing.Size(1320, 585);
            ((System.ComponentModel.ISupportInitialize)(this.ticketOrderGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ticketOrderGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker sprzedazDateTimePicker;
        private System.Windows.Forms.CheckBox calosciowaCheckBox;
        private System.Windows.Forms.Button odswiezButton;
        private System.Windows.Forms.Button mostPopularButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateOD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateDO;
        private System.Windows.Forms.DataGridView ticketsGrid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ticketRemoveButton;
        private System.Windows.Forms.Button ticketAddButton;
        private System.Windows.Forms.Button ticketModifyButton;
        private System.Windows.Forms.NumericUpDown priceNumeric;
        private System.Windows.Forms.CheckBox timeCheckBox;
        private System.Windows.Forms.CheckBox typeCheckBox;
        private System.Windows.Forms.ComboBox nameBox;
    }
}
