namespace NumerosAleatorios
{
    public partial class frmEmpleado : Form
    {
        Random rnd = new Random();
        string[] nombres = { "Jose", "Gabriel", "Juan", "Miguel", "Naomi", "Maria", "Nataly", "Lalo", "Pedro", "Ari", "Paola", "Diana" };

        public frmEmpleado()
        {
            InitializeComponent();

            cmbGrupo.Items.AddRange(new object[] { "A", "B", "C", "D", "E" });
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void btnAleatorios_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();

            empleado.Numero = rnd.Next(100, 999);
            empleado.Nombre = nombres[rnd.Next(nombres.Length)];
            empleado.FechaNacimiento = new DateTime(rnd.Next(1970, 2005), rnd.Next(1, 13), rnd.Next(1, 28));
            empleado.Sexo = (rnd.Next(0, 2) == 0) ? "Masculino" : "Femenino";
            empleado.Grupo = (char)rnd.Next('A', 'F');
            empleado.Sueldo = Math.Round(rnd.NextDouble() * 30000 + 5000, 2);
            empleado.SeguroMedico = rnd.Next(0, 2) == 1;

            txtNumero.Text = empleado.Numero.ToString();
            txtNombre.Text = empleado.Nombre;
            dtpFechaNacimiento.Value = empleado.FechaNacimiento;

            if (empleado.Sexo == "Masculino")
                rbtnMasculino.Checked = true;
            else
                rbtnFemenino.Checked = true;

            cmbGrupo.SelectedItem = empleado.Grupo.ToString();
            txtSueldo.Text = empleado.Sueldo.ToString("C");
            chkSeguroMedico.Checked = empleado.SeguroMedico;
        }

        private void gpbFecha_Enter(object sender, EventArgs e)
        {

        }
    }
}
