using Stationery_Store.Entities;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace Stationery_Store.Forms
{
    public partial class ProductDetailsForm : Form
    {
        private Context context; // Use a local context instance
        private Product currentProduct; // To hold the product being edited

        // Constructor for adding a new product
        public ProductDetailsForm()
        {
            InitializeComponent();
            context = new Context(); // Initialize context
            LoadCategories();
            this.Text = "إضافة منتج جديد";
        }

        // Constructor for editing an existing product
        public ProductDetailsForm(int productID)
        {
            InitializeComponent();
            context = new Context(); // Initialize context
            LoadCategories();
            this.Text = "تعديل المنتج";
            
            // Fetch the product within this form's context
            this.currentProduct = context.Products.Find(productID);

            if (this.currentProduct != null)
            {
                LoadProductDetails(this.currentProduct);
            }
            else
            {
                MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void LoadCategories()
        {
            var categories = context.Categories.ToList();
            categoryComboBox.DataSource = categories;
            categoryComboBox.DisplayMember = "Name";
            categoryComboBox.ValueMember = "ID";
        }

        private void LoadProductDetails(Product product)
        {
            txtName.Text = product.Name;
            txtDescription.Text = product.Description;
            txtPrice.Text = product.Price.ToString();
            txtQuantity.Text = product.Quantity.ToString();
            categoryComboBox.SelectedValue = product.CategoryId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                if (currentProduct == null)
                {
                    // Add new product
                    var newProduct = new Product
                    {
                        Name = txtName.Text,
                        Description = txtDescription.Text,
                        Price = double.Parse(txtPrice.Text),
                        Quantity = int.Parse(txtQuantity.Text),
                        CategoryId = (int)categoryComboBox.SelectedValue
                    };
                    context.Products.Add(newProduct);
                }
                else
                {
                    // Update existing product
                    currentProduct.Name = txtName.Text;
                    currentProduct.Description = txtDescription.Text;
                    currentProduct.Price = double.Parse(txtPrice.Text);
                    currentProduct.Quantity = int.Parse(txtQuantity.Text);
                    currentProduct.CategoryId = (int)categoryComboBox.SelectedValue;
                    // No need to call context.Products.Update(currentProduct) explicitly here
                    // EF Core tracks changes to currentProduct since it was fetched by this context
                }

                context.SaveChanges();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool ValidateInputs()
        {
            // Basic validation (can be expanded)
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter product name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPrice.Text) || !double.TryParse(txtPrice.Text, out _))
            {
                MessageBox.Show("Please enter a valid price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtQuantity.Text) || !int.TryParse(txtQuantity.Text, out _))
            {
                MessageBox.Show("Please enter a valid quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();
                return false;
            }
             if (categoryComboBox.SelectedValue == null || (int)categoryComboBox.SelectedValue == 0)
            {
                MessageBox.Show("Please select a category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                categoryComboBox.Focus();
                return false;
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                context?.Dispose(); // Dispose the context when the form is disposed
            }
            base.Dispose(disposing);
        }
    }
} 