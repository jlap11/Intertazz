using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Views;

namespace Presentacion.Forms
{
    public partial class Products : Form
    {
        public Products()
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
    }
}
