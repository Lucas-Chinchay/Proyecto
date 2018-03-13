using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionBotica.Utilitarios
{
    class clsBorrar_Control
    {
        public void Limpiar_campos(Control control)
        {

            foreach (Control elemento in control.Controls)
            {
                if (elemento.GetType().ToString() == "System.Windows.Forms.TextBox")
                {
                    TextBox t = (TextBox)elemento;
                    t.Clear();
                }

            

                //{
                //    ComboBox t = (ComboBox)elemento;
                //    t.SelectedIndex=0;
                //}
            }
        }
    }
}







//        public void BorrarCampos(Control control)
//        {
//            foreach (var txt in control.Controls)
//            {
//                if (txt is TextBox)
//                {
//                    ((TextBox)txt).Clear();

//                }
//            }
//        }


//    }
//}


