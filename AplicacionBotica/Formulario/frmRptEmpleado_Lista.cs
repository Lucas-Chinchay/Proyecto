using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionBotica.Formulario
{
    public partial class frmRptEmpleado_Lista : Form
    {
        public frmRptEmpleado_Lista()
        {
            InitializeComponent();
        }

        private void frmRptEmpleado_Lista_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
