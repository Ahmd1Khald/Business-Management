using System;
using System.Drawing;
using System.Windows.Forms;

namespace Stationery_Store.Forms
{
    partial class ProductsForm
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
            filterPanel = new Panel();
            stockStatusComboBox = new ComboBox();
            lblStockStatus = new Label();
            txtMaxPrice = new TextBox();
            lblPriceRange = new Label();
            txtMinPrice = new TextBox();
            categoryComboBox = new ComboBox();
            lblCategory = new Label();
            searchTextBox = new TextBox();
            lblSearch = new Label();
            productsGridView = new DataGridView();
            totalProductsLabel = new Label();
            btnAddProduct = new Button();
            btnEditProduct = new Button();
            btnDeleteProduct = new Button();
            pnlNoProductsMessage = new Panel();
            flowLayoutPanelNoProducts = new FlowLayoutPanel();
            lblNoProductsText = new Label();
            btnAddNewProductInline = new Button();
            filterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productsGridView).BeginInit();
            pnlNoProductsMessage.SuspendLayout();
            flowLayoutPanelNoProducts.SuspendLayout();
            SuspendLayout();
            // 
            // filterPanel
            // 
            filterPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            filterPanel.Controls.Add(stockStatusComboBox);
            filterPanel.Controls.Add(lblStockStatus);
            filterPanel.Controls.Add(txtMaxPrice);
            filterPanel.Controls.Add(lblPriceRange);
            filterPanel.Controls.Add(txtMinPrice);
            filterPanel.Controls.Add(categoryComboBox);
            filterPanel.Controls.Add(lblCategory);
            filterPanel.Controls.Add(searchTextBox);
            filterPanel.Controls.Add(lblSearch);
            filterPanel.Location = new Point(20, 0);
            filterPanel.Margin = new Padding(3, 4, 3, 4);
            filterPanel.Name = "filterPanel";
            filterPanel.RightToLeft = RightToLeft.Yes;
            filterPanel.Size = new Size(770, 100);
            filterPanel.TabIndex = 4;
            // 
            // stockStatusComboBox
            // 
            stockStatusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            stockStatusComboBox.Font = new Font("Segoe UI", 10F);
            stockStatusComboBox.FormattingEnabled = true;
            stockStatusComboBox.Location = new Point(446, 50);
            stockStatusComboBox.Margin = new Padding(3, 4, 3, 4);
            stockStatusComboBox.Name = "stockStatusComboBox";
            stockStatusComboBox.Size = new Size(132, 31);
            stockStatusComboBox.TabIndex = 8;
            // 
            // lblStockStatus
            // 
            lblStockStatus.AutoSize = true;
            lblStockStatus.Font = new Font("Segoe UI", 10F);
            lblStockStatus.Location = new Point(474, 19);
            lblStockStatus.Name = "lblStockStatus";
            lblStockStatus.Size = new Size(104, 23);
            lblStockStatus.TabIndex = 7;
            lblStockStatus.Text = "حالة المخزون:";
            // 
            // txtMaxPrice
            // 
            txtMaxPrice.Font = new Font("Segoe UI", 10F);
            txtMaxPrice.Location = new Point(340, 50);
            txtMaxPrice.Margin = new Padding(3, 4, 3, 4);
            txtMaxPrice.Name = "txtMaxPrice";
            txtMaxPrice.PlaceholderText = "أقصى سعر";
            txtMaxPrice.Size = new Size(100, 30);
            txtMaxPrice.TabIndex = 6;
            // 
            // lblPriceRange
            // 
            lblPriceRange.AutoSize = true;
            lblPriceRange.Font = new Font("Segoe UI", 10F);
            lblPriceRange.Location = new Point(343, 19);
            lblPriceRange.Name = "lblPriceRange";
            lblPriceRange.Size = new Size(97, 23);
            lblPriceRange.TabIndex = 5;
            lblPriceRange.Text = "نطاق السعر:";
            lblPriceRange.Click += lblPriceRange_Click;
            // 
            // txtMinPrice
            // 
            txtMinPrice.Font = new Font("Segoe UI", 10F);
            txtMinPrice.Location = new Point(230, 50);
            txtMinPrice.Margin = new Padding(3, 4, 3, 4);
            txtMinPrice.Name = "txtMinPrice";
            txtMinPrice.PlaceholderText = "أدنى سعر";
            txtMinPrice.Size = new Size(100, 30);
            txtMinPrice.TabIndex = 4;
            // 
            // categoryComboBox
            // 
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.Font = new Font("Segoe UI", 10F);
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(10, 50);
            categoryComboBox.Margin = new Padding(3, 4, 3, 4);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(200, 31);
            categoryComboBox.TabIndex = 3;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 10F);
            lblCategory.Location = new Point(162, 19);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(72, 23);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "الأصناف:";
            // 
            // searchTextBox
            // 
            searchTextBox.Font = new Font("Segoe UI", 10F);
            searchTextBox.Location = new Point(584, 51);
            searchTextBox.Margin = new Padding(3, 4, 3, 4);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "ابحث عن منتج...";
            searchTextBox.Size = new Size(169, 30);
            searchTextBox.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10F);
            lblSearch.Location = new Point(689, 19);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(46, 23);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "بحث:";
            // 
            // productsGridView
            // 
            productsGridView.AllowUserToAddRows = false;
            productsGridView.AllowUserToDeleteRows = false;
            productsGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            productsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productsGridView.BackgroundColor = Color.White;
            productsGridView.BorderStyle = BorderStyle.Fixed3D;
            productsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsGridView.Location = new Point(10, 125);
            productsGridView.Margin = new Padding(3, 4, 3, 4);
            productsGridView.MultiSelect = false;
            productsGridView.Name = "productsGridView";
            productsGridView.ReadOnly = true;
            productsGridView.RightToLeft = RightToLeft.Yes;
            productsGridView.RowHeadersWidth = 51;
            productsGridView.RowTemplate.Height = 35;
            productsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productsGridView.Size = new Size(770, 294);
            productsGridView.TabIndex = 0;
            // 
            // totalProductsLabel
            // 
            totalProductsLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            totalProductsLabel.AutoSize = true;
            totalProductsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            totalProductsLabel.Location = new Point(10, 432);
            totalProductsLabel.Name = "totalProductsLabel";
            totalProductsLabel.Size = new Size(172, 28);
            totalProductsLabel.TabIndex = 3;
            totalProductsLabel.Text = "إجمالي المنتجات: 0";
            // 
            // btnAddProduct
            // 
            btnAddProduct.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddProduct.Location = new Point(670, 432);
            btnAddProduct.Margin = new Padding(3, 4, 3, 4);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(110, 44);
            btnAddProduct.TabIndex = 5;
            btnAddProduct.Text = "إضافة منتج جديد";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnEditProduct
            // 
            btnEditProduct.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditProduct.Location = new Point(550, 432);
            btnEditProduct.Margin = new Padding(3, 4, 3, 4);
            btnEditProduct.Name = "btnEditProduct";
            btnEditProduct.Size = new Size(110, 44);
            btnEditProduct.TabIndex = 6;
            btnEditProduct.Text = "تعديل المنتج";
            btnEditProduct.UseVisualStyleBackColor = true;
            btnEditProduct.Click += btnEditProduct_Click;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeleteProduct.Location = new Point(430, 432);
            btnDeleteProduct.Margin = new Padding(3, 4, 3, 4);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(110, 44);
            btnDeleteProduct.TabIndex = 7;
            btnDeleteProduct.Text = "حذف المنتج";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // pnlNoProductsMessage
            // 
            pnlNoProductsMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            pnlNoProductsMessage.Controls.Add(flowLayoutPanelNoProducts);
            pnlNoProductsMessage.Name = "pnlNoProductsMessage";
            pnlNoProductsMessage.TabIndex = 8;
            pnlNoProductsMessage.Visible = false;
            pnlNoProductsMessage.AutoSize = true;
            pnlNoProductsMessage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            // 
            // flowLayoutPanelNoProducts
            // 
            flowLayoutPanelNoProducts.Controls.Add(lblNoProductsText);
            flowLayoutPanelNoProducts.Controls.Add(btnAddNewProductInline);
            flowLayoutPanelNoProducts.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanelNoProducts.Name = "flowLayoutPanelNoProducts";
            flowLayoutPanelNoProducts.TabIndex = 0;
            flowLayoutPanelNoProducts.WrapContents = false;
            flowLayoutPanelNoProducts.AutoSize = true;
            flowLayoutPanelNoProducts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanelNoProducts.Padding = new Padding(0, 10, 0, 0);
            // 
            // lblNoProductsText
            // 
            lblNoProductsText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblNoProductsText.ForeColor = System.Drawing.Color.Green;
            lblNoProductsText.AutoSize = true;
            lblNoProductsText.Margin = new System.Windows.Forms.Padding(0, 5, 0, 10);
            lblNoProductsText.Name = "lblNoProductsText";
            lblNoProductsText.TabIndex = 0;
            lblNoProductsText.Text = "لا توجد منتجات لعرضها.";
            lblNoProductsText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddNewProductInline
            // 
            btnAddNewProductInline.Name = "btnAddNewProductInline";
            btnAddNewProductInline.Size = new System.Drawing.Size(220, 55);
            btnAddNewProductInline.TabIndex = 1;
            btnAddNewProductInline.Text = "إضافة منتج جديد";
            btnAddNewProductInline.UseVisualStyleBackColor = true;
            btnAddNewProductInline.Click += btnAddNewProductInline_Click;
            btnAddNewProductInline.Margin = new System.Windows.Forms.Padding(0, 10, 0, 3);
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 532);
            Controls.Add(btnDeleteProduct);
            Controls.Add(btnEditProduct);
            Controls.Add(btnAddProduct);
            Controls.Add(filterPanel);
            Controls.Add(totalProductsLabel);
            Controls.Add(pnlNoProductsMessage);
            Controls.Add(productsGridView);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProductsForm";
            RightToLeft = RightToLeft.Yes;
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "المنتجات";
            Load += ProductsForm_Load;
            filterPanel.ResumeLayout(false);
            filterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)productsGridView).EndInit();
            pnlNoProductsMessage.ResumeLayout(false);
            flowLayoutPanelNoProducts.ResumeLayout(false);
            pnlNoProductsMessage.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.DataGridView productsGridView;
        private System.Windows.Forms.Label totalProductsLabel;
        private System.Windows.Forms.ComboBox stockStatusComboBox;
        private System.Windows.Forms.Label lblStockStatus;
        private System.Windows.Forms.TextBox txtMaxPrice;
        private System.Windows.Forms.Label lblPriceRange;
        private System.Windows.Forms.TextBox txtMinPrice;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Panel pnlNoProductsMessage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNoProducts;
        private System.Windows.Forms.Label lblNoProductsText;
        private System.Windows.Forms.Button btnAddNewProductInline;
    }
} 