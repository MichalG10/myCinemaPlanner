namespace MyCinemaPlanner
{
    partial class DailyView
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
            this.dailyViewMainGrid = new System.Windows.Forms.DataGridView();
            this.dailyViewComboBox = new System.Windows.Forms.ComboBox();
            this.PokazButton = new System.Windows.Forms.Button();
            this.RecordGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DV_SalaKasaBox = new System.Windows.Forms.ComboBox();
            this.DV_DatePicker = new System.Windows.Forms.DateTimePicker();
            this.TimeStartPicker = new System.Windows.Forms.DateTimePicker();
            this.TimeEndPicker = new System.Windows.Forms.DateTimePicker();
            this.DV_PracownicyBox = new System.Windows.Forms.ComboBox();
            this.DV_DodajWpisButton = new System.Windows.Forms.Button();
            this.DV_UsunWpisButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dailyViewMainGrid)).BeginInit();
            this.RecordGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dailyViewMainGrid
            // 
            this.dailyViewMainGrid.AllowUserToAddRows = false;
            this.dailyViewMainGrid.AllowUserToDeleteRows = false;
            this.dailyViewMainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dailyViewMainGrid.Location = new System.Drawing.Point(4, 42);
            this.dailyViewMainGrid.Name = "dailyViewMainGrid";
            this.dailyViewMainGrid.ReadOnly = true;
            this.dailyViewMainGrid.Size = new System.Drawing.Size(537, 201);
            this.dailyViewMainGrid.TabIndex = 0;
            // 
            // dailyViewComboBox
            // 
            this.dailyViewComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.dailyViewComboBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyViewComboBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dailyViewComboBox.FormattingEnabled = true;
            this.dailyViewComboBox.Items.AddRange(new object[] {
            "Pracownicy sal",
            "Pracownicy kas"});
            this.dailyViewComboBox.Location = new System.Drawing.Point(4, 4);
            this.dailyViewComboBox.Name = "dailyViewComboBox";
            this.dailyViewComboBox.Size = new System.Drawing.Size(182, 32);
            this.dailyViewComboBox.TabIndex = 1;
            this.dailyViewComboBox.Text = "Pracownicy sal";
            this.dailyViewComboBox.SelectedIndexChanged += new System.EventHandler(this.PokazButton_Click);
            // 
            // PokazButton
            // 
            this.PokazButton.Location = new System.Drawing.Point(193, 4);
            this.PokazButton.Name = "PokazButton";
            this.PokazButton.Size = new System.Drawing.Size(80, 32);
            this.PokazButton.TabIndex = 2;
            this.PokazButton.Text = "Pokaż";
            this.PokazButton.UseVisualStyleBackColor = true;
            this.PokazButton.Click += new System.EventHandler(this.PokazButton_Click);
            // 
            // RecordGroupBox
            // 
            this.RecordGroupBox.Controls.Add(this.TimeEndPicker);
            this.RecordGroupBox.Controls.Add(this.TimeStartPicker);
            this.RecordGroupBox.Controls.Add(this.DV_DatePicker);
            this.RecordGroupBox.Controls.Add(this.DV_SalaKasaBox);
            this.RecordGroupBox.Controls.Add(this.DV_PracownicyBox);
            this.RecordGroupBox.Controls.Add(this.label5);
            this.RecordGroupBox.Controls.Add(this.label4);
            this.RecordGroupBox.Controls.Add(this.label3);
            this.RecordGroupBox.Controls.Add(this.label2);
            this.RecordGroupBox.Controls.Add(this.label1);
            this.RecordGroupBox.ForeColor = System.Drawing.Color.White;
            this.RecordGroupBox.Location = new System.Drawing.Point(547, 42);
            this.RecordGroupBox.Name = "RecordGroupBox";
            this.RecordGroupBox.Size = new System.Drawing.Size(284, 129);
            this.RecordGroupBox.TabIndex = 3;
            this.RecordGroupBox.TabStop = false;
            this.RecordGroupBox.Text = "Dodaj/Usuń wpis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pracownik:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sala/Kasa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(151, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Koniec:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dzień:";
            // 
            // DV_SalaKasaBox
            // 
            this.DV_SalaKasaBox.FormattingEnabled = true;
            this.DV_SalaKasaBox.Location = new System.Drawing.Point(80, 45);
            this.DV_SalaKasaBox.Name = "DV_SalaKasaBox";
            this.DV_SalaKasaBox.Size = new System.Drawing.Size(194, 21);
            this.DV_SalaKasaBox.TabIndex = 5;
            // 
            // DV_DatePicker
            // 
            this.DV_DatePicker.Location = new System.Drawing.Point(80, 100);
            this.DV_DatePicker.Name = "DV_DatePicker";
            this.DV_DatePicker.Size = new System.Drawing.Size(194, 20);
            this.DV_DatePicker.TabIndex = 8;
            // 
            // TimeStartPicker
            // 
            this.TimeStartPicker.Location = new System.Drawing.Point(80, 73);
            this.TimeStartPicker.Name = "TimeStartPicker";
            this.TimeStartPicker.Size = new System.Drawing.Size(65, 20);
            this.TimeStartPicker.TabIndex = 9;
            // 
            // TimeEndPicker
            // 
            this.TimeEndPicker.Location = new System.Drawing.Point(209, 73);
            this.TimeEndPicker.Name = "TimeEndPicker";
            this.TimeEndPicker.Size = new System.Drawing.Size(65, 20);
            this.TimeEndPicker.TabIndex = 10;
            // 
            // DV_PracownicyBox
            // 
            this.DV_PracownicyBox.AutoCompleteMode = global::MyCinemaPlanner.Properties.Settings.Default.auto;
            this.DV_PracownicyBox.AutoCompleteSource = global::MyCinemaPlanner.Properties.Settings.Default.autolist;
            this.DV_PracownicyBox.DataBindings.Add(new System.Windows.Forms.Binding("AutoCompleteMode", global::MyCinemaPlanner.Properties.Settings.Default, "auto", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DV_PracownicyBox.DataBindings.Add(new System.Windows.Forms.Binding("AutoCompleteSource", global::MyCinemaPlanner.Properties.Settings.Default, "autolist", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DV_PracownicyBox.FormattingEnabled = true;
            this.DV_PracownicyBox.Location = new System.Drawing.Point(80, 18);
            this.DV_PracownicyBox.Name = "DV_PracownicyBox";
            this.DV_PracownicyBox.Size = new System.Drawing.Size(194, 21);
            this.DV_PracownicyBox.TabIndex = 4;
            // 
            // DV_DodajWpisButton
            // 
            this.DV_DodajWpisButton.Location = new System.Drawing.Point(547, 177);
            this.DV_DodajWpisButton.Name = "DV_DodajWpisButton";
            this.DV_DodajWpisButton.Size = new System.Drawing.Size(140, 66);
            this.DV_DodajWpisButton.TabIndex = 4;
            this.DV_DodajWpisButton.Text = "Dodaj Wpis";
            this.DV_DodajWpisButton.UseVisualStyleBackColor = true;
            this.DV_DodajWpisButton.Click += new System.EventHandler(this.DV_DodajWpisButton_Click);
            // 
            // DV_UsunWpisButton
            // 
            this.DV_UsunWpisButton.Location = new System.Drawing.Point(691, 177);
            this.DV_UsunWpisButton.Name = "DV_UsunWpisButton";
            this.DV_UsunWpisButton.Size = new System.Drawing.Size(140, 66);
            this.DV_UsunWpisButton.TabIndex = 5;
            this.DV_UsunWpisButton.Text = "Usuń Wpis";
            this.DV_UsunWpisButton.UseVisualStyleBackColor = true;
            this.DV_UsunWpisButton.Click += new System.EventHandler(this.DV_UsunWpisButton_Click);
            // 
            // DailyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.DV_UsunWpisButton);
            this.Controls.Add(this.DV_DodajWpisButton);
            this.Controls.Add(this.RecordGroupBox);
            this.Controls.Add(this.PokazButton);
            this.Controls.Add(this.dailyViewComboBox);
            this.Controls.Add(this.dailyViewMainGrid);
            this.Name = "DailyView";
            this.Size = new System.Drawing.Size(1320, 585);
            ((System.ComponentModel.ISupportInitialize)(this.dailyViewMainGrid)).EndInit();
            this.RecordGroupBox.ResumeLayout(false);
            this.RecordGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dailyViewMainGrid;
        private System.Windows.Forms.ComboBox dailyViewComboBox;
        private System.Windows.Forms.Button PokazButton;
        private System.Windows.Forms.GroupBox RecordGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DV_SalaKasaBox;
        private System.Windows.Forms.ComboBox DV_PracownicyBox;
        private System.Windows.Forms.DateTimePicker DV_DatePicker;
        private System.Windows.Forms.DateTimePicker TimeEndPicker;
        private System.Windows.Forms.DateTimePicker TimeStartPicker;
        private System.Windows.Forms.Button DV_DodajWpisButton;
        private System.Windows.Forms.Button DV_UsunWpisButton;
    }
}
