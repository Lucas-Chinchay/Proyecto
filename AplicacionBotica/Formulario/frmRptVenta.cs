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
    public partial class frmRptVenta : Form
    {
        public frmRptVenta()
        {
            InitializeComponent();
        }

        private void frmRptVenta_Load(object sender, EventArgs e)
        {           
            this.reportViewer1.RefreshReport();
        }
    }
}
