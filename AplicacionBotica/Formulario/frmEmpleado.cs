using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplicacionBotica.Utilitarios;
using AplicacionBotica.UsuarioControl;

namespace AplicacionBotica.Formulario
{
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            clsPanel.addPanel(new frmEmpleado_Registrar(), panelFormulario);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            clsPanel.addPanel(new frmEmpleado_Buscar(), panelFormulario);
        }
    }
}
