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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            PersonalizarDiseno();
        }

        #region Personalizacion Formulario
        private Form activeForm = null;
        private void PersonalizarDiseno()
        {
            try
            {
                pnlSubProduct.Visible = false;
            }
            catch (Exception ex)
            { 
                //Crear Alerta
            }
        }
        private void OcultarSubMenu()
        {
            try
            {
                if (pnlSubProduct.Visible) { pnlSubProduct.Visible = false; }
            }
            catch (Exception ex)
            { 
                //Crear Alerta
            }
        }
        private void MostrarSubmenu(Panel subMenu) 
        {
            try
            {
                if (!subMenu.Visible)
                {
                    OcultarSubMenu();
                    subMenu.Visible = true;
                }
                else
                {
                    subMenu.Visible = false;
                }
            }
            catch (Exception ex)
            {
                //Crear Alerta
            }
        }
        private void AbrirFormEnPanel(Form formhija)
        {
            try
            {
                if (activeForm != null) { activeForm.Close(); }
                activeForm = formhija;
                formhija.TopLevel = false;

                if (this.PContenedor.Controls.Count > 0)
                    this.PContenedor.Controls.RemoveAt(0);
                Form fh = formhija as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.PContenedor.Controls.Add(fh);
                this.PContenedor.Tag = fh;
                fh.Show();
            } catch(Exception ex)
            {
                //Crear Alerta
            }
        }

        #endregion

        #region Eventos
        #region Menu Productos
        private void btnProductos_Click(object sender, EventArgs e)
        {
            try
            {
                MostrarSubmenu(pnlSubProduct);
            }
            catch (Exception ex)
            { 
              //Crear  Alerta  
            }
        }
        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirFormEnPanel(new frmProducto());
                OcultarSubMenu();
            }
            catch (Exception ex)
            { 
                //Crear Alerta
            }
        }
        #endregion
        #region Menu Inventario
        private void btnInventario_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirFormEnPanel(new frmMarca());
            }
            catch (Exception Ex)
            { 
                //Crear Alerta
            }
        }
        #endregion
        #endregion
    }
}
