using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDeNegocio.provincia
{
    public class AdmProvincia
    {
        Provincia provin = new Provincia();
        public List<Provincia> ConsultarProvincia(string dato)
        {
            List<Provincia> provincia = null;
            if (String.IsNullOrEmpty(dato))
            {
                throw new ExceptionSistema("No existen registros");
            }
            else
            {
                if (dato == "iniciar_datagrid")
                {
                    dato = "";
                }
                provincia = provin.BuscarProvincia(dato);
                if (provincia.Count == 0)
                {
                    throw new ExceptionSistema("Provincia no encontrada");
                }
            }
            return provincia;
        }
        public bool insertarProvincia(Provincia pro)
        {
            Provincia registro = pro;
            registro.insertarProvincia(registro);
            return true;
        }
    }
}
