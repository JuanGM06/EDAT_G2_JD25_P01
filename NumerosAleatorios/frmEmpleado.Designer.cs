namespace NumerosAleatorios
{
    partial class frmEmpleado
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
            Datos = new GroupBox();
            chkSeguroMedico = new CheckBox();
            txtSueldo = new TextBox();
            cmbGrupo = new ComboBox();
            lblSueldo = new Label();
            lblGrupo = new Label();
            rbtnFemenino = new RadioButton();
            rbtnMasculino = new RadioButton();
            dtpFechaNacimiento = new DateTimePicker();
            txtNombre = new TextBox();
            txtNumero = new TextBox();
            lblFecha = new Label();
            lblNumero = new Label();
            lblNombre = new Label();
            btnAleatorios = new Button();
            Datos.SuspendLayout();
            SuspendLayout();
            // 
            // Datos
            // 
            Datos.Controls.Add(chkSeguroMedico);
            Datos.Controls.Add(txtSueldo);
            Datos.Controls.Add(cmbGrupo);
            Datos.Controls.Add(lblSueldo);
            Datos.Controls.Add(lblGrupo);
            Datos.Controls.Add(rbtnFemenino);
            Datos.Controls.Add(rbtnMasculino);
            Datos.Controls.Add(dtpFechaNacimiento);
            Datos.Controls.Add(txtNombre);
            Datos.Controls.Add(txtNumero);
            Datos.Controls.Add(lblFecha);
            Datos.Controls.Add(lblNumero);
            Datos.Controls.Add(lblNombre);
            Datos.Location = new Point(34, 38);
            Datos.Name = "Datos";
            Datos.Size = new Size(493, 378);
            Datos.TabIndex = 0;
            Datos.TabStop = false;
            Datos.Text = "Datos del Empleado";
            Datos.Enter += gpbFecha_Enter;
            // 
            // chkSeguroMedico
            // 
            chkSeguroMedico.AutoSize = true;
            chkSeguroMedico.Location = new Point(65, 324);
            chkSeguroMedico.Name = "chkSeguroMedico";
            chkSeguroMedico.Size = new Size(132, 24);
            chkSeguroMedico.TabIndex = 12;
            chkSeguroMedico.Text = "Seguro Medico";
            chkSeguroMedico.UseVisualStyleBackColor = true;
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(65, 266);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(127, 27);
            txtSueldo.TabIndex = 11;
            // 
            // cmbGrupo
            // 
            cmbGrupo.FormattingEnabled = true;
            cmbGrupo.Location = new Point(65, 227);
            cmbGrupo.Name = "cmbGrupo";
            cmbGrupo.Size = new Size(102, 28);
            cmbGrupo.TabIndex = 10;
            // 
            // lblSueldo
            // 
            lblSueldo.AutoSize = true;
            lblSueldo.Location = new Point(6, 269);
            lblSueldo.Name = "lblSueldo";
            lblSueldo.Size = new Size(62, 20);
            lblSueldo.TabIndex = 9;
            lblSueldo.Text = "Sueldo: ";
            // 
            // lblGrupo
            // 
            lblGrupo.AutoSize = true;
            lblGrupo.Location = new Point(7, 230);
            lblGrupo.Name = "lblGrupo";
            lblGrupo.Size = new Size(57, 20);
            lblGrupo.TabIndex = 8;
            lblGrupo.Text = "Grupo: ";
            // 
            // rbtnFemenino
            // 
            rbtnFemenino.AutoSize = true;
            rbtnFemenino.Location = new Point(65, 188);
            rbtnFemenino.Name = "rbtnFemenino";
            rbtnFemenino.Size = new Size(95, 24);
            rbtnFemenino.TabIndex = 7;
            rbtnFemenino.TabStop = true;
            rbtnFemenino.Text = "Femenino";
            rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculino
            // 
            rbtnMasculino.AutoSize = true;
            rbtnMasculino.Location = new Point(65, 158);
            rbtnMasculino.Name = "rbtnMasculino";
            rbtnMasculino.Size = new Size(97, 24);
            rbtnMasculino.TabIndex = 6;
            rbtnMasculino.TabStop = true;
            rbtnMasculino.Text = "Masculino";
            rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(168, 121);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(319, 27);
            dtpFechaNacimiento.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(82, 84);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(405, 27);
            txtNombre.TabIndex = 4;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(82, 53);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(89, 27);
            txtNumero.TabIndex = 3;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(6, 126);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(156, 20);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha de Nacimiento: ";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(7, 56);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(70, 20);
            lblNumero.TabIndex = 1;
            lblNumero.Text = "Numero: ";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(6, 91);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre: ";
            // 
            // btnAleatorios
            // 
            btnAleatorios.Location = new Point(129, 434);
            btnAleatorios.Name = "btnAleatorios";
            btnAleatorios.Size = new Size(277, 49);
            btnAleatorios.TabIndex = 1;
            btnAleatorios.Text = "Generar Datos Aleatorios";
            btnAleatorios.UseVisualStyleBackColor = true;
            btnAleatorios.Click += btnAleatorios_Click;
            // 
            // frmEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 516);
            Controls.Add(btnAleatorios);
            Controls.Add(Datos);
            Name = "frmEmpleado";
            Text = "Empleado con Datos Aleatorios";
            Load += frmEmpleado_Load;
            Datos.ResumeLayout(false);
            Datos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Datos;
        private Label lblNombre;
        private Label lblNumero;
        private Label lblFecha;
        private TextBox txtNombre;
        private TextBox txtNumero;
        private DateTimePicker dtpFechaNacimiento;
        private TextBox txtSueldo;
        private ComboBox cmbGrupo;
        private Label lblSueldo;
        private Label lblGrupo;
        private RadioButton rbtnFemenino;
        private RadioButton rbtnMasculino;
        private CheckBox chkSeguroMedico;
        private Button btnAleatorios;
    }
}
