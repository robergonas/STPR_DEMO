namespace STPR_UI
{
    partial class frmGenerarCita
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
            this.lblDatosPacienteGenerar = new System.Windows.Forms.Label();
            this.cbTratamiento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCerrarNotificacion = new System.Windows.Forms.Button();
            this.btnGenerarCita = new System.Windows.Forms.Button();
            this.chkCorreo = new System.Windows.Forms.CheckBox();
            this.chkMultimedia = new System.Windows.Forms.CheckBox();
            this.chkSMS = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblDatosPacienteGenerar
            // 
            this.lblDatosPacienteGenerar.AutoSize = true;
            this.lblDatosPacienteGenerar.Font = new System.Drawing.Font("Roboto Condensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosPacienteGenerar.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblDatosPacienteGenerar.Location = new System.Drawing.Point(12, 9);
            this.lblDatosPacienteGenerar.Name = "lblDatosPacienteGenerar";
            this.lblDatosPacienteGenerar.Size = new System.Drawing.Size(151, 17);
            this.lblDatosPacienteGenerar.TabIndex = 1;
            this.lblDatosPacienteGenerar.Text = "lblDatosPacienteGenerar";
            // 
            // cbTratamiento
            // 
            this.cbTratamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTratamiento.FormattingEnabled = true;
            this.cbTratamiento.Location = new System.Drawing.Point(94, 33);
            this.cbTratamiento.Name = "cbTratamiento";
            this.cbTratamiento.Size = new System.Drawing.Size(374, 23);
            this.cbTratamiento.TabIndex = 14;
            this.cbTratamiento.SelectedIndexChanged += new System.EventHandler(this.cbTratamiento_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tratamiento";
            // 
            // btnCerrarNotificacion
            // 
            this.btnCerrarNotificacion.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCerrarNotificacion.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarNotificacion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarNotificacion.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrarNotificacion.Location = new System.Drawing.Point(355, 84);
            this.btnCerrarNotificacion.Name = "btnCerrarNotificacion";
            this.btnCerrarNotificacion.Size = new System.Drawing.Size(113, 42);
            this.btnCerrarNotificacion.TabIndex = 16;
            this.btnCerrarNotificacion.Text = "cerrar";
            this.btnCerrarNotificacion.UseVisualStyleBackColor = false;
            this.btnCerrarNotificacion.Click += new System.EventHandler(this.btnCerrarNotificacion_Click);
            // 
            // btnGenerarCita
            // 
            this.btnGenerarCita.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGenerarCita.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarCita.ForeColor = System.Drawing.Color.White;
            this.btnGenerarCita.Location = new System.Drawing.Point(236, 84);
            this.btnGenerarCita.Name = "btnGenerarCita";
            this.btnGenerarCita.Size = new System.Drawing.Size(113, 42);
            this.btnGenerarCita.TabIndex = 15;
            this.btnGenerarCita.Text = "Generar";
            this.btnGenerarCita.UseVisualStyleBackColor = false;
            this.btnGenerarCita.Click += new System.EventHandler(this.btnGenerarCita_Click);
            // 
            // chkCorreo
            // 
            this.chkCorreo.AutoSize = true;
            this.chkCorreo.Location = new System.Drawing.Point(164, 101);
            this.chkCorreo.Name = "chkCorreo";
            this.chkCorreo.Size = new System.Drawing.Size(64, 21);
            this.chkCorreo.TabIndex = 19;
            this.chkCorreo.Text = "Correo";
            this.chkCorreo.UseVisualStyleBackColor = true;
            // 
            // chkMultimedia
            // 
            this.chkMultimedia.AutoSize = true;
            this.chkMultimedia.Location = new System.Drawing.Point(70, 100);
            this.chkMultimedia.Name = "chkMultimedia";
            this.chkMultimedia.Size = new System.Drawing.Size(90, 21);
            this.chkMultimedia.TabIndex = 18;
            this.chkMultimedia.Text = "Multimedia";
            this.chkMultimedia.UseVisualStyleBackColor = true;
            // 
            // chkSMS
            // 
            this.chkSMS.AutoSize = true;
            this.chkSMS.Location = new System.Drawing.Point(12, 101);
            this.chkSMS.Name = "chkSMS";
            this.chkSMS.Size = new System.Drawing.Size(52, 21);
            this.chkSMS.TabIndex = 17;
            this.chkSMS.Text = "SMS";
            this.chkSMS.UseVisualStyleBackColor = true;
            // 
            // frmGenerarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(480, 138);
            this.ControlBox = false;
            this.Controls.Add(this.chkCorreo);
            this.Controls.Add(this.chkMultimedia);
            this.Controls.Add(this.chkSMS);
            this.Controls.Add(this.btnCerrarNotificacion);
            this.Controls.Add(this.btnGenerarCita);
            this.Controls.Add(this.cbTratamiento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblDatosPacienteGenerar);
            this.Font = new System.Drawing.Font("Roboto Condensed", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmGenerarCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "*** Generar Cita Automática ***";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatosPacienteGenerar;
        private System.Windows.Forms.ComboBox cbTratamiento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCerrarNotificacion;
        private System.Windows.Forms.Button btnGenerarCita;
        private System.Windows.Forms.CheckBox chkCorreo;
        private System.Windows.Forms.CheckBox chkMultimedia;
        private System.Windows.Forms.CheckBox chkSMS;
    }
}