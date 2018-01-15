namespace MyCinemaPlanner
{
    partial class TicketCash
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BC_GridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.discountNumeric = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.placeNumeric = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.dodajBiletButton = new System.Windows.Forms.Button();
            this.weekCheckBox = new System.Windows.Forms.CheckBox();
            this.eveningCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.BC_ProduktLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.potwierdzTransButton = new System.Windows.Forms.Button();
            this.anulujTransButton = new System.Windows.Forms.Button();
            this.razemDoZaplaty = new System.Windows.Forms.Label();
            this.orderedGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.BC_GridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discountNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderedGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sprzedaż biletów";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wybierz film:";
            // 
            // BC_GridView
            // 
            this.BC_GridView.AllowUserToAddRows = false;
            this.BC_GridView.AllowUserToDeleteRows = false;
            this.BC_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BC_GridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.BC_GridView.Location = new System.Drawing.Point(7, 53);
            this.BC_GridView.Name = "BC_GridView";
            this.BC_GridView.ReadOnly = true;
            this.BC_GridView.Size = new System.Drawing.Size(727, 135);
            this.BC_GridView.TabIndex = 5;
            this.BC_GridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BC_GridView_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.discountNumeric);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.placeNumeric);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dodajBiletButton);
            this.groupBox1.Controls.Add(this.weekCheckBox);
            this.groupBox1.Controls.Add(this.eveningCheckBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.categoryBox);
            this.groupBox1.Controls.Add(this.BC_ProduktLabel);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(6, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj bilet";
            // 
            // discountNumeric
            // 
            this.discountNumeric.DecimalPlaces = 2;
            this.discountNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.discountNumeric.Location = new System.Drawing.Point(430, 45);
            this.discountNumeric.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.discountNumeric.Name = "discountNumeric";
            this.discountNumeric.Size = new System.Drawing.Size(49, 20);
            this.discountNumeric.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(365, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Zniżka:";
            // 
            // placeNumeric
            // 
            this.placeNumeric.Location = new System.Drawing.Point(287, 45);
            this.placeNumeric.Name = "placeNumeric";
            this.placeNumeric.Size = new System.Drawing.Size(58, 20);
            this.placeNumeric.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(215, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Miejsce:";
            // 
            // dodajBiletButton
            // 
            this.dodajBiletButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajBiletButton.ForeColor = System.Drawing.Color.Black;
            this.dodajBiletButton.Location = new System.Drawing.Point(527, 14);
            this.dodajBiletButton.Name = "dodajBiletButton";
            this.dodajBiletButton.Size = new System.Drawing.Size(194, 78);
            this.dodajBiletButton.TabIndex = 9;
            this.dodajBiletButton.Text = "Dodaj bilety";
            this.dodajBiletButton.UseVisualStyleBackColor = true;
            this.dodajBiletButton.Click += new System.EventHandler(this.dodajBiletButton_Click);
            // 
            // weekCheckBox
            // 
            this.weekCheckBox.AutoSize = true;
            this.weekCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.weekCheckBox.Location = new System.Drawing.Point(16, 68);
            this.weekCheckBox.Name = "weekCheckBox";
            this.weekCheckBox.Size = new System.Drawing.Size(169, 24);
            this.weekCheckBox.TabIndex = 8;
            this.weekCheckBox.Text = "Seans weekendowy";
            this.weekCheckBox.UseVisualStyleBackColor = true;
            // 
            // eveningCheckBox
            // 
            this.eveningCheckBox.AutoSize = true;
            this.eveningCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eveningCheckBox.Location = new System.Drawing.Point(198, 70);
            this.eveningCheckBox.Name = "eveningCheckBox";
            this.eveningCheckBox.Size = new System.Drawing.Size(147, 24);
            this.eveningCheckBox.TabIndex = 7;
            this.eveningCheckBox.Text = "Seans wieczorny";
            this.eveningCheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rodzaj:";
            // 
            // categoryBox
            // 
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Items.AddRange(new object[] {
            "Normalny",
            "Uczniowski",
            "Ulgowy"});
            this.categoryBox.Location = new System.Drawing.Point(81, 44);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(121, 21);
            this.categoryBox.TabIndex = 5;
            // 
            // BC_ProduktLabel
            // 
            this.BC_ProduktLabel.AutoSize = true;
            this.BC_ProduktLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BC_ProduktLabel.Location = new System.Drawing.Point(6, 14);
            this.BC_ProduktLabel.Name = "BC_ProduktLabel";
            this.BC_ProduktLabel.Size = new System.Drawing.Size(129, 24);
            this.BC_ProduktLabel.TabIndex = 1;
            this.BC_ProduktLabel.Text = "Wybrany film";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(4, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Zamówione:";
            // 
            // potwierdzTransButton
            // 
            this.potwierdzTransButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.potwierdzTransButton.ForeColor = System.Drawing.Color.Black;
            this.potwierdzTransButton.Location = new System.Drawing.Point(533, 308);
            this.potwierdzTransButton.Name = "potwierdzTransButton";
            this.potwierdzTransButton.Size = new System.Drawing.Size(200, 67);
            this.potwierdzTransButton.TabIndex = 10;
            this.potwierdzTransButton.Text = "Potwierdz transakcje";
            this.potwierdzTransButton.UseVisualStyleBackColor = true;
            this.potwierdzTransButton.Click += new System.EventHandler(this.potwierdzTransButton_Click);
            // 
            // anulujTransButton
            // 
            this.anulujTransButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.anulujTransButton.ForeColor = System.Drawing.Color.Black;
            this.anulujTransButton.Location = new System.Drawing.Point(533, 376);
            this.anulujTransButton.Name = "anulujTransButton";
            this.anulujTransButton.Size = new System.Drawing.Size(200, 35);
            this.anulujTransButton.TabIndex = 11;
            this.anulujTransButton.Text = "Anuluj transakcje";
            this.anulujTransButton.UseVisualStyleBackColor = true;
            this.anulujTransButton.Click += new System.EventHandler(this.anulujTransButton_Click);
            // 
            // razemDoZaplaty
            // 
            this.razemDoZaplaty.AutoSize = true;
            this.razemDoZaplaty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.razemDoZaplaty.ForeColor = System.Drawing.Color.White;
            this.razemDoZaplaty.Location = new System.Drawing.Point(4, 414);
            this.razemDoZaplaty.Name = "razemDoZaplaty";
            this.razemDoZaplaty.Size = new System.Drawing.Size(192, 18);
            this.razemDoZaplaty.TabIndex = 12;
            this.razemDoZaplaty.Text = "Razem do zapłaty:    0.00zł";
            // 
            // orderedGrid
            // 
            this.orderedGrid.AllowUserToAddRows = false;
            this.orderedGrid.AllowUserToDeleteRows = false;
            this.orderedGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orderedGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.orderedGrid.Location = new System.Drawing.Point(6, 309);
            this.orderedGrid.Name = "orderedGrid";
            this.orderedGrid.ReadOnly = true;
            this.orderedGrid.Size = new System.Drawing.Size(521, 102);
            this.orderedGrid.TabIndex = 13;
            // 
            // TicketCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.orderedGrid);
            this.Controls.Add(this.razemDoZaplaty);
            this.Controls.Add(this.anulujTransButton);
            this.Controls.Add(this.potwierdzTransButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BC_GridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TicketCash";
            this.Size = new System.Drawing.Size(740, 478);
            ((System.ComponentModel.ISupportInitialize)(this.BC_GridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discountNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderedGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView BC_GridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label BC_ProduktLabel;
        private System.Windows.Forms.CheckBox weekCheckBox;
        private System.Windows.Forms.CheckBox eveningCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.Button dodajBiletButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button potwierdzTransButton;
        private System.Windows.Forms.Button anulujTransButton;
        private System.Windows.Forms.Label razemDoZaplaty;
        private System.Windows.Forms.DataGridView orderedGrid;
        private System.Windows.Forms.NumericUpDown placeNumeric;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown discountNumeric;
        private System.Windows.Forms.Label label7;
    }
}
