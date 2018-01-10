namespace MyCinemaPlanner
{
    partial class Repertoire
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
            this.RepertoiredataGridView = new System.Windows.Forms.DataGridView();
            this.RepertoiredateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Raportbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RepertoiredataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // RepertoiredataGridView
            // 
            this.RepertoiredataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RepertoiredataGridView.Location = new System.Drawing.Point(139, 44);
            this.RepertoiredataGridView.Name = "RepertoiredataGridView";
            this.RepertoiredataGridView.Size = new System.Drawing.Size(1040, 614);
            this.RepertoiredataGridView.TabIndex = 0;
            // 
            // RepertoiredateTimePicker
            // 
            this.RepertoiredateTimePicker.Location = new System.Drawing.Point(612, 18);
            this.RepertoiredateTimePicker.Name = "RepertoiredateTimePicker";
            this.RepertoiredateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.RepertoiredateTimePicker.TabIndex = 1;
            this.RepertoiredateTimePicker.ValueChanged += new System.EventHandler(this.RepertoiredateTimePicker_ValueChanged);
            // 
            // Raportbutton
            // 
            this.Raportbutton.Location = new System.Drawing.Point(410, 15);
            this.Raportbutton.Name = "Raportbutton";
            this.Raportbutton.Size = new System.Drawing.Size(125, 23);
            this.Raportbutton.TabIndex = 2;
            this.Raportbutton.Text = "Create raport";
            this.Raportbutton.UseVisualStyleBackColor = true;
            this.Raportbutton.Click += new System.EventHandler(this.Raportbutton_Click);
            // 
            // Repertoire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.Raportbutton);
            this.Controls.Add(this.RepertoiredateTimePicker);
            this.Controls.Add(this.RepertoiredataGridView);
            this.Name = "Repertoire";
            this.Size = new System.Drawing.Size(1313, 670);
            ((System.ComponentModel.ISupportInitialize)(this.RepertoiredataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView RepertoiredataGridView;
        private System.Windows.Forms.DateTimePicker RepertoiredateTimePicker;
        private System.Windows.Forms.Button Raportbutton;
    }
}
