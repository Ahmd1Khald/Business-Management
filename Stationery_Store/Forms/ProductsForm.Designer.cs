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
            paginationPanel = new Panel();
            btnFirst = new Button();
            btnPrev = new Button();
            btnNext = new Button();
            btnLast = new Button();
            lblPageInfo = new Label();
            filterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productsGridView).BeginInit();
            pnlNoProductsMessage.SuspendLayout();
            flowLayoutPanelNoProducts.SuspendLayout();
            paginationPanel.SuspendLayout();
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
            filterPanel.Location = new Point(10, 18);
            filterPanel.Name = "filterPanel";
            filterPanel.Size = new Size(1187, 100);
            filterPanel.TabIndex = 8;
            // 
            // stockStatusComboBox
            // 
            stockStatusComboBox.Font = new Font("Segoe UI", 10F);
            stockStatusComboBox.FormattingEnabled = true;
            stockStatusComboBox.Location = new Point(12, 40);
            stockStatusComboBox.Name = "stockStatusComboBox";
            stockStatusComboBox.Size = new Size(197, 31);
            stockStatusComboBox.TabIndex = 7;
            // 
            // lblStockStatus
            // 
            lblStockStatus.AutoSize = true;
            lblStockStatus.Font = new Font("Segoe UI", 10F);
            lblStockStatus.Location = new Point(215, 44);
            lblStockStatus.Name = "lblStockStatus";
            lblStockStatus.Size = new Size(104, 23);
            lblStockStatus.TabIndex = 6;
            lblStockStatus.Text = "حالة المخزون:";
            // 
            // txtMaxPrice
            // 
            txtMaxPrice.Font = new Font("Segoe UI", 10F);
            txtMaxPrice.Location = new Point(346, 41);
            txtMaxPrice.Name = "txtMaxPrice";
            txtMaxPrice.PlaceholderText = "أقصى سعر";
            txtMaxPrice.Size = new Size(100, 30);
            txtMaxPrice.TabIndex = 5;
            // 
            // lblPriceRange
            // 
            lblPriceRange.AutoSize = true;
            lblPriceRange.Font = new Font("Segoe UI", 10F);
            lblPriceRange.Location = new Point(558, 44);
            lblPriceRange.Name = "lblPriceRange";
            lblPriceRange.Size = new Size(97, 23);
            lblPriceRange.TabIndex = 4;
            lblPriceRange.Text = "نطاق السعر:";
            // 
            // txtMinPrice
            // 
            txtMinPrice.Font = new Font("Segoe UI", 10F);
            txtMinPrice.Location = new Point(452, 41);
            txtMinPrice.Name = "txtMinPrice";
            txtMinPrice.PlaceholderText = "أدنى سعر";
            txtMinPrice.Size = new Size(100, 30);
            txtMinPrice.TabIndex = 3;
            // 
            // categoryComboBox
            // 
            categoryComboBox.Font = new Font("Segoe UI", 10F);
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(676, 41);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(180, 31);
            categoryComboBox.TabIndex = 3;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 10F);
            lblCategory.Location = new Point(862, 44);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(72, 23);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "الأصناف:";
            // 
            // searchTextBox
            // 
            searchTextBox.Font = new Font("Segoe UI", 10F);
            searchTextBox.Location = new Point(961, 41);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "ابحث عن منتج...";
            searchTextBox.Size = new Size(169, 30);
            searchTextBox.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10F);
            lblSearch.Location = new Point(1136, 44);
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
            productsGridView.Size = new Size(1187, 465);
            productsGridView.TabIndex = 0;
            // 
            // totalProductsLabel
            // 
            totalProductsLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            totalProductsLabel.AutoSize = true;
            totalProductsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            totalProductsLabel.Location = new Point(10, 668);
            totalProductsLabel.Name = "totalProductsLabel";
            totalProductsLabel.Size = new Size(172, 28);
            totalProductsLabel.TabIndex = 1;
            totalProductsLabel.Text = "إجمالي المنتجات: 0";
            // 
            // btnAddProduct
            // 
            btnAddProduct.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddProduct.BackColor = Color.FromArgb(0, 120, 215);
            btnAddProduct.FlatAppearance.BorderSize = 0;
            btnAddProduct.FlatStyle = FlatStyle.Flat;
            btnAddProduct.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddProduct.ForeColor = Color.White;
            btnAddProduct.Location = new Point(1077, 661);
            btnAddProduct.Margin = new Padding(3, 4, 3, 4);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(120, 35);
            btnAddProduct.TabIndex = 2;
            btnAddProduct.Text = "إضافة منتج جديد";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnEditProduct
            // 
            btnEditProduct.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditProduct.BackColor = Color.DarkOrange;
            btnEditProduct.FlatAppearance.BorderSize = 0;
            btnEditProduct.FlatStyle = FlatStyle.Flat;
            btnEditProduct.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEditProduct.ForeColor = Color.White;
            btnEditProduct.Location = new Point(947, 661);
            btnEditProduct.Margin = new Padding(3, 4, 3, 4);
            btnEditProduct.Name = "btnEditProduct";
            btnEditProduct.Size = new Size(120, 35);
            btnEditProduct.TabIndex = 3;
            btnEditProduct.Text = "تعديل المنتج";
            btnEditProduct.UseVisualStyleBackColor = false;
            btnEditProduct.Click += btnEditProduct_Click;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeleteProduct.BackColor = Color.Firebrick;
            btnDeleteProduct.FlatAppearance.BorderSize = 0;
            btnDeleteProduct.FlatStyle = FlatStyle.Flat;
            btnDeleteProduct.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeleteProduct.ForeColor = Color.White;
            btnDeleteProduct.Location = new Point(817, 661);
            btnDeleteProduct.Margin = new Padding(3, 4, 3, 4);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(120, 35);
            btnDeleteProduct.TabIndex = 4;
            btnDeleteProduct.Text = "حذف المنتج";
            btnDeleteProduct.UseVisualStyleBackColor = false;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // pnlNoProductsMessage
            // 
            pnlNoProductsMessage.Anchor = AnchorStyles.None;
            pnlNoProductsMessage.AutoSize = true;
            pnlNoProductsMessage.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlNoProductsMessage.Controls.Add(flowLayoutPanelNoProducts);
            pnlNoProductsMessage.Location = new Point(453, 285);
            pnlNoProductsMessage.Name = "pnlNoProductsMessage";
            pnlNoProductsMessage.Size = new Size(232, 119);
            pnlNoProductsMessage.TabIndex = 5;
            pnlNoProductsMessage.Visible = false;
            // 
            // flowLayoutPanelNoProducts
            // 
            flowLayoutPanelNoProducts.AutoSize = true;
            flowLayoutPanelNoProducts.Controls.Add(lblNoProductsText);
            flowLayoutPanelNoProducts.Controls.Add(btnAddNewProductInline);
            flowLayoutPanelNoProducts.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelNoProducts.Location = new Point(0, 11);
            flowLayoutPanelNoProducts.Name = "flowLayoutPanelNoProducts";
            flowLayoutPanelNoProducts.Size = new Size(229, 105);
            flowLayoutPanelNoProducts.TabIndex = 0;
            flowLayoutPanelNoProducts.WrapContents = false;
            // 
            // lblNoProductsText
            // 
            lblNoProductsText.AutoSize = true;
            lblNoProductsText.Font = new Font("Segoe UI", 12F);
            lblNoProductsText.ForeColor = Color.DimGray;
            lblNoProductsText.Location = new Point(23, 0);
            lblNoProductsText.Name = "lblNoProductsText";
            lblNoProductsText.Size = new Size(203, 28);
            lblNoProductsText.TabIndex = 0;
            lblNoProductsText.Text = "لا توجد منتجات لعرضها.";
            lblNoProductsText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAddNewProductInline
            // 
            btnAddNewProductInline.Location = new Point(9, 38);
            btnAddNewProductInline.Margin = new Padding(0, 10, 0, 3);
            btnAddNewProductInline.Name = "btnAddNewProductInline";
            btnAddNewProductInline.Size = new Size(220, 55);
            btnAddNewProductInline.TabIndex = 1;
            btnAddNewProductInline.Text = "إضافة منتج جديد";
            btnAddNewProductInline.UseVisualStyleBackColor = true;
            btnAddNewProductInline.Click += btnAddNewProductInline_Click;
            // 
            // paginationPanel
            // 
            paginationPanel.Anchor = AnchorStyles.Bottom;
            paginationPanel.Controls.Add(btnFirst);
            paginationPanel.Controls.Add(btnPrev);
            paginationPanel.Controls.Add(btnNext);
            paginationPanel.Controls.Add(btnLast);
            paginationPanel.Controls.Add(lblPageInfo);
            paginationPanel.Location = new Point(368, 646);
            paginationPanel.Margin = new Padding(3, 4, 3, 4);
            paginationPanel.Name = "paginationPanel";
            paginationPanel.Size = new Size(480, 44);
            paginationPanel.TabIndex = 9;
            // 
            // btnFirst
            // 
            btnFirst.Anchor = AnchorStyles.None;
            btnFirst.BackColor = Color.FromArgb(180, 230, 230, 230);
            btnFirst.FlatAppearance.BorderSize = 0;
            btnFirst.FlatStyle = FlatStyle.Flat;
            btnFirst.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnFirst.ForeColor = Color.Black;
            btnFirst.Location = new Point(400, 8);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(70, 28);
            btnFirst.TabIndex = 1;
            btnFirst.Text = "الأول";
            btnFirst.UseVisualStyleBackColor = false;
            // 
            // btnPrev
            // 
            btnPrev.Anchor = AnchorStyles.None;
            btnPrev.BackColor = Color.FromArgb(180, 230, 230, 230);
            btnPrev.FlatAppearance.BorderSize = 0;
            btnPrev.FlatStyle = FlatStyle.Flat;
            btnPrev.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPrev.ForeColor = Color.Black;
            btnPrev.Location = new Point(315, 8);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(80, 28);
            btnPrev.TabIndex = 2;
            btnPrev.Text = "السابق";
            btnPrev.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.None;
            btnNext.BackColor = Color.FromArgb(180, 230, 230, 230);
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNext.ForeColor = Color.Black;
            btnNext.Location = new Point(85, 8);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(80, 28);
            btnNext.TabIndex = 3;
            btnNext.Text = "التالي";
            btnNext.UseVisualStyleBackColor = false;
            // 
            // btnLast
            // 
            btnLast.Anchor = AnchorStyles.None;
            btnLast.BackColor = Color.FromArgb(180, 230, 230, 230);
            btnLast.FlatAppearance.BorderSize = 0;
            btnLast.FlatStyle = FlatStyle.Flat;
            btnLast.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLast.ForeColor = Color.Black;
            btnLast.Location = new Point(0, 8);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(70, 28);
            btnLast.TabIndex = 4;
            btnLast.Text = "الأخير";
            btnLast.UseVisualStyleBackColor = false;
            // 
            // lblPageInfo
            // 
            lblPageInfo.Anchor = AnchorStyles.None;
            lblPageInfo.AutoSize = true;
            lblPageInfo.Font = new Font("Segoe UI", 10F);
            lblPageInfo.Location = new Point(200, 13);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(19, 23);
            lblPageInfo.TabIndex = 5;
            lblPageInfo.Text = "0";
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1217, 703);
            Controls.Add(btnDeleteProduct);
            Controls.Add(btnEditProduct);
            Controls.Add(btnAddProduct);
            Controls.Add(filterPanel);
            Controls.Add(totalProductsLabel);
            Controls.Add(paginationPanel);
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
            pnlNoProductsMessage.PerformLayout();
            flowLayoutPanelNoProducts.ResumeLayout(false);
            flowLayoutPanelNoProducts.PerformLayout();
            paginationPanel.ResumeLayout(false);
            paginationPanel.PerformLayout();
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
        private System.Windows.Forms.Panel paginationPanel;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Label lblPageInfo;
    }
} 