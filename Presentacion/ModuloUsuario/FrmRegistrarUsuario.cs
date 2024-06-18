using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.ModuloUsuario
{
    public partial class FrmRegistrarUsuario : MaterialSkin.Controls.MaterialForm
    {

        public FrmRegistrarUsuario()
        {
            InitializeComponent();
        }

        private void FrmRegistrarUsuario_Load(object sender, EventArgs e)
        {
                SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;//.DARK;
                SkinManager.ColorScheme = new ColorScheme(Primary.Red900, Primary.Red900, Primary.Blue100, Accent.Green700, TextShade.BLACK);
          
        }
    }
}
