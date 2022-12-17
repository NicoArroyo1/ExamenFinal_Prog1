using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    public class Paciente
    {
		private int NumeroHC;
		private string Nombre;
		private int ObraSocial;
		private int Sexo;
		private DateTime FechaNac;

		public int pNumeroHC
		{
			get { return NumeroHC; }
			set { NumeroHC = value; }
		}
        public string pNombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public int pObraSocial
        {
            get { return ObraSocial; }
            set { ObraSocial = value; }
        }
        public int pSexo
        {
            get { return Sexo; }
            set { Sexo = value; }
        }
        public DateTime pFechaNac
        {
            get { return FechaNac; }
            set { FechaNac = value; }
        }

        public override string ToString()
        {
            return ""; 
        }


    }
}
