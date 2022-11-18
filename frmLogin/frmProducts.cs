using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmProducts : Form
    {
        IProductRepository productRepository = new ProductRepository();
        BindingSource source;
        public frmProducts()
        {
            InitializeComponent();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            txtProductId.Enabled = false;
            LoadProductList();
        }

        public void ClearText()
        {
            txtProductId.Text = string.Empty;
            txtCategoryId.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtWeight.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtUnitsInStock.Text = string.Empty;
        }

        public ProductObject GetProductObject()
        {
            ProductObject product = null;
            try
            {
                product = new ProductObject
                {
                    ProductID = int.Parse(txtProductId.Text),
                    CategoryID = int.Parse(txtCategoryId.Text),
                    ProductName = txtProductName.Text,
                    Weight = txtWeight.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitsInStock = int.Parse(txtUnitsInStock.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Product Object.");
            }
            return product;
        }

        public void LoadProductList()
        {
            var products = productRepository.GetListProducts();
            try
            {
                source = new BindingSource();
                source.DataSource = products;

                txtProductId.DataBindings.Clear();
                txtCategoryId.DataBindings.Clear();
                txtProductName.DataBindings.Clear();
                txtWeight.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtUnitsInStock.DataBindings.Clear();

                txtProductId.DataBindings.Add("Text", source, "ProductID");
                txtCategoryId.DataBindings.Add("Text", source, "CategoryID");
                txtProductName.DataBindings.Add("Text", source, "ProductName");
                txtWeight.DataBindings.Add("Text", source, "Weight");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtUnitsInStock.DataBindings.Add("Text", source, "UnitsInStock");

                dgvProductData.DataSource = null;
                dgvProductData.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load product list.");
            }
        }

        private void dgvProductData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmProductDetail frm = new frmProductDetail
            {
                Text = "Update a product",
                InsertOrUpdate = true,
                productRepository = productRepository,
                ProductInfor = GetProductObject()
            };
            /*if (frm.ShowDialog() == DialogResult.OK)
            {*/
            frm.ShowDialog();
            LoadProductList();
            //}
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmProductDetail frm = new frmProductDetail
            {
                Text = "Add new product",
                productRepository = productRepository,
                InsertOrUpdate = false
            };
            /*if (frm.ShowDialog() == DialogResult.OK)
            {*/
            frm.ShowDialog();
            LoadProductList();
            source.Position = source.Count - 1;
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var product = GetProductObject();
                DialogResult dialog = MessageBox.Show("Do you really want to delete this product?", "Manage Product - Delete Product", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                if (dialog == DialogResult.OK)
                {
                    productRepository.DeleteProduct(product.ProductID);
                    LoadProductList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a product.");
            }
        }

        private void txtSearchByIdOrName_TextChanged(object sender, EventArgs e)
        {
            var products = productRepository.GetListProducts();
            if (txtSearchByUnits.Text.Length != 0)
            {
                txtSearchByUnits.Text = string.Empty;
            }
            try
            {
                var productSearch = new List<ProductObject>();
                foreach (var item in products)
                {
                    if (item.ProductID.ToString().Contains(txtSearchByIdOrName.Text) || item.ProductName.ToUpper().Contains(txtSearchByIdOrName.Text.ToUpper()))
                    {
                        productSearch.Add(item);
                    }
                }

                dgvProductData.DataSource = null;
                dgvProductData.DataSource = productSearch;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search product by ID or Name.");
            }
        }

        private void txtSearchByUnits_TextChanged(object sender, EventArgs e)
        {
            var products = productRepository.GetListProducts();
            if (txtSearchByIdOrName.Text.Length != 0)
            {
                txtSearchByIdOrName.Text = string.Empty;
            }
            try
            {
                var productSearch = new List<ProductObject>();
                foreach (var item in products)
                {
                    if (item.UnitPrice.ToString().Contains(txtSearchByUnits.Text) || item.UnitsInStock.ToString().Contains(txtSearchByUnits.Text))
                    {
                        productSearch.Add(item);
                    }
                }

                dgvProductData.DataSource = null;
                dgvProductData.DataSource = productSearch;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search product by Unit Price Or Units In Stock.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();
    }
}
