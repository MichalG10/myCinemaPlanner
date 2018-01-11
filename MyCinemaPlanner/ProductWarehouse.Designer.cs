namespace MyCinemaPlanner
{
    partial class ProductWarehouse
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
            this.label1 = new System.Windows.Forms.Label();
            this.PW_MainGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PW_IloscwmagNumeric = new System.Windows.Forms.NumericUpDown();
            this.PW_KategoriaBox = new System.Windows.Forms.ComboBox();
            this.PW_ProduktBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PW_ProduktLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PW_IloscdoodrzNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.PW_MainGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PW_IloscwmagNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PW_IloscdoodrzNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Obsługa magazynu";
            // 
            // PW_MainGrid
            // 
            this.PW_MainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PW_MainGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.PW_MainGrid.Location = new System.Drawing.Point(4, 31);
            this.PW_MainGrid.Name = "PW_MainGrid";
            this.PW_MainGrid.Size = new System.Drawing.Size(448, 400);
            this.PW_MainGrid.TabIndex = 3;
            this.PW_MainGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PW_MainGrid_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PW_IloscdoodrzNumeric);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.PW_IloscwmagNumeric);
            this.groupBox1.Controls.Add(this.PW_KategoriaBox);
            this.groupBox1.Controls.Add(this.PW_ProduktBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.PW_ProduktLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(458, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 183);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aktualizuj produkt";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(7, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 49);
            this.button1.TabIndex = 11;
            this.button1.Text = "Aktualizuj produkt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ilość dostarczonych:";
            // 
            // PW_IloscwmagNumeric
            // 
            this.PW_IloscwmagNumeric.Location = new System.Drawing.Point(141, 72);
            this.PW_IloscwmagNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.PW_IloscwmagNumeric.Name = "PW_IloscwmagNumeric";
            this.PW_IloscwmagNumeric.Size = new System.Drawing.Size(121, 22);
            this.PW_IloscwmagNumeric.TabIndex = 7;
            this.PW_IloscwmagNumeric.Tag = "";
            // 
            // PW_KategoriaBox
            // 
            this.PW_KategoriaBox.FormattingEnabled = true;
            this.PW_KategoriaBox.Location = new System.Drawing.Point(84, 44);
            this.PW_KategoriaBox.Name = "PW_KategoriaBox";
            this.PW_KategoriaBox.Size = new System.Drawing.Size(178, 24);
            this.PW_KategoriaBox.TabIndex = 6;
            // 
            // PW_ProduktBox
            // 
            this.PW_ProduktBox.Location = new System.Drawing.Point(84, 17);
            this.PW_ProduktBox.Name = "PW_ProduktBox";
            this.PW_ProduktBox.Size = new System.Drawing.Size(178, 22);
            this.PW_ProduktBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kategoria:";
            // 
            // PW_ProduktLabel
            // 
            this.PW_ProduktLabel.AutoSize = true;
            this.PW_ProduktLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PW_ProduktLabel.Location = new System.Drawing.Point(6, 18);
            this.PW_ProduktLabel.Name = "PW_ProduktLabel";
            this.PW_ProduktLabel.Size = new System.Drawing.Size(72, 18);
            this.PW_ProduktLabel.TabIndex = 1;
            this.PW_ProduktLabel.Text = "Produkt:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(6, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ilość do odrzucenia:";
            // 
            // PW_IloscdoodrzNumeric
            // 
            this.PW_IloscdoodrzNumeric.Location = new System.Drawing.Point(141, 97);
            this.PW_IloscdoodrzNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.PW_IloscdoodrzNumeric.Name = "PW_IloscdoodrzNumeric";
            this.PW_IloscdoodrzNumeric.Size = new System.Drawing.Size(121, 22);
            this.PW_IloscdoodrzNumeric.TabIndex = 13;
            this.PW_IloscdoodrzNumeric.Tag = "";
            // 
            // ProductWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PW_MainGrid);
            this.Controls.Add(this.label1);
            this.Name = "ProductWarehouse";
            this.Size = new System.Drawing.Size(740, 460);
            ((System.ComponentModel.ISupportInitialize)(this.PW_MainGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PW_IloscwmagNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PW_IloscdoodrzNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView PW_MainGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label PW_ProduktLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PW_ProduktBox;
        private System.Windows.Forms.ComboBox PW_KategoriaBox;
        private System.Windows.Forms.NumericUpDown PW_IloscwmagNumeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown PW_IloscdoodrzNumeric;
        private System.Windows.Forms.Label label4;
    }
}
