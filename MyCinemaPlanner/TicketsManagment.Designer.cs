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
            ((System.ComponentModel.ISupportInitialize)(this.ticketOrderGrid)).BeginInit();
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
            // TicketsManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
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
    }
}
