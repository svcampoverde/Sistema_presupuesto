using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDeNegocio.provincia
{
    public class AdmProvincia
    {
        Provincia proced = new Provincia();

        public bool insertarProvincia(Provincia pro)
        {
            Provincia registro = pro;
            registro.insertarProvincia(registro);
            return true;
        }
    }
}
