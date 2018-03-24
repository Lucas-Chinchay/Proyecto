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
using AplicacionBotica.Conexion;

namespace AplicacionBotica.Formulario
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            userInicio1.BringToFront();        
            panelSeguir.Height = btnInicio.Height;
            panelSeguir.Top = btnInicio.Top;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {        
            Close();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            clsUsuarioControl.addPanel(new userInicio(), panelFormulario);
            panelSeguir.Height = btnInicio.Height;
            panelSeguir.Top = btnInicio.Top;
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            clsPanel.addPanel(new frmVenta(), panelFormulario);
            panelSeguir.Height = btnVender.Height;
            panelSeguir.Top = btnVender.Top;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuarioConectado.Text = "USUARIO CONECTADO: " +
                mdlVariablesDeAplicacionBotica.UsuarioConectado.Usuario;
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            clsUsuarioControl.addPanel(new userProducto(), panelFormulario);
            panelSeguir.Height = btnProducto.Height;
            panelSeguir.Top = btnProducto.Top;
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            clsPanel.addPanel(new frmEmpleado(), panelFormulario);
            panelSeguir.Height = btnEmpleado.Height;
            panelSeguir.Top = btnEmpleado.Top;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            panelSeguir.Height = btn.Height;
            panelSeguir.Top = btn.Top;

            if (panelMenu.Width == 176 || panelBoton.Width==176)
            {
                panelMenu.Width = 55;
                panelBoton.Width =55;
            }
            else
            {
                panelMenu.Width = 176;
                panelBoton.Width = 176;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (this.WindowState == FormWindowState.Normal)
            //{
            //    this.WindowState = FormWindowState.Maximized;
            //}
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmEmpleado_Cambiar_Password cambiar = new frmEmpleado_Cambiar_Password();
            cambiar.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmVenta_Reporte reporte = new frmVenta_Reporte();
            reporte.ShowDialog();
        }
    }
}
