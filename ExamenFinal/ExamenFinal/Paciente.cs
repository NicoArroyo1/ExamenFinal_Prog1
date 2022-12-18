using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    public class Paciente
    {
        #region ATRIBUTOS
        private int numeroHC;
		private string nombre;
		private int obraSocial;
		private int sexo;
		private DateTime fechaNac;
        #endregion

        #region PROPIEDADES
        public int pNumeroHC
		{
			get { return numeroHC; }
			set { numeroHC = value; }
		}
        public string pNombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int pObraSocial
        {
            get { return obraSocial; }
            set { obraSocial = value; }
        }
        public int pSexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public DateTime pFechaNac
        {
            get { return fechaNac; }
            set { fechaNac = value; }
        }
        #endregion

        #region CONSTRUCTORES
        public Paciente()
        {
            pNumeroHC = 0;
            pNombre = "";
            pObraSocial = 0;
            pSexo = 0;
            pFechaNac = DateTime.Today;
        }
        public Paciente(int hc, string nom, int obrasocial, int sexo, DateTime fechanac)
        {
            pNumeroHC = hc;
            pNombre = nom;
            pObraSocial = obrasocial;
            pSexo = sexo;
            pFechaNac = fechanac;
        }
        #endregion

        #region METODOS
        public override string ToString()
        {
            return numeroHC + "  -  " + nombre + "  -  " + fechaNac.ToShortDateString();
        }
        #endregion
    }
}