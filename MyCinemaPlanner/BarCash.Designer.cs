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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BC_GridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BC_CashBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BC_ProduktLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.BC_DodajZamowienieButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BC_GridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // BC_GridView
            // 
            this.BC_GridView.AllowUserToAddRows = false;
            this.BC_GridView.AllowUserToDeleteRows = false;
            this.BC_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BC_GridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.BC_GridView.Location = new System.Drawing.Point(3, 35);
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
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Obsługiwana kasa:";
            // 
            // BC_CashBox
            // 
            this.BC_CashBox.FormattingEnabled = true;
            this.BC_CashBox.Location = new System.Drawing.Point(194, 9);
            this.BC_CashBox.Name = "BC_CashBox";
            this.BC_CashBox.Size = new System.Drawing.Size(121, 21);
            this.BC_CashBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BC_DodajZamowienieButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDown1);
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
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(52, 51);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(158, 22);
            this.numericUpDown1.TabIndex = 1;
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
            // BC_DodajZamowienieButton
            // 
            this.BC_DodajZamowienieButton.ForeColor = System.Drawing.Color.Black;
            this.BC_DodajZamowienieButton.Location = new System.Drawing.Point(6, 161);
            this.BC_DodajZamowienieButton.Name = "BC_DodajZamowienieButton";
            this.BC_DodajZamowienieButton.Size = new System.Drawing.Size(204, 52);
            this.BC_DodajZamowienieButton.TabIndex = 3;
            this.BC_DodajZamowienieButton.Text = "Dodaj do zamówienia";
            this.BC_DodajZamowienieButton.UseVisualStyleBackColor = true;
            // 
            // BarCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BC_CashBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BC_GridView);
            this.Name = "BarCash";
            this.Size = new System.Drawing.Size(739, 458);
            ((System.ComponentModel.ISupportInitialize)(this.BC_GridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BC_GridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BC_CashBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label BC_ProduktLabel;
        private System.Windows.Forms.Button BC_DodajZamowienieButton;
    }
}
