using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplicacionBotica.Utilitarios;
using AplicacionBotica.Formulario;

namespace AplicacionBotica.UsuarioControl
{
    public partial class userProducto : UserControl
    {
        public userProducto()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            clsPanel.addPanel(new frmProducto_Registrar(), panelFormulario);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           clsUsuarioControl.addPanel(new UserProducto_Buscar(), panelFormulario);    
        }
    }
}
