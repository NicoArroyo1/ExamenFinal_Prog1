namespace ExamenFinal
{
    public partial class Form1 : Form
    {
        private HelperDB oHelper;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           gbDatos.Enabled = false;
           
        }
        
        //----------------------------------------------------------------------------------
       
        #region METODOS AUXILIARES

        public void CargarHC()
        {
            oHelper = new HelperDB();
            txtHistoriaClinica.Text = oHelper.ProximoPaciente().ToString();
        }

        public void Limpiar()
        {
            txtNombre.Text = String.Empty;
            ckbObraSocial.Checked = false;
            cbObraSocial.SelectedIndex = -1;
            rbFemenino.Checked = false;
            rbMasculino.Checked = false;
            dtpFechaNac.Value = DateTime.Today;
        }
        public void GuardarPaciente()
        {

        }

        #endregion

        //----------------------------------------------------------------------------------

        #region CONFIGURACION DE BOTONES
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbDatos.Enabled=true;
            CargarHC();
            Limpiar();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }
        #endregion

        //----------------------------------------------------------------------------------
    }
}