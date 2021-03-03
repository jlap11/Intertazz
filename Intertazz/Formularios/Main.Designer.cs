
namespace Intertazz.Formularios
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.PMenuVertical = new System.Windows.Forms.Panel();
            this.pnlSubProduct = new System.Windows.Forms.Panel();
            this.btnConsultProduct = new System.Windows.Forms.Button();
            this.btnNewProduct = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.PContenedor = new System.Windows.Forms.Panel();
            this.PMenuVertical.SuspendLayout();
            this.pnlSubProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PMenuVertical
            // 
            this.PMenuVertical.AutoScroll = true;
            this.PMenuVertical.BackColor = System.Drawing.Color.Black;
            this.PMenuVertical.Controls.Add(this.pnlSubProduct);
            this.PMenuVertical.Controls.Add(this.btnProductos);
            this.PMenuVertical.Controls.Add(this.btnInventario);
            this.PMenuVertical.Controls.Add(this.pictureBox1);
            this.PMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.PMenuVertical.Location = new System.Drawing.Point(0, 0);
            this.PMenuVertical.Name = "PMenuVertical";
            this.PMenuVertical.Size = new System.Drawing.Size(220, 479);
            this.PMenuVertical.TabIndex = 1;
            // 
            // pnlSubProduct
            // 
            this.pnlSubProduct.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlSubProduct.Controls.Add(this.btnConsultProduct);
            this.pnlSubProduct.Controls.Add(this.btnNewProduct);
            this.pnlSubProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubProduct.Location = new System.Drawing.Point(0, 238);
            this.pnlSubProduct.Name = "pnlSubProduct";
            this.pnlSubProduct.Size = new System.Drawing.Size(220, 70);
            this.pnlSubProduct.TabIndex = 0;
            // 
            // btnConsultProduct
            // 
            this.btnConsultProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultProduct.FlatAppearance.BorderSize = 0;
            this.btnConsultProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnConsultProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultProduct.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.btnConsultProduct.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConsultProduct.Location = new System.Drawing.Point(0, 31);
            this.btnConsultProduct.Name = "btnConsultProduct";
            this.btnConsultProduct.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnConsultProduct.Size = new System.Drawing.Size(220, 31);
            this.btnConsultProduct.TabIndex = 1;
            this.btnConsultProduct.Text = "Consultar Producto";
            this.btnConsultProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultProduct.UseVisualStyleBackColor = true;
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewProduct.FlatAppearance.BorderSize = 0;
            this.btnNewProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewProduct.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.btnNewProduct.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNewProduct.Location = new System.Drawing.Point(0, 0);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnNewProduct.Size = new System.Drawing.Size(220, 31);
            this.btnNewProduct.TabIndex = 0;
            this.btnNewProduct.Text = "Nuevo Producto";
            this.btnNewProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewProduct.UseVisualStyleBackColor = true;
            this.btnNewProduct.Click += new System.EventHandler(this.btnNewProduct_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.Black;
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(0, 207);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProductos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnProductos.Size = new System.Drawing.Size(220, 31);
            this.btnProductos.TabIndex = 3;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.Black;
            this.btnInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Location = new System.Drawing.Point(0, 176);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInventario.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnInventario.Size = new System.Drawing.Size(220, 31);
            this.btnInventario.TabIndex = 1;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PContenedor
            // 
            this.PContenedor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PContenedor.Location = new System.Drawing.Point(220, 0);
            this.PContenedor.Name = "PContenedor";
            this.PContenedor.Size = new System.Drawing.Size(1016, 479);
            this.PContenedor.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1236, 479);
            this.Controls.Add(this.PContenedor);
            this.Controls.Add(this.PMenuVertical);
            this.Name = "Main";
            this.Text = "Main";
            this.PMenuVertical.ResumeLayout(false);
            this.pnlSubProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PMenuVertical;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Panel pnlSubProduct;
        private System.Windows.Forms.Button btnConsultProduct;
        private System.Windows.Forms.Button btnNewProduct;
        private System.Windows.Forms.Panel PContenedor;
    }
}