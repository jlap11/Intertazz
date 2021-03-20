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
    public partial class frmCategoria : Form
    {
        Bussiness obj = new Bussiness();
        public frmCategoria()
        {
            InitializeComponent();
            CargarConsultaInicial();
            
        }
        private void CargarConsultaInicial()
        {

            dgvCategorias.DataSource = obj.ObtenerCategoria();
            dgvCategorias.Columns["Activo"].Visible=false;
            dgvCategorias.Columns["IdCategoria"].HeaderText = "Cod. Categoria";
            dgvCategorias.Columns["IdCategoria"].ReadOnly =true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Categoria Categoria = new Categoria();
            Categoria.Nombre = txtConsNombre.Text.Trim();
            Categoria.IdCategoria = Convert.ToInt32(txtConsCod.Text.Trim()=="" ? "0" : txtConsCod.Text.Trim());
            dgvCategorias.DataSource= obj.ObtenerCategoria(Categoria);
            dgvCategorias.Columns["IdCategoria"].HeaderText = "Cod. Categoria";
            dgvCategorias.Columns["IdCategoria"].ReadOnly = true;
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
            Categoria Categoria = new Categoria();
            Categoria.IdCategoria = Convert.ToInt32(dgvCategorias.CurrentRow.Cells[0].Value.ToString());
            Categoria.Nombre = dgvCategorias.CurrentRow.Cells[1].Value.ToString();
            obj.ActualizarCategoria(Categoria);
            CargarConsultaInicial();
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(20000, "¡Modificado!", "Registro modificado correctamente",
                ToolTipIcon.Info);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Categoria Categoria = new Categoria();
            Categoria.IdCategoria = Convert.ToInt32(dgvCategorias.CurrentRow.Cells[0].Value.ToString());
            Categoria.Nombre = dgvCategorias.CurrentRow.Cells[1].Value.ToString();
            obj.EliminarCategoria(Categoria);
            CargarConsultaInicial();
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(20000, "¡Eliminado!", "Registro eliminado correctamente",
                ToolTipIcon.Info);
        }

    }
}
