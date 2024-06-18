using MySql.Data.MySqlClient;
using Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDeNegocio.personas
{
    public class Usuario : Persona
    {
        private String user;
        private String clave;
        private Rol rol;

        public Usuario(string cedula, string nombre, string apellido, string genero, string telefono, string celular, string ciudad, string correo, string direccion , string user, string clave)
            :base(cedula, nombre, apellido, genero, telefono, celular, ciudad, correo,  direccion)
        {
            this.user = user;
            this.Clave = clave;
            this.Rol = rol;
        }

        public string User { get => user; set => user = value; }
        public string Clave { get => clave; set => clave = value; }
        public Rol Rol { get => rol; set => rol = value; }

       
    }

}
