using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;
using AplicacionBotica.Utilitarios;

namespace AplicacionBotica.Formulario
{
    public partial class frmEmpleado_Buscar : Form
    {
        private List<clsEmpleado> _Empleado_Listar =new List<clsEmpleado>();

        public List<clsEmpleado> Empleado_Listar
        {
            get { return _Empleado_Listar; }
            set { _Empleado_Listar = value; }
        }
        private clsEmpleado _Capturado;

        public clsEmpleado Capturado
        {
            get { return _Capturado; }
            set { _Capturado = value; }
        }
        
        
        public frmEmpleado_Buscar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstDatos.Items.Clear();
            Empleado_Listar.Clear();
            int contador = 0;
            foreach (clsEmpleado elemento in clsEmpleado.Listar_Todo())
            {
                lstDatos.Items.Add(Convert.ToString(contador + 1));
                lstDatos.Items[contador].SubItems.Add(elemento.EmpleadoDNI);
                lstDatos.Items[contador].SubItems.Add(elemento.Nombre + " " + elemento.ApellidoPaterno + " " + elemento.ApellidoMaterno);
                //lstDatos.Items[contador].SubItems.Add(elemento.ApellidoPaterno);
                //lstDatos.Items[contador].SubItems.Add(elemento.ApellidoMaterno);
                lstDatos.Items[contador].SubItems.Add(elemento.FechaIngreso.ToShortDateString());
                lstDatos.Items[contador].SubItems.Add(elemento.Telefono);
               // lstDatos.Items[contador].SubItems.Add(elemento.Direccion);
               // lstDatos.Items[contador].SubItems.Add(elemento.Sexo.ToString());
                lstDatos.Items[contador].SubItems.Add(elemento.Cargo);
                lstDatos.Items[contador].SubItems.Add(elemento.Usuario);
               // lstDatos.Items[contador].SubItems.Add(elemento.Clave);
               // Empleado_Listar.Add(elemento);

                if (contador % 2 == 0)
                {
                    lstDatos.Items[contador].BackColor = Color.Cyan;
                }
                contador = contador + 1;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmRptEmpleado_Lista EmpleadoLista;
            EmpleadoLista = new frmRptEmpleado_Lista();
            EmpleadoLista.clsEmpleadoBindingSource.DataSource = Empleado_Listar;
            EmpleadoLista.Show();
        }
        private void txtNombreApellido_TextChanged(object sender, EventArgs e)
        {
            lstDatos.Items.Clear();
            Empleado_Listar.Clear();
            int contador = 0;
            foreach (clsEmpleado elemento in clsEmpleado.Buscar_Empleado_DNI(txtNombreApellido.Text))
            {
                lstDatos.Items.Add(Convert.ToString(contador + 1));
                lstDatos.Items[contador].SubItems.Add(elemento.EmpleadoDNI);
                lstDatos.Items[contador].SubItems.Add(elemento.Nombre + " " + elemento.ApellidoPaterno +
                                                        " " + elemento.ApellidoMaterno);               
                lstDatos.Items[contador].SubItems.Add(elemento.FechaIngreso.ToShortDateString());
                lstDatos.Items[contador].SubItems.Add(elemento.Telefono);
                lstDatos.Items[contador].SubItems.Add(elemento.Cargo);
                lstDatos.Items[contador].SubItems.Add(elemento.Usuario);
                Empleado_Listar.Add(elemento);
                if (contador % 2 == 0)
                {
                    lstDatos.Items[contador].BackColor = Color.Cyan;
                }
                contador = contador + 1;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            clsPanel.addPanel(new frmEmpleado(), panelFormulario);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Capturado = Empleado_Listar[lstDatos.SelectedItems[0].Index];
            frmAdministrar_Clave admin = new frmAdministrar_Clave();
            admin.ShowDialog();

        }
    }
}
