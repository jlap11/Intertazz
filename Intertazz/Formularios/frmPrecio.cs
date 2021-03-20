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
    public partial class frmPrecio : Form
    {
        Bussiness obj = new Bussiness();
        public frmPrecio()
        {
            InitializeComponent();
            CargarConsultaInicial();
            
        }
        private void CargarConsultaInicial()
        {

            dgvPrecios.DataSource = obj.ObtenerPrecio();
            dgvPrecios.Columns["Activo"].Visible=false;
            dgvPrecios.Columns["IdPrecio"].HeaderText = "Cod. Precio";
            dgvPrecios.Columns["IdPrecio"].ReadOnly =true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Precio Precio = new Precio();
            //Precio.Nombre = txtConsNombre.Text.Trim();
            Precio.IdPrecio = Convert.ToInt32(txtConsCod.Text.Trim()=="" ? "0" : txtConsCod.Text.Trim());
            dgvPrecios.DataSource= obj.ObtenerPrecio(Precio);
            dgvPrecios.Columns["IdPrecio"].HeaderText = "Cod. Precio";
            dgvPrecios.Columns["IdPrecio"].ReadOnly = true;
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
            Precio Precio = new Precio();
            Precio.IdPrecio = Convert.ToInt32(dgvPrecios.CurrentRow.Cells[0].Value.ToString());
            //Precio.Nombre = dgvPrecios.CurrentRow.Cells[1].Value.ToString();
            obj.ActualizarPrecio(Precio);
            CargarConsultaInicial();
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(20000, "¡Modificado!", "Registro modificado correctamente",
                ToolTipIcon.Info);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Precio Precio = new Precio();
            Precio.IdPrecio = Convert.ToInt32(dgvPrecios.CurrentRow.Cells[0].Value.ToString());
            //Precio.Nombre = dgvPrecios.CurrentRow.Cells[1].Value.ToString();
            obj.EliminarPrecio(Precio);
            CargarConsultaInicial();
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(20000, "¡Eliminado!", "Registro eliminado correctamente",
                ToolTipIcon.Info);
        }

    }
}
