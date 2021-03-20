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
    public partial class frmMarca : Form
    {
        Bussiness obj = new Bussiness();
        public frmMarca()
        {
            InitializeComponent();
            CargarConsultaInicial();
            
        }
        private void CargarConsultaInicial()
        {

            dgvMarcas.DataSource = obj.ObtenerMarca();
            dgvMarcas.Columns["Activo"].Visible=false;
            dgvMarcas.Columns["IdMarca"].HeaderText = "Cod. Marca";
            dgvMarcas.Columns["IdMarca"].ReadOnly =true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            marca.Nombre = txtConsNombre.Text.Trim();
            marca.IdMarca = Convert.ToInt32(txtConsCod.Text.Trim()=="" ? "0" : txtConsCod.Text.Trim());
            dgvMarcas.DataSource= obj.ObtenerMarca(marca);
            dgvMarcas.Columns["IdMarca"].HeaderText = "Cod. Marca";
            dgvMarcas.Columns["IdMarca"].ReadOnly = true;
        }

        private void txtConsCod_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtConsCod_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlCod_Click(object sender, EventArgs e)
        {
            txtConsNombre.Enabled = false;
            pnlCod.BackColor= Color.LightBlue;
            pnlAtr.BackColor = Color.Transparent;
            txtConsCod.Enabled = true;
        }

        private void pnlAtr_Click(object sender, EventArgs e)
        {
            txtConsCod.Enabled = false;
            pnlAtr.BackColor = Color.LightBlue;
            pnlCod.BackColor = Color.Transparent;
            txtConsNombre.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            marca.IdMarca = Convert.ToInt32(dgvMarcas.CurrentRow.Cells[0].Value.ToString());
            marca.Nombre = dgvMarcas.CurrentRow.Cells[1].Value.ToString();
            obj.ActualizarMarca(marca);
            CargarConsultaInicial();
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(20000, "¡Modificado!", "Registro modificado correctamente",
                ToolTipIcon.Info);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            marca.IdMarca = Convert.ToInt32(dgvMarcas.CurrentRow.Cells[0].Value.ToString());
            marca.Nombre = dgvMarcas.CurrentRow.Cells[1].Value.ToString();
            obj.EliminarMarca(marca);
            CargarConsultaInicial();
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(20000, "¡Eliminado!", "Registro eliminado correctamente",
                ToolTipIcon.Info);
        }

    }
}
