using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    public class HelperDB
    {
        private SqlConnection cnn;

        public HelperDB()
        {
            //cnn = new SqlConnection(@"Data Source=PC-NICO\SQLEXPRESS;Initial Catalog=Consultorio;Integrated Security=True");
            cnn = new SqlConnection();
            cnn.ConnectionString = Properties.Resources.StringConexion1;
        }

        public int ProximoPaciente()
        {
            int paciente;

            string query = "select MAX(numeroHC)+1 from Pacientes";
            //string query2 = "select ident_current('Pacientes')";
            
            cnn.Open();
            SqlCommand cmd = new(query, cnn);
            paciente = int.Parse(cmd.ExecuteScalar().ToString());
            cnn.Close();

            return paciente++;
        }

        public DataTable EjecutarSelect(string nomTabla)
        {
            DataTable tabla = new();

            string query = $"select * from {nomTabla}";

            cnn.Open();
            SqlCommand cmd = new(query, cnn);
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();

            return tabla;
        }

        public int EjecutarUpdate(string cod, string nom, string esp, string pre, string fec)
        {
            int filas;

            string query = $"update Plantas set nombre='{nom}',especie={esp},precio={pre},fecha='{fec}' where codigo={cod}";

            cnn.Open();
            SqlCommand cmd = new(query, cnn);
            filas = cmd.ExecuteNonQuery();
            cnn.Close();

            return filas;
        }
    }
}