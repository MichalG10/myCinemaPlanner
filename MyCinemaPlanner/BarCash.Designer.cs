namespace MyCinemaPlanner
{
    partial class BarCash
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BC_GridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BC_CashBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BC_ZnizkaNumeric = new System.Windows.Forms.NumericUpDown();
            this.BC_DodajZamowienieButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BC_IloscNumeric = new System.Windows.Forms.NumericUpDown();
            this.BC_ProduktLabel = new System.Windows.Forms.Label();
            this.BC_ZamowieniaGrid = new System.Windows.Forms.DataGridView();
            this.BC_ZamowienieLabel = new System.Windows.Forms.Label();
            this.BC_PotwierdzButton = new System.Windows.Forms.Button();
            this.BC_RazemLabel = new System.Windows.Forms.Label();
            this.BC_AnulujButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BC_GridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BC_ZnizkaNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BC_IloscNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BC_ZamowieniaGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BC_GridView
            // 
            this.BC_GridView.AllowUserToAddRows = false;
            this.BC_GridView.AllowUserToDeleteRows = false;
            this.BC_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BC_GridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.BC_GridView.Location = new System.Drawing.Point(4, 31);
            this.BC_GridView.Name = "BC_GridView";
            this.BC_GridView.ReadOnly = true;
            this.BC_GridView.Size = new System.Drawing.Size(500, 212);
            this.BC_GridView.TabIndex = 0;
            this.BC_GridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BC_GridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Obsługiwana kasa:";
            // 
            // BC_CashBox
            // 
            this.BC_CashBox.FormattingEnabled = true;
            this.BC_CashBox.Location = new System.Drawing.Point(194, 6);
            this.BC_CashBox.Name = "BC_CashBox";
            this.BC_CashBox.Size = new System.Drawing.Size(121, 21);
            this.BC_CashBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BC_ZnizkaNumeric);
            this.groupBox1.Controls.Add(this.BC_DodajZamowienieButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BC_IloscNumeric);
            this.groupBox1.Controls.Add(this.BC_ProduktLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(510, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 219);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wybierz liczbe produktów:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Zniżka:";
            // 
            // BC_ZnizkaNumeric
            // 
            this.BC_ZnizkaNumeric.Location = new System.Drawing.Point(63, 79);
            this.BC_ZnizkaNumeric.Name = "BC_ZnizkaNumeric";
            this.BC_ZnizkaNumeric.Size = new System.Drawing.Size(147, 22);
            this.BC_ZnizkaNumeric.TabIndex = 4;
            // 
            // BC_DodajZamowienieButton
            // 
            this.BC_DodajZamowienieButton.ForeColor = System.Drawing.Color.Black;
            this.BC_DodajZamowienieButton.Location = new System.Drawing.Point(6, 161);
            this.BC_DodajZamowienieButton.Name = "BC_DodajZamowienieButton";
            this.BC_DodajZamowienieButton.Size = new System.Drawing.Size(204, 52);
            this.BC_DodajZamowienieButton.TabIndex = 3;
            this.BC_DodajZamowienieButton.Text = "Dodaj do zamówienia";
            this.BC_DodajZamowienieButton.UseVisualStyleBackColor = true;
            this.BC_DodajZamowienieButton.Click += new System.EventHandler(this.BC_DodajZamowienieButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ilość:";
            // 
            // BC_IloscNumeric
            // 
            this.BC_IloscNumeric.Location = new System.Drawing.Point(63, 51);
            this.BC_IloscNumeric.Name = "BC_IloscNumeric";
            this.BC_IloscNumeric.Size = new System.Drawing.Size(147, 22);
            this.BC_IloscNumeric.TabIndex = 1;
            // 
            // BC_ProduktLabel
            // 
            this.BC_ProduktLabel.AutoSize = true;
            this.BC_ProduktLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BC_ProduktLabel.Location = new System.Drawing.Point(7, 22);
            this.BC_ProduktLabel.Name = "BC_ProduktLabel";
            this.BC_ProduktLabel.Size = new System.Drawing.Size(71, 20);
            this.BC_ProduktLabel.TabIndex = 0;
            this.BC_ProduktLabel.Text = "Produkt";
            // 
            // BC_ZamowieniaGrid
            // 
            this.BC_ZamowieniaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BC_ZamowieniaGrid.Location = new System.Drawing.Point(4, 283);
            this.BC_ZamowieniaGrid.Name = "BC_ZamowieniaGrid";
            this.BC_ZamowieniaGrid.Size = new System.Drawing.Size(500, 101);
            this.BC_ZamowieniaGrid.TabIndex = 4;
            // 
            // BC_ZamowienieLabel
            // 
            this.BC_ZamowienieLabel.AutoSize = true;
            this.BC_ZamowienieLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BC_ZamowienieLabel.ForeColor = System.Drawing.Color.White;
            this.BC_ZamowienieLabel.Location = new System.Drawing.Point(4, 256);
            this.BC_ZamowienieLabel.Name = "BC_ZamowienieLabel";
            this.BC_ZamowienieLabel.Size = new System.Drawing.Size(129, 24);
            this.BC_ZamowienieLabel.TabIndex = 5;
            this.BC_ZamowienieLabel.Text = "Zamówienie:";
            // 
            // BC_PotwierdzButton
            // 
            this.BC_PotwierdzButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BC_PotwierdzButton.Location = new System.Drawing.Point(510, 283);
            this.BC_PotwierdzButton.Name = "BC_PotwierdzButton";
            this.BC_PotwierdzButton.Size = new System.Drawing.Size(216, 101);
            this.BC_PotwierdzButton.TabIndex = 6;
            this.BC_PotwierdzButton.Text = "Potwierdź zamówienie";
            this.BC_PotwierdzButton.UseVisualStyleBackColor = true;
            this.BC_PotwierdzButton.Click += new System.EventHandler(this.BC_PotwierdzButton_Click);
            // 
            // BC_RazemLabel
            // 
            this.BC_RazemLabel.AutoSize = true;
            this.BC_RazemLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BC_RazemLabel.ForeColor = System.Drawing.Color.White;
            this.BC_RazemLabel.Location = new System.Drawing.Point(4, 391);
            this.BC_RazemLabel.Name = "BC_RazemLabel";
            this.BC_RazemLabel.Size = new System.Drawing.Size(255, 24);
            this.BC_RazemLabel.TabIndex = 7;
            this.BC_RazemLabel.Text = "Razem do zapłaty:        0";
            // 
            // BC_AnulujButton
            // 
            this.BC_AnulujButton.Location = new System.Drawing.Point(604, 391);
            this.BC_AnulujButton.Name = "BC_AnulujButton";
            this.BC_AnulujButton.Size = new System.Drawing.Size(122, 24);
            this.BC_AnulujButton.TabIndex = 8;
            this.BC_AnulujButton.Text = "Anuluj zamówienie";
            this.BC_AnulujButton.UseVisualStyleBackColor = true;
            this.BC_AnulujButton.Click += new System.EventHandler(this.BC_AnulujButton_Click);
            // 
            // BarCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.BC_AnulujButton);
            this.Controls.Add(this.BC_RazemLabel);
            this.Controls.Add(this.BC_PotwierdzButton);
            this.Controls.Add(this.BC_ZamowienieLabel);
            this.Controls.Add(this.BC_ZamowieniaGrid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BC_CashBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BC_GridView);
            this.Name = "BarCash";
            this.Size = new System.Drawing.Size(740, 460);
            ((System.ComponentModel.ISupportInitialize)(this.BC_GridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BC_ZnizkaNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BC_IloscNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BC_ZamowieniaGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BC_GridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BC_CashBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown BC_IloscNumeric;
        private System.Windows.Forms.Label BC_ProduktLabel;
        private System.Windows.Forms.Button BC_DodajZamowienieButton;
        private System.Windows.Forms.DataGridView BC_ZamowieniaGrid;
        private System.Windows.Forms.Label BC_ZamowienieLabel;
        private System.Windows.Forms.Button BC_PotwierdzButton;
        private System.Windows.Forms.Label BC_RazemLabel;
        private System.Windows.Forms.Button BC_AnulujButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown BC_ZnizkaNumeric;
    }
}
