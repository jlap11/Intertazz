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
    public partial class ctlPrecioCrear : UserControl
    {
        Bussiness obj = new Bussiness();
        public ctlPrecioCrear()
        {
            InitializeComponent();
            lblErrorCrear.Visible = false;
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (txtCrearNombre.Text.Trim() != "")
            {
                lblErrorCrear.Visible = false;
                Precio obj1 = new Precio();
                //obj1.Nombre = txtCrearNombre.Text.Trim();
                obj1 = obj.CrearPrecio(obj1);
                txtCrearNombre.Text = "";
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(20000, "¡Registrado!", "Registro insertado correctamente",
                    ToolTipIcon.Info);
            }
            else
            {
                lblErrorCrear.Visible = true;
            }
        }


    }
}