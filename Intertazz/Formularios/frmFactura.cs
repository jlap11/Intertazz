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
    public partial class frmFactura : Form
    {
        Bussiness obj = new Bussiness();
        public frmFactura()
        {
            InitializeComponent();
            CargarConsultaInicial();
            
        }
        private void CargarConsultaInicial()
        {

            dgvFacturas.DataSource = obj.ObtenerFacturas();
            dgvFacturas.Columns["Activo"].Visible=false;
            dgvFacturas.Columns["IdFactura"].HeaderText = "Cod. Factura";
            dgvFacturas.Columns["IdFactura"].ReadOnly =true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Facturas Factura = new Facturas();
            //Factura.Nombre = txtConsNombre.Text.Trim();
            Factura.IdFacturas = Convert.ToInt32(txtConsCod.Text.Trim()=="" ? "0" : txtConsCod.Text.Trim());
            dgvFacturas.DataSource= obj.ObtenerFacturas(Factura);
            dgvFacturas.Columns["IdFactura"].HeaderText = "Cod. Factura";
            dgvFacturas.Columns["IdFactura"].ReadOnly = true;
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
            Facturas Factura = new Facturas();
            Factura.IdFacturas = Convert.ToInt32(dgvFacturas.CurrentRow.Cells[0].Value.ToString());
            //Factura.Nombre = dgvFacturas.CurrentRow.Cells[1].Value.ToString();
            obj.ActualizarFacturas(Factura);
            CargarConsultaInicial();
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(20000, "¡Modificado!", "Registro modificado correctamente",
                ToolTipIcon.Info);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Facturas Factura = new Facturas();
            Factura.IdFacturas = Convert.ToInt32(dgvFacturas.CurrentRow.Cells[0].Value.ToString());
            //Factura.Nombre = dgvFacturas.CurrentRow.Cells[1].Value.ToString();
            obj.EliminarFacturas(Factura);
            CargarConsultaInicial();
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(20000, "¡Eliminado!", "Registro eliminado correctamente",
                ToolTipIcon.Info);
        }

    }
}
