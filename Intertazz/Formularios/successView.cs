using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intertazz.Formularios
{
    public partial class successView : Form
    {
        public successView(string message)
        {
            InitializeComponent();
            lblMessage.Text = message;
        }

        private void successView_Load(object sender, EventArgs e)
        {
            formFade.ShowAsyc(this);
        }

        public static void confirmForm(string message)
        {
            successView frm = new successView(message);
            frm.ShowDialog();
        }

        private void closeSuccess_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
