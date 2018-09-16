namespace CotizacionArticulo.UI
{
    partial class ConsultasArticulo
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.FiltrocomboBox = new System.Windows.Forms.ComboBox();
            this.Desde = new System.Windows.Forms.Label();
            this.DesdedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label = new System.Windows.Forms.Label();
            this.CristeriotextBox = new System.Windows.Forms.TextBox();
            this.Hasta = new System.Windows.Forms.Label();
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Burcarbutton = new System.Windows.Forms.Button();
            this.ConsultasdataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultasdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtro";
            // 
            // FiltrocomboBox
            // 
            this.FiltrocomboBox.FormattingEnabled = true;
            this.FiltrocomboBox.Location = new System.Drawing.Point(105, 40);
            this.FiltrocomboBox.Name = "FiltrocomboBox";
            this.FiltrocomboBox.Size = new System.Drawing.Size(208, 24);
            this.FiltrocomboBox.TabIndex = 1;
            // 
            // Desde
            // 
            this.Desde.AutoSize = true;
            this.Desde.Location = new System.Drawing.Point(40, 108);
            this.Desde.Name = "Desde";
            this.Desde.Size = new System.Drawing.Size(49, 17);
            this.Desde.TabIndex = 2;
            this.Desde.Text = "Desde";
            // 
            // DesdedateTimePicker
            // 
            this.DesdedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DesdedateTimePicker.Location = new System.Drawing.Point(105, 103);
            this.DesdedateTimePicker.Name = "DesdedateTimePicker";
            this.DesdedateTimePicker.Size = new System.Drawing.Size(208, 22);
            this.DesdedateTimePicker.TabIndex = 3;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(360, 47);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(60, 17);
            this.label.TabIndex = 4;
            this.label.Text = "Cristerio";
            // 
            // CristeriotextBox
            // 
            this.CristeriotextBox.Location = new System.Drawing.Point(447, 47);
            this.CristeriotextBox.Name = "CristeriotextBox";
            this.CristeriotextBox.Size = new System.Drawing.Size(200, 22);
            this.CristeriotextBox.TabIndex = 5;
            // 
            // Hasta
            // 
            this.Hasta.AutoSize = true;
            this.Hasta.Location = new System.Drawing.Point(375, 103);
            this.Hasta.Name = "Hasta";
            this.Hasta.Size = new System.Drawing.Size(45, 17);
            this.Hasta.TabIndex = 6;
            this.Hasta.Text = "Hasta";
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.Location = new System.Drawing.Point(447, 103);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.HastadateTimePicker.TabIndex = 7;
            // 
            // Burcarbutton
            // 
            this.Burcarbutton.Location = new System.Drawing.Point(665, 47);
            this.Burcarbutton.Name = "Burcarbutton";
            this.Burcarbutton.Size = new System.Drawing.Size(85, 43);
            this.Burcarbutton.TabIndex = 8;
            this.Burcarbutton.Text = "Buscar";
            this.Burcarbutton.UseVisualStyleBackColor = true;
            this.Burcarbutton.Click += new System.EventHandler(this.Burcarbutton_Click);
            // 
            // ConsultasdataGridView
            // 
            this.ConsultasdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultasdataGridView.Location = new System.Drawing.Point(52, 152);
            this.ConsultasdataGridView.Name = "ConsultasdataGridView";
            this.ConsultasdataGridView.RowTemplate.Height = 24;
            this.ConsultasdataGridView.Size = new System.Drawing.Size(698, 265);
            this.ConsultasdataGridView.TabIndex = 9;
            // 
            // ConsultasArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConsultasdataGridView);
            this.Controls.Add(this.Burcarbutton);
            this.Controls.Add(this.HastadateTimePicker);
            this.Controls.Add(this.Hasta);
            this.Controls.Add(this.CristeriotextBox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.DesdedateTimePicker);
            this.Controls.Add(this.Desde);
            this.Controls.Add(this.FiltrocomboBox);
            this.Controls.Add(this.label1);
            this.Name = "ConsultasArticulo";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultasdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FiltrocomboBox;
        private System.Windows.Forms.Label Desde;
        private System.Windows.Forms.DateTimePicker DesdedateTimePicker;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox CristeriotextBox;
        private System.Windows.Forms.Label Hasta;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
        private System.Windows.Forms.Button Burcarbutton;
        private System.Windows.Forms.DataGridView ConsultasdataGridView;
    }
}