using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionBotica.Utilitarios
{
    class clsUsuarioControl
    {
        public static void addPanel(object formHijo, object panelAgregar)
        {
            Panel panel = panelAgregar as Panel;
            panel.Dock = DockStyle.Fill;
            panel.Visible = true;
            if (panel.Controls.Count > 0)
                panel.Controls.RemoveAt(0);
            UserControl formulario = formHijo as UserControl;
            formulario.Dock = DockStyle.Fill;
            panel.Controls.Add(formulario);
            panel.Tag = formulario;
            formulario.Show();
        }
        //public static void addPanel(object formHijo, object panelAgregar)
        //{
        //    Form panel = panelAgregar as Form;
        //    panel.Dock = DockStyle.Fill;
        //    panel.Visible = true;
        //    if (panel.Controls.Count > 0)
        //        panel.Controls.RemoveAt(0);
        //    Form UsuarioControl = formHijo as Form;
        //    UsuarioControl.Dock = DockStyle.Fill;
        //    panel.Controls.Add(UsuarioControl);
        //    panel.Tag = UsuarioControl;
        //    UsuarioControl.Show();
        //}
    }
}
