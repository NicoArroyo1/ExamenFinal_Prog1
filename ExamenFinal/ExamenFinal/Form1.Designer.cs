﻿namespace ExamenFinal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.txtHistoriaClinica = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblHistClinica = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblObraSocial = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.cbObraSocial = new System.Windows.Forms.ComboBox();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.ckbObraSocial = new System.Windows.Forms.CheckBox();
            this.lbPacientes = new System.Windows.Forms.ListBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbDatos.SuspendLayout();
            this.gbListado.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.dtpFechaNac);
            this.gbDatos.Controls.Add(this.ckbObraSocial);
            this.gbDatos.Controls.Add(this.rbMasculino);
            this.gbDatos.Controls.Add(this.rbFemenino);
            this.gbDatos.Controls.Add(this.cbObraSocial);
            this.gbDatos.Controls.Add(this.lblFechaNac);
            this.gbDatos.Controls.Add(this.lblSexo);
            this.gbDatos.Controls.Add(this.lblObraSocial);
            this.gbDatos.Controls.Add(this.lblNombre);
            this.gbDatos.Controls.Add(this.lblHistClinica);
            this.gbDatos.Controls.Add(this.txtNombre);
            this.gbDatos.Controls.Add(this.txtHistoriaClinica);
            this.gbDatos.Location = new System.Drawing.Point(12, 12);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(400, 287);
            this.gbDatos.TabIndex = 0;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos del Paciente";
            // 
            // gbListado
            // 
            this.gbListado.Controls.Add(this.lbPacientes);
            this.gbListado.Location = new System.Drawing.Point(418, 12);
            this.gbListado.Name = "gbListado";
            this.gbListado.Size = new System.Drawing.Size(400, 287);
            this.gbListado.TabIndex = 1;
            this.gbListado.TabStop = false;
            this.gbListado.Text = "Listado de Pacientes";
            // 
            // txtHistoriaClinica
            // 
            this.txtHistoriaClinica.Location = new System.Drawing.Point(120, 53);
            this.txtHistoriaClinica.Name = "txtHistoriaClinica";
            this.txtHistoriaClinica.Size = new System.Drawing.Size(82, 23);
            this.txtHistoriaClinica.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(120, 95);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(262, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // lblHistClinica
            // 
            this.lblHistClinica.AutoSize = true;
            this.lblHistClinica.Location = new System.Drawing.Point(10, 56);
            this.lblHistClinica.Name = "lblHistClinica";
            this.lblHistClinica.Size = new System.Drawing.Size(104, 15);
            this.lblHistClinica.TabIndex = 2;
            this.lblHistClinica.Text = "Historia Clinica N°";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(63, 98);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblObraSocial
            // 
            this.lblObraSocial.AutoSize = true;
            this.lblObraSocial.Location = new System.Drawing.Point(47, 138);
            this.lblObraSocial.Name = "lblObraSocial";
            this.lblObraSocial.Size = new System.Drawing.Size(67, 15);
            this.lblObraSocial.TabIndex = 4;
            this.lblObraSocial.Text = "Obra Social";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(82, 179);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(32, 15);
            this.lblSexo.TabIndex = 5;
            this.lblSexo.Text = "Sexo";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(11, 218);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(103, 15);
            this.lblFechaNac.TabIndex = 6;
            this.lblFechaNac.Text = "Fecha Nacimiento";
            // 
            // cbObraSocial
            // 
            this.cbObraSocial.FormattingEnabled = true;
            this.cbObraSocial.Location = new System.Drawing.Point(159, 135);
            this.cbObraSocial.Name = "cbObraSocial";
            this.cbObraSocial.Size = new System.Drawing.Size(223, 23);
            this.cbObraSocial.TabIndex = 7;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(120, 179);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(92, 19);
            this.rbFemenino.TabIndex = 8;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "1- Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(220, 179);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(94, 19);
            this.rbMasculino.TabIndex = 9;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "2- Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // ckbObraSocial
            // 
            this.ckbObraSocial.AutoSize = true;
            this.ckbObraSocial.Location = new System.Drawing.Point(120, 139);
            this.ckbObraSocial.Name = "ckbObraSocial";
            this.ckbObraSocial.Size = new System.Drawing.Size(15, 14);
            this.ckbObraSocial.TabIndex = 10;
            this.ckbObraSocial.UseVisualStyleBackColor = true;
            // 
            // lbPacientes
            // 
            this.lbPacientes.FormattingEnabled = true;
            this.lbPacientes.ItemHeight = 15;
            this.lbPacientes.Location = new System.Drawing.Point(6, 22);
            this.lbPacientes.Name = "lbPacientes";
            this.lbPacientes.Size = new System.Drawing.Size(385, 259);
            this.lbPacientes.TabIndex = 0;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(120, 212);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(110, 23);
            this.dtpFechaNac.TabIndex = 11;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(12, 322);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(170, 59);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo Paciente";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(188, 322);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(170, 59);
            this.btnGrabar.TabIndex = 3;
            this.btnGrabar.Text = "Grabar Paciente";
            this.btnGrabar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(648, 322);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(170, 59);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 390);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.gbDatos);
            this.Name = "Form1";
            this.Text = "Pacientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.gbListado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbDatos;
        private DateTimePicker dtpFechaNac;
        private CheckBox ckbObraSocial;
        private RadioButton rbMasculino;
        private RadioButton rbFemenino;
        private ComboBox cbObraSocial;
        private Label lblFechaNac;
        private Label lblSexo;
        private Label lblObraSocial;
        private Label lblNombre;
        private Label lblHistClinica;
        private TextBox txtNombre;
        private TextBox txtHistoriaClinica;
        private GroupBox gbListado;
        private ListBox lbPacientes;
        private Button btnNuevo;
        private Button btnGrabar;
        private Button btnSalir;
    }
}