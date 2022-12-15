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

        public void CargarHC()
        {
            oHelper = new HelperDB();
            txtHistoriaClinica.Text = oHelper.ProximoPaciente().ToString();
        }

        public void GuardarPaciente()
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbDatos.Enabled=true;
            CargarHC();
        }
    }
}