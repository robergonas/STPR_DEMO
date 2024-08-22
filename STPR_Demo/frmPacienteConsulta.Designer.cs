namespace STPR_UI
{
    partial class frmPacienteConsulta
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvPaciente = new System.Windows.Forms.DataGridView();
            this.lblDatosPaciente = new System.Windows.Forms.Label();
            this.gbNotificacion = new System.Windows.Forms.GroupBox();
            this.chkCorreo = new System.Windows.Forms.CheckBox();
            this.chkMultimedia = new System.Windows.Forms.CheckBox();
            this.chkSMS = new System.Windows.Forms.CheckBox();
            this.cbTratamiento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCerrarNotificacion = new System.Windows.Forms.Button();
            this.btnNotificacion = new System.Windows.Forms.Button();
            this.txtNotificacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDatosPacienteNotificacion = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPaciente)).BeginInit();
            this.gbNotificacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DodgerBlue;
            this.label4.Font = new System.Drawing.Font("Roboto Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(310, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(381, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "Búsqueda y Consulta de Pacientes";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCerrar.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrar.Location = new System.Drawing.Point(814, 460);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(113, 42);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtDNI
            // 
            this.txtDNI.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.Location = new System.Drawing.Point(44, 24);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 23);
            this.txtDNI.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(211, 24);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(173, 23);
            this.txtNombre.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(405, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(154, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(468, 24);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(181, 23);
            this.txtApellidos.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtDNI);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(926, 66);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // dtgvPaciente
            // 
            this.dtgvPaciente.BackgroundColor = System.Drawing.SystemColors.ControlText;
            this.dtgvPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPaciente.Location = new System.Drawing.Point(12, 133);
            this.dtgvPaciente.Name = "dtgvPaciente";
            this.dtgvPaciente.Size = new System.Drawing.Size(927, 321);
            this.dtgvPaciente.TabIndex = 8;
            this.dtgvPaciente.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvPaciente_CellMouseDown);
            this.dtgvPaciente.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dtgvPaciente_DataBindingComplete);
            // 
            // lblDatosPaciente
            // 
            this.lblDatosPaciente.AutoSize = true;
            this.lblDatosPaciente.Font = new System.Drawing.Font("Roboto Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosPaciente.ForeColor = System.Drawing.Color.White;
            this.lblDatosPaciente.Location = new System.Drawing.Point(9, 485);
            this.lblDatosPaciente.Name = "lblDatosPaciente";
            this.lblDatosPaciente.Size = new System.Drawing.Size(0, 17);
            this.lblDatosPaciente.TabIndex = 9;
            // 
            // gbNotificacion
            // 
            this.gbNotificacion.Controls.Add(this.chkCorreo);
            this.gbNotificacion.Controls.Add(this.chkMultimedia);
            this.gbNotificacion.Controls.Add(this.chkSMS);
            this.gbNotificacion.Controls.Add(this.cbTratamiento);
            this.gbNotificacion.Controls.Add(this.label6);
            this.gbNotificacion.Controls.Add(this.btnCerrarNotificacion);
            this.gbNotificacion.Controls.Add(this.btnNotificacion);
            this.gbNotificacion.Controls.Add(this.txtNotificacion);
            this.gbNotificacion.Controls.Add(this.label5);
            this.gbNotificacion.Controls.Add(this.lblDatosPacienteNotificacion);
            this.gbNotificacion.Font = new System.Drawing.Font("Roboto Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNotificacion.ForeColor = System.Drawing.Color.White;
            this.gbNotificacion.Location = new System.Drawing.Point(189, -15);
            this.gbNotificacion.Name = "gbNotificacion";
            this.gbNotificacion.Size = new System.Drawing.Size(595, 517);
            this.gbNotificacion.TabIndex = 10;
            this.gbNotificacion.TabStop = false;
            this.gbNotificacion.Text = "Notificación";
            // 
            // chkCorreo
            // 
            this.chkCorreo.AutoSize = true;
            this.chkCorreo.Location = new System.Drawing.Point(174, 476);
            this.chkCorreo.Name = "chkCorreo";
            this.chkCorreo.Size = new System.Drawing.Size(64, 21);
            this.chkCorreo.TabIndex = 15;
            this.chkCorreo.Text = "Correo";
            this.chkCorreo.UseVisualStyleBackColor = true;
            // 
            // chkMultimedia
            // 
            this.chkMultimedia.AutoSize = true;
            this.chkMultimedia.Location = new System.Drawing.Point(80, 475);
            this.chkMultimedia.Name = "chkMultimedia";
            this.chkMultimedia.Size = new System.Drawing.Size(90, 21);
            this.chkMultimedia.TabIndex = 14;
            this.chkMultimedia.Text = "Multimedia";
            this.chkMultimedia.UseVisualStyleBackColor = true;
            // 
            // chkSMS
            // 
            this.chkSMS.AutoSize = true;
            this.chkSMS.Location = new System.Drawing.Point(22, 476);
            this.chkSMS.Name = "chkSMS";
            this.chkSMS.Size = new System.Drawing.Size(52, 21);
            this.chkSMS.TabIndex = 13;
            this.chkSMS.Text = "SMS";
            this.chkSMS.UseVisualStyleBackColor = true;
            // 
            // cbTratamiento
            // 
            this.cbTratamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTratamiento.FormattingEnabled = true;
            this.cbTratamiento.Location = new System.Drawing.Point(101, 47);
            this.cbTratamiento.Name = "cbTratamiento";
            this.cbTratamiento.Size = new System.Drawing.Size(301, 23);
            this.cbTratamiento.TabIndex = 12;
            this.cbTratamiento.SelectedIndexChanged += new System.EventHandler(this.cbTratamiento_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tratamiento";
            // 
            // btnCerrarNotificacion
            // 
            this.btnCerrarNotificacion.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCerrarNotificacion.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarNotificacion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarNotificacion.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrarNotificacion.Location = new System.Drawing.Point(461, 465);
            this.btnCerrarNotificacion.Name = "btnCerrarNotificacion";
            this.btnCerrarNotificacion.Size = new System.Drawing.Size(113, 42);
            this.btnCerrarNotificacion.TabIndex = 9;
            this.btnCerrarNotificacion.Text = "cerrar";
            this.btnCerrarNotificacion.UseVisualStyleBackColor = false;
            this.btnCerrarNotificacion.Click += new System.EventHandler(this.btnCerrarNotificacion_Click);
            // 
            // btnNotificacion
            // 
            this.btnNotificacion.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNotificacion.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotificacion.ForeColor = System.Drawing.Color.White;
            this.btnNotificacion.Location = new System.Drawing.Point(342, 465);
            this.btnNotificacion.Name = "btnNotificacion";
            this.btnNotificacion.Size = new System.Drawing.Size(113, 42);
            this.btnNotificacion.TabIndex = 8;
            this.btnNotificacion.Text = "Notificar";
            this.btnNotificacion.UseVisualStyleBackColor = false;
            this.btnNotificacion.Click += new System.EventHandler(this.btnNotificacion_Click);
            // 
            // txtNotificacion
            // 
            this.txtNotificacion.Location = new System.Drawing.Point(22, 101);
            this.txtNotificacion.Multiline = true;
            this.txtNotificacion.Name = "txtNotificacion";
            this.txtNotificacion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNotificacion.Size = new System.Drawing.Size(552, 358);
            this.txtNotificacion.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mensaje";
            // 
            // lblDatosPacienteNotificacion
            // 
            this.lblDatosPacienteNotificacion.AutoSize = true;
            this.lblDatosPacienteNotificacion.Font = new System.Drawing.Font("Roboto Condensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosPacienteNotificacion.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblDatosPacienteNotificacion.Location = new System.Drawing.Point(19, 22);
            this.lblDatosPacienteNotificacion.Name = "lblDatosPacienteNotificacion";
            this.lblDatosPacienteNotificacion.Size = new System.Drawing.Size(174, 17);
            this.lblDatosPacienteNotificacion.TabIndex = 0;
            this.lblDatosPacienteNotificacion.Text = "lblDatosPacienteNotificacion";
            // 
            // frmPacienteConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(950, 511);
            this.ControlBox = false;
            this.Controls.Add(this.gbNotificacion);
            this.Controls.Add(this.lblDatosPaciente);
            this.Controls.Add(this.dtgvPaciente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label4);
            this.Name = "frmPacienteConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "..::: Consulta Paciente :::..";
            this.Load += new System.EventHandler(this.frmPacienteConsulta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPaciente)).EndInit();
            this.gbNotificacion.ResumeLayout(false);
            this.gbNotificacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvPaciente;
        private System.Windows.Forms.Label lblDatosPaciente;
        private System.Windows.Forms.GroupBox gbNotificacion;
        private System.Windows.Forms.Button btnNotificacion;
        private System.Windows.Forms.TextBox txtNotificacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDatosPacienteNotificacion;
        private System.Windows.Forms.Button btnCerrarNotificacion;
        private System.Windows.Forms.ComboBox cbTratamiento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkCorreo;
        private System.Windows.Forms.CheckBox chkMultimedia;
        private System.Windows.Forms.CheckBox chkSMS;
    }
}