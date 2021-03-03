using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Intertazz.Data;

namespace Intertazz.Formularios
{
    public partial class frmProducto : Form
    {
        Bussiness obj = new Bussiness();
        public frmProducto()
        {
            InitializeComponent();
            CargarConsultaInicial();
            lblErrorCrear.Visible = false;
        }
        private void CargarConsultaInicial()
        {

            dgvMarcas.DataSource = obj.ObtenerMarca();
            dgvMarcas.Columns["Activo"].Visible=false;
            dgvMarcas.Columns["IdMarca"].HeaderText = "Cod. Marca";
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (txtCrearNombre.Text.Trim() != "")
            {
                lblErrorCrear.Visible = false;
                Marca marca = new Marca();
                marca.Nombre = txtCrearNombre.Text.Trim();
                marca = obj.CrearMarca(marca);
                MessageBox.Show( "Se ha registrado la marca: " + marca.Nombre + " con código " + marca.IdMarca.ToString(), "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarConsultaInicial();
                txtCrearNombre.Text = "";
            }
            else
            {
                lblErrorCrear.Visible = true;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (btnNuevo.Text == "Nuevo")
            {
                pnlNuevo.Size = new Size(800, 107);
                btnNuevo.Text = "Cancelar";
            }
            else
            {
                pnlNuevo.Size = new Size(800, 32);
                btnNuevo.Text = "Nuevo";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            marca.Nombre = txtConsNombre.Text;
            marca.IdMarca = Convert.ToInt32(txtConsCod.Text);
            dgvMarcas.DataSource= obj.ObtenerMarca(marca);
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {

        }
    }
}
