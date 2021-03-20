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
    public partial class frmInventario : Form
    {
        Bussiness obj = new Bussiness();
        public frmInventario()
        {
            InitializeComponent();
            CargarConsultaInicial();
            
        }
        private void CargarConsultaInicial()
        {

            dgvInventarios.DataSource = obj.ObtenerInventario();
            dgvInventarios.Columns["Activo"].Visible=false;
            dgvInventarios.Columns["IdInventario"].HeaderText = "Cod. Inventario";
            dgvInventarios.Columns["IdInventario"].ReadOnly =true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Inventario Inventario = new Inventario();
            //Inventario.Nombre = txtConsNombre.Text.Trim();
            Inventario.IdInventario = Convert.ToInt32(txtConsCod.Text.Trim()=="" ? "0" : txtConsCod.Text.Trim());
            dgvInventarios.DataSource= obj.ObtenerInventario(Inventario);
            dgvInventarios.Columns["IdInventario"].HeaderText = "Cod. Inventario";
            dgvInventarios.Columns["IdInventario"].ReadOnly = true;
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
            Inventario Inventario = new Inventario();
            Inventario.IdInventario = Convert.ToInt32(dgvInventarios.CurrentRow.Cells[0].Value.ToString());
            //Inventario.Nombre = dgvInventarios.CurrentRow.Cells[1].Value.ToString();
            obj.ActualizarInventario(Inventario);
            CargarConsultaInicial();
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(20000, "¡Modificado!", "Registro modificado correctamente",
                ToolTipIcon.Info);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Inventario Inventario = new Inventario();
            Inventario.IdInventario = Convert.ToInt32(dgvInventarios.CurrentRow.Cells[0].Value.ToString());
            //Inventario.Nombre = dgvInventarios.CurrentRow.Cells[1].Value.ToString();
            obj.EliminarInventario(Inventario);
            CargarConsultaInicial();
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(20000, "¡Eliminado!", "Registro eliminado correctamente",
                ToolTipIcon.Info);
        }

    }
}
