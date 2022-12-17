namespace ExamenFinal
{
    public partial class Form1 : Form
    {
        private HelperDB? oHelper;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           gbDatos.Enabled = false;
           Limpiar();
           CargarCombo();
           txtHistoriaClinica.ReadOnly = true;
        }
        
        //----------------------------------------------------------------------------------
       
        #region METODOS AUXILIARES

        public void CargarHC()
        {
            oHelper = new HelperDB();
            txtHistoriaClinica.Text = oHelper.ProximoPaciente().ToString();
        }

        public void CargarCombo()
        {
            oHelper = new HelperDB();
            cbObraSocial.DataSource = oHelper.EjecutarSelect("ObrasSociales");
            cbObraSocial.ValueMember = "idObraSocial";
            cbObraSocial.DisplayMember = "nombreObraSocial";
            cbObraSocial.SelectedIndex = -1;
            cbObraSocial.Enabled = false;
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

        public Paciente ObtenerPaciente()
        {
            Paciente paciente = new Paciente();
            paciente.pNumeroHC = int.Parse(txtHistoriaClinica.Text);
            paciente.pNombre = txtNombre.Text;
            if(ckbObraSocial.Checked is true)
            {
                paciente.pObraSocial = (int)cbObraSocial.SelectedValue;
            }
            if(rbFemenino.Checked is true)
            {
                paciente.pSexo = 1;
            }
            else
            {
                paciente.pSexo = 2;
            }
            paciente.pFechaNac = dtpFechaNac.Value;

            return paciente;
        }

        public bool Validar()
        {
            bool validacion = true;

            if (txtNombre.Text.Equals(String.Empty))
            {
                validacion = false;
            }
            if((ckbObraSocial.Checked is true) && (cbObraSocial.SelectedIndex == -1))
            {
                validacion = false;
            }
            if(rbFemenino.Checked is false && rbMasculino.Checked is false)
            {
                validacion = false;
            }

            return validacion;
        }

        public int GuardarPaciente()
        {
            int res = 0;
            if (Validar())
            {
                oHelper = new HelperDB();
                res = oHelper.EjecutarInsert(ObtenerPaciente());
            }
            else
            {
                MessageBox.Show("Datos Vacios y/o Invalidos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return res;
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
            if (GuardarPaciente() == 1)
            {
                MessageBox.Show("Se guardo con exito!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al guardar!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            this.Form1_Load(sender, e);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void dtpFechaNac_ValueChanged(object sender, EventArgs e)
        {
            if(dtpFechaNac.Value > DateTime.Today)
            {
                MessageBox.Show("Fecha Invalida", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtpFechaNac.Value = DateTime.Today;
                return;
            }
        }

        private void ckbObraSocial_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbObraSocial.Checked)
            {
                cbObraSocial.Enabled = true;
            }
            else
            {
                cbObraSocial.Enabled = false;
                cbObraSocial.SelectedIndex = -1;
            }
        }

        #endregion

        //----------------------------------------------------------------------------------
    }
}