namespace STPR_UI
{
    partial class frmAfiliacionSTPR
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
            this.lblDatosPaciente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.txtAdicional = new System.Windows.Forms.TextBox();
            this.txtHoraReferencia = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnafiliacion_STPR = new System.Windows.Forms.Button();
            this.gbMedioComunicacion = new System.Windows.Forms.GroupBox();
            this.chkCorreo = new System.Windows.Forms.CheckBox();
            this.chkWSP = new System.Windows.Forms.CheckBox();
            this.chkSMS = new System.Windows.Forms.CheckBox();
            this.gbMedioComunicacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDatosPaciente
            // 
            this.lblDatosPaciente.AutoSize = true;
            this.lblDatosPaciente.Location = new System.Drawing.Point(15, 16);
            this.lblDatosPaciente.Name = "lblDatosPaciente";
            this.lblDatosPaciente.Size = new System.Drawing.Size(51, 15);
            this.lblDatosPaciente.TabIndex = 0;
            this.lblDatosPaciente.Text = "Paciente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Distancia (24 horas):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dia(s) adicional:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hora Referencia (24 horas):";
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(168, 46);
            this.txtDistancia.MaxLength = 2;
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(100, 23);
            this.txtDistancia.TabIndex = 4;
            // 
            // txtAdicional
            // 
            this.txtAdicional.Location = new System.Drawing.Point(168, 78);
            this.txtAdicional.Name = "txtAdicional";
            this.txtAdicional.Size = new System.Drawing.Size(100, 23);
            this.txtAdicional.TabIndex = 5;
            // 
            // txtHoraReferencia
            // 
            this.txtHoraReferencia.Location = new System.Drawing.Point(168, 107);
            this.txtHoraReferencia.Name = "txtHoraReferencia";
            this.txtHoraReferencia.Size = new System.Drawing.Size(100, 23);
            this.txtHoraReferencia.TabIndex = 6;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCerrar.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrar.Location = new System.Drawing.Point(187, 205);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(113, 42);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(143, -243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "Afiliar STPR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnafiliacion_STPR
            // 
            this.btnafiliacion_STPR.BackColor = System.Drawing.Color.SeaGreen;
            this.btnafiliacion_STPR.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnafiliacion_STPR.ForeColor = System.Drawing.Color.White;
            this.btnafiliacion_STPR.Location = new System.Drawing.Point(68, 205);
            this.btnafiliacion_STPR.Name = "btnafiliacion_STPR";
            this.btnafiliacion_STPR.Size = new System.Drawing.Size(113, 42);
            this.btnafiliacion_STPR.TabIndex = 10;
            this.btnafiliacion_STPR.Text = "Afiliar STPR";
            this.btnafiliacion_STPR.UseVisualStyleBackColor = false;
            this.btnafiliacion_STPR.Click += new System.EventHandler(this.btnAfiliacion_STPR_Click);
            // 
            // gbMedioComunicacion
            // 
            this.gbMedioComunicacion.Controls.Add(this.chkCorreo);
            this.gbMedioComunicacion.Controls.Add(this.chkWSP);
            this.gbMedioComunicacion.Controls.Add(this.chkSMS);
            this.gbMedioComunicacion.ForeColor = System.Drawing.Color.White;
            this.gbMedioComunicacion.Location = new System.Drawing.Point(18, 149);
            this.gbMedioComunicacion.Name = "gbMedioComunicacion";
            this.gbMedioComunicacion.Size = new System.Drawing.Size(265, 50);
            this.gbMedioComunicacion.TabIndex = 12;
            this.gbMedioComunicacion.TabStop = false;
            this.gbMedioComunicacion.Text = "Medio de comunicación";
            // 
            // chkCorreo
            // 
            this.chkCorreo.AutoSize = true;
            this.chkCorreo.Location = new System.Drawing.Point(188, 16);
            this.chkCorreo.Name = "chkCorreo";
            this.chkCorreo.Size = new System.Drawing.Size(61, 19);
            this.chkCorreo.TabIndex = 5;
            this.chkCorreo.Text = "Correo";
            this.chkCorreo.UseVisualStyleBackColor = true;
            // 
            // chkWSP
            // 
            this.chkWSP.AutoSize = true;
            this.chkWSP.Location = new System.Drawing.Point(87, 16);
            this.chkWSP.Name = "chkWSP";
            this.chkWSP.Size = new System.Drawing.Size(83, 19);
            this.chkWSP.TabIndex = 4;
            this.chkWSP.Text = "Multimedia";
            this.chkWSP.UseVisualStyleBackColor = true;
            // 
            // chkSMS
            // 
            this.chkSMS.AutoSize = true;
            this.chkSMS.Location = new System.Drawing.Point(15, 16);
            this.chkSMS.Name = "chkSMS";
            this.chkSMS.Size = new System.Drawing.Size(50, 19);
            this.chkSMS.TabIndex = 3;
            this.chkSMS.Text = "SMS";
            this.chkSMS.UseVisualStyleBackColor = true;
            // 
            // frmAfiliacionSTPR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(306, 261);
            this.ControlBox = false;
            this.Controls.Add(this.gbMedioComunicacion);
            this.Controls.Add(this.btnafiliacion_STPR);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtHoraReferencia);
            this.Controls.Add(this.txtAdicional);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDatosPaciente);
            this.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmAfiliacionSTPR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "..::: Afiliación STPR :::..";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAfiliacionSTPR_FormClosed);
            this.gbMedioComunicacion.ResumeLayout(false);
            this.gbMedioComunicacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblDatosPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.TextBox txtAdicional;
        private System.Windows.Forms.TextBox txtHoraReferencia;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnafiliacion_STPR;
        private System.Windows.Forms.GroupBox gbMedioComunicacion;
        private System.Windows.Forms.CheckBox chkCorreo;
        private System.Windows.Forms.CheckBox chkWSP;
        private System.Windows.Forms.CheckBox chkSMS;
    }
}