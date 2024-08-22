namespace STPR_UI
{
    partial class frmTratamiento
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
            this.lblDatosPaciente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMedico = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtFechaInicia = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbEspecialidad = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMedicacion = new System.Windows.Forms.TextBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtReaccion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paciente";
            // 
            // lblDatosPaciente
            // 
            this.lblDatosPaciente.AutoSize = true;
            this.lblDatosPaciente.Location = new System.Drawing.Point(100, 9);
            this.lblDatosPaciente.Name = "lblDatosPaciente";
            this.lblDatosPaciente.Size = new System.Drawing.Size(102, 17);
            this.lblDatosPaciente.TabIndex = 1;
            this.lblDatosPaciente.Text = "lblDatosPaciente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Médico";
            // 
            // cbMedico
            // 
            this.cbMedico.BackColor = System.Drawing.SystemColors.ControlText;
            this.cbMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedico.ForeColor = System.Drawing.Color.White;
            this.cbMedico.FormattingEnabled = true;
            this.cbMedico.Location = new System.Drawing.Point(96, 37);
            this.cbMedico.Name = "cbMedico";
            this.cbMedico.Size = new System.Drawing.Size(200, 23);
            this.cbMedico.TabIndex = 3;
            this.cbMedico.SelectedIndexChanged += new System.EventHandler(this.cbMedico_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha inicio";
            // 
            // dtFechaInicia
            // 
            this.dtFechaInicia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaInicia.Location = new System.Drawing.Point(96, 77);
            this.dtFechaInicia.Name = "dtFechaInicia";
            this.dtFechaInicia.Size = new System.Drawing.Size(200, 24);
            this.dtFechaInicia.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Especialidad";
            // 
            // cbEspecialidad
            // 
            this.cbEspecialidad.BackColor = System.Drawing.SystemColors.ControlText;
            this.cbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEspecialidad.ForeColor = System.Drawing.Color.White;
            this.cbEspecialidad.FormattingEnabled = true;
            this.cbEspecialidad.Location = new System.Drawing.Point(428, 37);
            this.cbEspecialidad.Name = "cbEspecialidad";
            this.cbEspecialidad.Size = new System.Drawing.Size(270, 23);
            this.cbEspecialidad.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnGuardar.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(466, 383);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(113, 42);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCerrar.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrar.Location = new System.Drawing.Point(585, 383);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(113, 42);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Diagnostico";
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Location = new System.Drawing.Point(96, 113);
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(602, 56);
            this.txtDiagnostico.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Medicación";
            // 
            // txtMedicacion
            // 
            this.txtMedicacion.Location = new System.Drawing.Point(96, 183);
            this.txtMedicacion.Multiline = true;
            this.txtMedicacion.Name = "txtMedicacion";
            this.txtMedicacion.Size = new System.Drawing.Size(602, 48);
            this.txtMedicacion.TabIndex = 13;
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(96, 321);
            this.txtNota.Multiline = true;
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(602, 48);
            this.txtNota.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Notas";
            // 
            // txtReaccion
            // 
            this.txtReaccion.Location = new System.Drawing.Point(96, 247);
            this.txtReaccion.Multiline = true;
            this.txtReaccion.Name = "txtReaccion";
            this.txtReaccion.Size = new System.Drawing.Size(602, 56);
            this.txtReaccion.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Reacciones";
            // 
            // frmTratamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(710, 433);
            this.ControlBox = false;
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtReaccion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMedicacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDiagnostico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbEspecialidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtFechaInicia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbMedico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDatosPaciente);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto Condensed", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmTratamiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "*** Tratamiento ***";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMedico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtFechaInicia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbEspecialidad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCerrar;
        public System.Windows.Forms.Label lblDatosPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMedicacion;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtReaccion;
        private System.Windows.Forms.Label label8;
    }
}