
namespace Intertazz.Formularios
{
    partial class ctlFacturaCrear
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctlFacturaCrear));
            this.pnlNuevo = new System.Windows.Forms.Panel();
            this.lblErrorCrear = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCrearNombre = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pnlNuevo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNuevo
            // 
            this.pnlNuevo.Controls.Add(this.lblErrorCrear);
            this.pnlNuevo.Controls.Add(this.btnCrear);
            this.pnlNuevo.Controls.Add(this.label2);
            this.pnlNuevo.Controls.Add(this.txtCrearNombre);
            this.pnlNuevo.Location = new System.Drawing.Point(22, 20);
            this.pnlNuevo.Name = "pnlNuevo";
            this.pnlNuevo.Size = new System.Drawing.Size(800, 182);
            this.pnlNuevo.TabIndex = 7;
            // 
            // lblErrorCrear
            // 
            this.lblErrorCrear.AutoSize = true;
            this.lblErrorCrear.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblErrorCrear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblErrorCrear.Location = new System.Drawing.Point(488, 84);
            this.lblErrorCrear.Name = "lblErrorCrear";
            this.lblErrorCrear.Size = new System.Drawing.Size(204, 13);
            this.lblErrorCrear.TabIndex = 13;
            this.lblErrorCrear.Text = "¡Debe completar todos los campos!";
            this.lblErrorCrear.Visible = false;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(704, 79);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 12;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre";
            // 
            // txtCrearNombre
            // 
            this.txtCrearNombre.Location = new System.Drawing.Point(133, 42);
            this.txtCrearNombre.Name = "txtCrearNombre";
            this.txtCrearNombre.Size = new System.Drawing.Size(100, 20);
            this.txtCrearNombre.TabIndex = 10;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // ctlFacturaCrear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.pnlNuevo);
            this.Name = "ctlFacturaCrear";
            this.Size = new System.Drawing.Size(857, 251);
            this.pnlNuevo.ResumeLayout(false);
            this.pnlNuevo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNuevo;
        private System.Windows.Forms.Label lblErrorCrear;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCrearNombre;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}
