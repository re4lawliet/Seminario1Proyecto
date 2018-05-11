using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;


namespace proyectoseminario
{
    public class Class1
    {
        private SqlConnection conectar;
        private SqlCommand comando;
        private SqlDataAdapter adaptador;
        private DataTable tabla;

        private void iniciar(){
            try {
                conectar = new SqlConnection();
                conectar.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=seminarioproyecto;Data Source=(local)";
                conectar.Open();

            }
            catch
            {

            }
 
        }

        public bool guardarrecomendacion(string nombre, string reco)
        {
            iniciar();
            try
            {
                comando = new SqlCommand("insert into recomendaciones(nombrepersona,recomendacion)values('"+nombre+"','"+reco+"');", conectar);
                comando.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable datos(string s)
        {
            iniciar();
            try
            {
                adaptador = new SqlDataAdapter(s, conectar);
                tabla = new DataTable();
                adaptador.Fill(tabla);
            }
            catch
            {

            }
            return tabla;
        }
    }
}