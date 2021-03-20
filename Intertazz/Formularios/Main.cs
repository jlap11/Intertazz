using System;
using System.Drawing;
using System.Windows.Forms;


namespace Intertazz.Formularios
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        #region Personalizacion
        private void Main_Load(object sender, EventArgs e)
        {
            
        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            informationView message = new informationView("¿SEGURO QUE DESEA SALIR?");
            DialogResult result = message.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }

        }

        private Form FormActive = null;
        private void showFormInWrapper(Form FormSon)
        {
            if (FormActive != null)
                FormActive.Close();
            FormActive = FormSon;
            FormSon.TopLevel = false;
            if (this.PContenedor.Controls.Count > 0)
                this.PContenedor.Controls.RemoveAt(0);
            FormSon.Dock = DockStyle.Fill;
            PContenedor.Controls.Add(FormSon);
            PContenedor.Tag = FormSon;
            FormSon.BringToFront();
            FormSon.Show();
        }
        #endregion
        #region Eventos
        private void btnProduct_Click(object sender, EventArgs e)
        {
            showFormInWrapper(new frmProducto());
        }
        #endregion
    }
}
