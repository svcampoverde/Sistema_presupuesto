using LogicDeNegocio.provincia;
using LogicDeNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.ModuloProvincia
{
    public partial class FrmBuscarProvincia : MaterialSkin.Controls.MaterialForm
    {
        AdmProvincia adm = new AdmProvincia();
        public FrmBuscarProvincia()
        {
            InitializeComponent();
            LlenarDataGrid("iniciar_datagrid");
        }

        private void LlenarDataGrid(string datos)
        {
            try
            {
                List<Provincia> list = adm.ConsultarProvincia(datos);

                int cont = 0;

                foreach (Provincia provincia in list)
                {
                    dtgProvincia.Rows.Add(1);
                    dtgProvincia.Rows[cont].Cells[1].Value = provincia.Descripcionp.ToString();
                    cont++;
                }

            }
            catch (ExceptionSistema ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
