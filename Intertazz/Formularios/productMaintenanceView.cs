//using Business;
//using Entities;
using System;
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
    public partial class productMaintenanceView : Form
    {
        frmProducto frm = new frmProducto();
        //ProductEntities entities = new ProductEntities();
        //ProductBusiness business = new ProductBusiness();

        //public bool Update = false;

        public productMaintenanceView()
        {
           /* InitializeComponent();
            ListCategories();
            ListBrands();*/
        }

        public void ListCategories()
        {
          /*  CategoryBusiness business = new CategoryBusiness();
            cmbCategories.DataSource = business.ListingCategories("");
            cmbCategories.ValueMember = "Id";
            cmbCategories.DisplayMember = "Name";*/
        }

        public void ListBrands()
        {
            /*BrandBusiness business = new BrandBusiness();
            cmbBrands.DataSource = business.ListingBrands("");
            cmbBrands.ValueMember = "Id";*/
        }

        private void closeFormCategory_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           /* if (Update == false)
            {
                try
                {
                    entities.Product = txtProduct.Text;
                    entities.Price_buy = Convert.ToDecimal(txtPriceBuy.Text);
                    entities.Price_sale = Convert.ToDecimal(txtPriceSale.Text);
                    entities.Stock = Convert.ToInt32(txtStock.Text);
                    entities.Idcategory = Convert.ToInt32(cmbCategories.SelectedValue);
                    entities.Idbrand = Convert.ToInt32(cmbBrands.SelectedValue);

                    business.CreatingProducts(entities);
                    successView.confirmForm("PRODUCTO GUARDADO");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar la categoria" + ex);
                }
            }
            if (Update == true)
            {
                try
                {
                    entities.Id = Convert.ToInt32(txtId.Text);
                    entities.Product = txtProduct.Text;
                    entities.Price_buy = Convert.ToDecimal(txtPriceBuy.Text);
                    entities.Price_sale = Convert.ToDecimal(txtPriceSale.Text);
                    entities.Stock = Convert.ToInt32(txtStock.Text);
                    entities.Idcategory = Convert.ToInt32(cmbCategories.SelectedValue);
                    entities.Idbrand = Convert.ToInt32(cmbBrands.SelectedValue);

                    business.UpdatingProducts(entities);

                    successView.confirmForm("PRODUCTO EDITADO");

                    Close();

                    Update = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar la categoria" + ex);
                }
            }*/
        }
    }
}
