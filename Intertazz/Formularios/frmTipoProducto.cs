﻿using System;
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
    public partial class frmTipoProducto : Form
    {
        Bussiness obj = new Bussiness();
        public frmTipoProducto()
        {
            InitializeComponent();
            CargarConsultaInicial();
            
        }
        private void CargarConsultaInicial()
        {

            dgvTipoProductos.DataSource = obj.ObtenerTipoProducto();
            dgvTipoProductos.Columns["Activo"].Visible=false;
            dgvTipoProductos.Columns["IdTipoProducto"].HeaderText = "Cod. TipoProducto";
            dgvTipoProductos.Columns["IdTipoProducto"].ReadOnly =true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            TipoProducto TipoProducto = new TipoProducto();
            TipoProducto.Nombre = txtConsNombre.Text.Trim();
            TipoProducto.IdTipoProcuto = Convert.ToInt32(txtConsCod.Text.Trim()=="" ? "0" : txtConsCod.Text.Trim());
            dgvTipoProductos.DataSource= obj.ObtenerTipoProducto(TipoProducto);
            dgvTipoProductos.Columns["IdTipoProducto"].HeaderText = "Cod. TipoProducto";
            dgvTipoProductos.Columns["IdTipoProducto"].ReadOnly = true;
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
            TipoProducto TipoProducto = new TipoProducto();
            TipoProducto.IdTipoProcuto = Convert.ToInt32(dgvTipoProductos.CurrentRow.Cells[0].Value.ToString());
            TipoProducto.Nombre = dgvTipoProductos.CurrentRow.Cells[1].Value.ToString();
            obj.ActualizarTipoProducto(TipoProducto);
            CargarConsultaInicial();
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(20000, "¡Modificado!", "Registro modificado correctamente",
                ToolTipIcon.Info);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            TipoProducto TipoProducto = new TipoProducto();
            TipoProducto.IdTipoProcuto = Convert.ToInt32(dgvTipoProductos.CurrentRow.Cells[0].Value.ToString());
            TipoProducto.Nombre = dgvTipoProductos.CurrentRow.Cells[1].Value.ToString();
            obj.EliminarTipoProducto(TipoProducto);
            CargarConsultaInicial();
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(20000, "¡Eliminado!", "Registro eliminado correctamente",
                ToolTipIcon.Info);
        }

    }
}