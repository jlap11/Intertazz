﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Intertazz.Formularios
{
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
          
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            productMaintenanceView frm = new productMaintenanceView();
            frm.ShowDialog();
           // frm.Update = false;
            //ShowProducts();
            //ShowTotal();
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {

        }
    }
}
