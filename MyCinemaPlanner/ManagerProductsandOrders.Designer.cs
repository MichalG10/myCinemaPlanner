namespace MyCinemaPlanner
{
    partial class ManagerProductsandOrders
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
            this.productsGrid = new System.Windows.Forms.DataGridView();
            this.RecordGroupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PNazwaBox = new System.Windows.Forms.TextBox();
            this.PLiczbaNumeric = new System.Windows.Forms.NumericUpDown();
            this.PMinimalnaNumeric = new System.Windows.Forms.NumericUpDown();
            this.PKategoriaBox = new System.Windows.Forms.ComboBox();
            this.PCenaNumeric = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.orderedGrid = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.realizedGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).BeginInit();
            this.RecordGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PLiczbaNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PMinimalnaNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCenaNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderedGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realizedGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Przegląd produktów:";
            // 
            // productsGrid
            // 
            this.productsGrid.AllowUserToAddRows = false;
            this.productsGrid.AllowUserToDeleteRows = false;
            this.productsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGrid.Location = new System.Drawing.Point(7, 27);
            this.productsGrid.Name = "productsGrid";
            this.productsGrid.ReadOnly = true;
            this.productsGrid.Size = new System.Drawing.Size(748, 165);
            this.productsGrid.TabIndex = 25;
            // 
            // RecordGroupBox
            // 
            this.RecordGroupBox.Controls.Add(this.PCenaNumeric);
            this.RecordGroupBox.Controls.Add(this.PKategoriaBox);
            this.RecordGroupBox.Controls.Add(this.PMinimalnaNumeric);
            this.RecordGroupBox.Controls.Add(this.PLiczbaNumeric);
            this.RecordGroupBox.Controls.Add(this.label2);
            this.RecordGroupBox.Controls.Add(this.PNazwaBox);
            this.RecordGroupBox.Controls.Add(this.label5);
            this.RecordGroupBox.Controls.Add(this.label4);
            this.RecordGroupBox.Controls.Add(this.label3);
            this.RecordGroupBox.Controls.Add(this.label6);
            this.RecordGroupBox.ForeColor = System.Drawing.Color.White;
            this.RecordGroupBox.Location = new System.Drawing.Point(761, 21);
            this.RecordGroupBox.Name = "RecordGroupBox";
            this.RecordGroupBox.Size = new System.Drawing.Size(268, 171);
            this.RecordGroupBox.TabIndex = 26;
            this.RecordGroupBox.TabStop = false;
            this.RecordGroupBox.Text = "Dodaj/Zmień/Usuń produkt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kategoria:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(153, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Minimalna liczba:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Liczba w magazynie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cena:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nazwa:";
            // 
            // PNazwaBox
            // 
            this.PNazwaBox.Location = new System.Drawing.Point(83, 18);
            this.PNazwaBox.Name = "PNazwaBox";
            this.PNazwaBox.Size = new System.Drawing.Size(180, 20);
            this.PNazwaBox.TabIndex = 5;
            // 
            // PLiczbaNumeric
            // 
            this.PLiczbaNumeric.Location = new System.Drawing.Point(11, 90);
            this.PLiczbaNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.PLiczbaNumeric.Name = "PLiczbaNumeric";
            this.PLiczbaNumeric.Size = new System.Drawing.Size(66, 20);
            this.PLiczbaNumeric.TabIndex = 8;
            this.PLiczbaNumeric.Tag = "";
            // 
            // PMinimalnaNumeric
            // 
            this.PMinimalnaNumeric.Location = new System.Drawing.Point(156, 90);
            this.PMinimalnaNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.PMinimalnaNumeric.Name = "PMinimalnaNumeric";
            this.PMinimalnaNumeric.Size = new System.Drawing.Size(66, 20);
            this.PMinimalnaNumeric.TabIndex = 9;
            this.PMinimalnaNumeric.Tag = "";
            // 
            // PKategoriaBox
            // 
            this.PKategoriaBox.FormattingEnabled = true;
            this.PKategoriaBox.Location = new System.Drawing.Point(83, 41);
            this.PKategoriaBox.Name = "PKategoriaBox";
            this.PKategoriaBox.Size = new System.Drawing.Size(180, 21);
            this.PKategoriaBox.TabIndex = 10;
            // 
            // PCenaNumeric
            // 
            this.PCenaNumeric.DecimalPlaces = 2;
            this.PCenaNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.PCenaNumeric.Location = new System.Drawing.Point(11, 135);
            this.PCenaNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.PCenaNumeric.Name = "PCenaNumeric";
            this.PCenaNumeric.Size = new System.Drawing.Size(66, 20);
            this.PCenaNumeric.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(3, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(237, 24);
            this.label7.TabIndex = 27;
            this.label7.Text = "Zamówienia w realizacji:";
            // 
            // orderedGrid
            // 
            this.orderedGrid.AllowUserToAddRows = false;
            this.orderedGrid.AllowUserToDeleteRows = false;
            this.orderedGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderedGrid.Location = new System.Drawing.Point(7, 222);
            this.orderedGrid.Name = "orderedGrid";
            this.orderedGrid.ReadOnly = true;
            this.orderedGrid.Size = new System.Drawing.Size(748, 160);
            this.orderedGrid.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(3, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(255, 24);
            this.label8.TabIndex = 29;
            this.label8.Text = "Zamówienia zrealizowane:";
            // 
            // realizedGrid
            // 
            this.realizedGrid.AllowUserToAddRows = false;
            this.realizedGrid.AllowUserToDeleteRows = false;
            this.realizedGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.realizedGrid.Location = new System.Drawing.Point(7, 412);
            this.realizedGrid.Name = "realizedGrid";
            this.realizedGrid.ReadOnly = true;
            this.realizedGrid.Size = new System.Drawing.Size(748, 160);
            this.realizedGrid.TabIndex = 30;
            // 
            // ManagerProductsandOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.realizedGrid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.orderedGrid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RecordGroupBox);
            this.Controls.Add(this.productsGrid);
            this.Controls.Add(this.label1);
            this.Name = "ManagerProductsandOrders";
            this.Size = new System.Drawing.Size(1320, 585);
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).EndInit();
            this.RecordGroupBox.ResumeLayout(false);
            this.RecordGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PLiczbaNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PMinimalnaNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCenaNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderedGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realizedGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView productsGrid;
        private System.Windows.Forms.GroupBox RecordGroupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PNazwaBox;
        private System.Windows.Forms.NumericUpDown PCenaNumeric;
        private System.Windows.Forms.ComboBox PKategoriaBox;
        private System.Windows.Forms.NumericUpDown PMinimalnaNumeric;
        private System.Windows.Forms.NumericUpDown PLiczbaNumeric;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView orderedGrid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView realizedGrid;
    }
}
