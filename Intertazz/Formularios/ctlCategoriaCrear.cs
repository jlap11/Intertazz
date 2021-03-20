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
    public partial class ctlCategoriaCrear : UserControl
    {
        Bussiness obj = new Bussiness();
        public ctlCategoriaCrear()
        {
            InitializeComponent();
            lblErrorCrear.Visible = false;
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (txtCrearNombre.Text.Trim() != "")
            {
                lblErrorCrear.Visible = false;
                Categoria obj1 = new Categoria();
                obj1.Nombre = txtCrearNombre.Text.Trim();
                obj1 = obj.CrearCategoria(obj1);
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
