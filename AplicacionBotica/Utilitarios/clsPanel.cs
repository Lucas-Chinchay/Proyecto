using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionBotica.Utilitarios
{
    class clsPanel
    {
        public static void addPanel(object formHijo, object panelAgregar)
        {
            Panel panel = panelAgregar as Panel;
            panel.Dock = DockStyle.Fill;
            panel.Visible = true;
            if (panel.Controls.Count > 0)
                panel.Controls.RemoveAt(0);
            Form formulario = formHijo as Form;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panel.Controls.Add(formulario);
            panel.Tag = formulario;
            formulario.Show();
        }
    }
}
