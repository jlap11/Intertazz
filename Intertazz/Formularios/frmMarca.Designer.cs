
namespace Intertazz.Formularios
{
    partial class frmMarca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMarca));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlAtr = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConsNombre = new System.Windows.Forms.TextBox();
            this.pnlCod = new System.Windows.Forms.Panel();
            this.txtConsCod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            this.pnlAtr.SuspendLayout();
            this.pnlCod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(695, 59);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.pnlAtr);
            this.groupBox1.Controls.Add(this.pnlCod);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 122);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta";
            // 
            // pnlAtr
            // 
            this.pnlAtr.Controls.Add(this.label1);
            this.pnlAtr.Controls.Add(this.txtConsNombre);
            this.pnlAtr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlAtr.Location = new System.Drawing.Point(222, 16);
            this.pnlAtr.Name = "pnlAtr";
            this.pnlAtr.Size = new System.Drawing.Size(242, 87);
            this.pnlAtr.TabIndex = 8;
            this.pnlAtr.Click += new System.EventHandler(this.pnlAtr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // txtConsNombre
            // 
            this.txtConsNombre.Enabled = false;
            this.txtConsNombre.Location = new System.Drawing.Point(53, 41);
            this.txtConsNombre.Name = "txtConsNombre";
            this.txtConsNombre.Size = new System.Drawing.Size(100, 20);
            this.txtConsNombre.TabIndex = 3;
            // 
            // pnlCod
            // 
            this.pnlCod.Controls.Add(this.txtConsCod);
            this.pnlCod.Controls.Add(this.label3);
            this.pnlCod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlCod.Location = new System.Drawing.Point(18, 16);
            this.pnlCod.Name = "pnlCod";
            this.pnlCod.Size = new System.Drawing.Size(206, 87);
            this.pnlCod.TabIndex = 7;
            this.pnlCod.Click += new System.EventHandler(this.pnlCod_Click);
            // 
            // txtConsCod
            // 
            this.txtConsCod.Enabled = false;
            this.txtConsCod.Location = new System.Drawing.Point(58, 41);
            this.txtConsCod.Name = "txtConsCod";
            this.txtConsCod.Size = new System.Drawing.Size(100, 20);
            this.txtConsCod.TabIndex = 5;
            this.txtConsCod.TextChanged += new System.EventHandler(this.txtConsCod_TextChanged);
            this.txtConsCod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsCod_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cod. Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(314, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Marcas registradas";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(265, 404);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(468, 404);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Location = new System.Drawing.Point(234, 204);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.Size = new System.Drawing.Size(335, 170);
            this.dgvMarcas.TabIndex = 9;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // frmMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMarcas);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMarca";
            this.Text = "frmMarca";
            this.groupBox1.ResumeLayout(false);
            this.pnlAtr.ResumeLayout(false);
            this.pnlAtr.PerformLayout();
            this.pnlCod.ResumeLayout(false);
            this.pnlCod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConsNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConsCod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlCod;
        private System.Windows.Forms.Panel pnlAtr;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}