using Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDeNegocio.provincia
{
    public class Provincia
    {
        MySqlConnection con = new MySqlConnection();

        private String descripcionp;

        public Provincia() { }
        public Provincia(string descripcion)
        {
            this.descripcionp = descripcion;
        }

        public string Descripcionp { get => descripcionp; set => descripcionp = value; }

        public void insertarProvincia(Provincia provincia)
        {
            List<Provincia> ListProvincia = new List<Provincia>();
            ListProvincia.Add(provincia);
            try
            {
                con = new Conexion().Conectar();
                con.Open();
                MySqlCommand cmd = new MySqlCommand("spl_registrarProvincia", con);
                cmd.CommandType = CommandType.StoredProcedure;

                foreach (Provincia prov in ListProvincia)
                {
                    cmd.Parameters.AddWithValue("@p_descripcion", prov.descripcionp);
                }
                cmd.ExecuteReader();
            }
            catch (Exception ex) { throw ex; }
            finally
                {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
    }

}
