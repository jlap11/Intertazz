using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Intertazz.Formularios
{
    public partial class MainAnterior : Form
    {
        public MainAnterior()
        {
            InitializeComponent();
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar .Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;           
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int vMsg, int wParam, int lparam);

        private void PBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {            
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012,0); 
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            pnlSubMenuProducto.Visible = true;
            
        }
        private void AbrirFormEnPanel(object formhija)
        {
            if (this.PContenedor.Controls.Count > 0)
                this.PContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PContenedor.Controls.Add(fh);
            this.PContenedor.Tag = fh;
            fh.Show();

        }

        private void AbrirControlEnPanel(object formhija)
        {
            if (this.PContenedor.Controls.Count > 0)
                this.PContenedor.Controls.RemoveAt(0);
            Control fh = formhija as Control;
            //fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PContenedor.Controls.Add(fh);
            this.PContenedor.Tag = fh;
            fh.Show();

        }
        private void btnInventario_Click(object sender, EventArgs e)
        {
            
        }

        private void btnProductoNuevo_Click(object sender, EventArgs e)
        {
            AbrirControlEnPanel(new ctlMarcaCrear());
        }

        private void btnProductoCons_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmProducto());
        }

        private void pnlSubMenuProducto_Leave(object sender, EventArgs e)
        {
            pnlSubMenuProducto.Visible = false;
        }

        private void btnProductos_MouseHover(object sender, EventArgs e)
        {
            pnlBordeProdcutos.Visible = true;
            pnlSubMenuProducto.Visible = true;
        }

        private void btnProductos_MouseLeave_1(object sender, EventArgs e)
        {
            
            pnlBordeProdcutos.Visible = false;
            pnlSubMenuProducto.Visible = false;
        }

        private void pnlSubMenuProducto_MouseHover(object sender, EventArgs e)
        {
            pnlBordeProdcutos.Visible = true;
            pnlSubMenuProducto.Visible = true;
        }
    }
}
