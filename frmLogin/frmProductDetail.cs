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
    public partial class frmProductDetail : Form
    {
        public IProductRepository productRepository { get; set; }
        public ProductCategoryRepository productCategoryRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public ProductObject ProductInfor { get; set; }
        public IProductCategory productCategory = new ProductCategoryRepository();
        public frmProductDetail()
        {
            InitializeComponent();
        }

        private void frmProductDetail_Load(object sender, EventArgs e)
        {

            productCategoryRepository = new ProductCategoryRepository();

            //btnSave.DialogResult = DialogResult.OK;
            btnCancel.DialogResult = DialogResult.Cancel;
            txtProductId.Enabled = false;

            var categoryList = productCategoryRepository.GetCategories();
            foreach (var cate in categoryList)
            {
                cbCategory.Items.Add(cate);
            }

            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryId";
            if (InsertOrUpdate)
            {
                txtProductId.Text = ProductInfor.ProductID.ToString();
                txtProductName.Text = ProductInfor.ProductName;
                // txtCategoryId.Text = ProductInfor.CategoryID.ToString();
                for (int i = 0; i < cbCategory.Items.Count; i++)
                {
                    if (ProductInfor.CategoryID == ((ProductCategoryObject)cbCategory.Items[i]).CategoryId)
                    {
                        cbCategory.SelectedIndex = i;
                    }
                }
                txtWeight.Text = ProductInfor.Weight;
                txtUnitPrice.Text = ProductInfor.UnitPrice.ToString();
                txtUnitsInStock.Text = ProductInfor.UnitsInStock.ToString();
            }
            else
            {
                txtProductId.Text = (productRepository.GetListProducts().Count() + 1).ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var productList = productRepository.GetListProducts();
                if (cbCategory.Text == "" || txtProductName.Text == "" ||
                    txtUnitPrice.Text == "" || txtUnitsInStock.Text == "" ||
                    txtWeight.Text == "")
                {
                    MessageBox.Show("Please fill in all fields before Submitting");
                }

                else
                {

                    var product = new ProductObject
                    {
                        ProductID = int.Parse(txtProductId.Text),
                        ProductName = txtProductName.Text,
                        CategoryID = ((ProductCategoryObject)cbCategory.SelectedItem).CategoryId,
                        Weight = txtWeight.Text,
                        UnitPrice = decimal.Parse(txtUnitPrice.Text),
                        UnitsInStock = int.Parse(txtUnitsInStock.Text)
                    };
                    if (InsertOrUpdate)
                    {
                        productRepository.UpdateProduct(product);
                        Close();
                    }
                    else
                    {
                        var findName = productList
                            .FirstOrDefault(c => c.ProductName.Equals(txtProductName.Text));
                        if (findName == null)
                        {
                            productRepository.AddProduct(product);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Name is exist!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate ? "Update a product." : "Insert new product.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}
