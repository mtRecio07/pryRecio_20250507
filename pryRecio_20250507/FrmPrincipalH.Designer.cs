namespace pryRecio_20250507
{
    partial class FrmPrincipalH
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
            this.comboBoxNombres = new System.Windows.Forms.ComboBox();
            this.pictureBoxImagen = new System.Windows.Forms.PictureBox();
            this.numericUDDestreza = new System.Windows.Forms.NumericUpDown();
            this.numericUDFuerza = new System.Windows.Forms.NumericUpDown();
            this.btnCrear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDDestreza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDFuerza)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxNombres
            // 
            this.comboBoxNombres.FormattingEnabled = true;
            this.comboBoxNombres.Location = new System.Drawing.Point(162, 42);
            this.comboBoxNombres.Name = "comboBoxNombres";
            this.comboBoxNombres.Size = new System.Drawing.Size(169, 21);
            this.comboBoxNombres.TabIndex = 0;
            this.comboBoxNombres.SelectedIndexChanged += new System.EventHandler(this.comboBoxNombres_SelectedIndexChanged);
            // 
            // pictureBoxImagen
            // 
            this.pictureBoxImagen.Location = new System.Drawing.Point(59, 100);
            this.pictureBoxImagen.Name = "pictureBoxImagen";
            this.pictureBoxImagen.Size = new System.Drawing.Size(387, 185);
            this.pictureBoxImagen.TabIndex = 1;
            this.pictureBoxImagen.TabStop = false;
            // 
            // numericUDDestreza
            // 
            this.numericUDDestreza.Location = new System.Drawing.Point(126, 87);
            this.numericUDDestreza.Name = "numericUDDestreza";
            this.numericUDDestreza.Size = new System.Drawing.Size(120, 20);
            this.numericUDDestreza.TabIndex = 3;
            // 
            // numericUDFuerza
            // 
            this.numericUDFuerza.Location = new System.Drawing.Point(126, 36);
            this.numericUDFuerza.Name = "numericUDFuerza";
            this.numericUDFuerza.Size = new System.Drawing.Size(116, 20);
            this.numericUDFuerza.TabIndex = 4;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(126, 138);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(120, 29);
            this.btnCrear.TabIndex = 5;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnCrear);
            this.groupBox1.Controls.Add(this.numericUDDestreza);
            this.groupBox1.Controls.Add(this.numericUDFuerza);
            this.groupBox1.Location = new System.Drawing.Point(482, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 185);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CrearArchivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Destreza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fuerza";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seleccionar PJ:";
            // 
            // FrmPrincipalH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(793, 531);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxImagen);
            this.Controls.Add(this.comboBoxNombres);
            this.Name = "FrmPrincipalH";
            this.Text = "FrmPrincipalH";
            this.Load += new System.EventHandler(this.FrmPrincipalH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDDestreza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDFuerza)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxNombres;
        private System.Windows.Forms.PictureBox pictureBoxImagen;
        private System.Windows.Forms.NumericUpDown numericUDDestreza;
        private System.Windows.Forms.NumericUpDown numericUDFuerza;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}