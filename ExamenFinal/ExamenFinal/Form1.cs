using System.ComponentModel;
using System.Data;
using System.Numerics;

namespace ExamenFinal
{
    public partial class Form1 : Form
    {
        private HelperDB? oHelper;
        private Accion accion;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           ActualizarLista();
           Limpiar();
           CargarCombo();
           txtHistoriaClinica.ReadOnly = true;
           gbDatos.Enabled = false;
        }
        
        //----------------------------------------------------------------------------------
       
        #region METODOS AUXILIARES

        enum Accion
        {
            NUEVO,
            EDITAR
        }

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
            cbObraSocial.Text = "Particular";
            cbObraSocial.Enabled = false;
        }

        public void ActualizarLista()
        {
            oHelper = new HelperDB();
            lstPacientes.Items.Clear();
            DataTable tabla = oHelper.EjecutarSelect("Pacientes");

            foreach (DataRow fila in tabla.Rows)
            {
                Paciente p = new Paciente
                {
                    pNumeroHC = int.Parse(fila["numeroHC"].ToString()),
                    pNombre = fila["nombre"].ToString(),
                    pObraSocial = int.Parse(fila["obraSocial"].ToString()),
                    pSexo = int.Parse(fila["sexo"].ToString()),
                    pFechaNac = (DateTime)fila["fechaNacimiento"]
                };

                lstPacientes.Items.Add(p);
            }
        }

        public void Limpiar()
        {
            txtNombre.Text = String.Empty;
            ckbObraSocial.Checked = false;
            cbObraSocial.SelectedIndex = -1;
            cbObraSocial.Text = "Particular";
            rbFemenino.Checked = false;
            rbMasculino.Checked = false;
            dtpFechaNac.Value = dtpFechaNac.MinDate;
            btnEditar.Enabled = false;
            btnGrabar.Enabled = false;
            btnBorrar.Enabled = false;
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
            else
            {
                paciente.pObraSocial = 0;
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
                if (accion is Accion.NUEVO)
                {
                    res = oHelper.EjecutarInsert(ObtenerPaciente());
                }
                else if(accion is Accion.EDITAR)
                {
                    res = oHelper.EjecutarUpdate(ObtenerPaciente());
                }
            }
            else
            {
                MessageBox.Show("Datos Vacios y/o Invalidos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return res;
        }

        public int BorrarPaciente()
        {
            int res;

            oHelper = new HelperDB();
            res = oHelper.EjecutarDelete(ObtenerPaciente());

            return res;
        }

        #endregion

        //----------------------------------------------------------------------------------

        #region CONFIGURACION DE BOTONES
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbDatos.Enabled = true;
            CargarHC();
            Limpiar();
            accion = Accion.NUEVO;
            btnGrabar.Enabled = true;
            txtNombre.Focus();
            lstPacientes.SelectedIndex = -1;
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
            var result = MessageBox.Show("Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
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
            int anios = DateTime.Now.Year - dtpFechaNac.Value.Year;
            if(anios < 18)
            {
                MessageBox.Show("Fecha Invalida", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtpFechaNac.Value = dtpFechaNac.MinDate;
                return;
            }
        }

        private void ckbObraSocial_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbObraSocial.Checked)
            {
                cbObraSocial.Enabled = true;
                cbObraSocial.Text = null;
            }
            else
            {
                cbObraSocial.Enabled = false;
                cbObraSocial.Text = "Particular";
            }
        }

        private void lstPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPacientes.SelectedIndex != -1)
            {
                gbDatos.Enabled = false;
                btnEditar.Enabled = true;
                btnBorrar.Enabled = true;
                btnGrabar.Enabled = false;

                Paciente p = (Paciente)lstPacientes.SelectedItem;

                txtHistoriaClinica.Text = p.pNumeroHC.ToString();

                txtNombre.Text = p.pNombre;

                if (p.pObraSocial == 0)
                {
                    ckbObraSocial.Checked = false;
                    cbObraSocial.Text = "Particular";
                }
                else
                {
                    ckbObraSocial.Checked = true;
                    cbObraSocial.SelectedValue = p.pObraSocial;
                }

                if (p.pSexo == 1)
                {
                    rbFemenino.Checked = true;
                }
                else
                {
                    rbMasculino.Checked = true;
                }

                dtpFechaNac.Value = p.pFechaNac;
            }
            else
            {
                btnEditar.Enabled = false;
            }
        }

        private void cbObraSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbDatos.Enabled = true;
            btnGrabar.Enabled = true;
            accion = Accion.EDITAR;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

            if(BorrarPaciente() == 1)
            {
                MessageBox.Show("Paciente borrado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
                ActualizarLista();
            }
        }

        #endregion

        //----------------------------------------------------------------------------------
    }
}