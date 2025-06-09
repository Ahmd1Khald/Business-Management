namespace Stationery_Store.Forms
{
    partial class InvoiceForm
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
            labelDate = new Label();
            labelTotalPrice = new Label();
            labelTotalQuantity = new Label();
            invoiceGridView = new DataGridView();
            printButton = new Button();
            ((System.ComponentModel.ISupportInitialize)invoiceGridView).BeginInit();
            SuspendLayout();
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            labelDate.Location = new Point(713, 19);
            labelDate.Name = "labelDate";
            labelDate.RightToLeft = RightToLeft.Yes;
            labelDate.Size = new Size(59, 23);
            labelDate.TabIndex = 0;
            labelDate.Text = "label1";
            // 
            // labelTotalPrice
            // 
            labelTotalPrice.AutoSize = true;
            labelTotalPrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            labelTotalPrice.Location = new Point(713, 58);
            labelTotalPrice.Name = "labelTotalPrice";
            labelTotalPrice.RightToLeft = RightToLeft.Yes;
            labelTotalPrice.Size = new Size(59, 23);
            labelTotalPrice.TabIndex = 1;
            labelTotalPrice.Text = "label1";
            // 
            // labelTotalQuantity
            // 
            labelTotalQuantity.AutoSize = true;
            labelTotalQuantity.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            labelTotalQuantity.Location = new Point(713, 98);
            labelTotalQuantity.Name = "labelTotalQuantity";
            labelTotalQuantity.RightToLeft = RightToLeft.Yes;
            labelTotalQuantity.Size = new Size(59, 23);
            labelTotalQuantity.TabIndex = 2;
            labelTotalQuantity.Text = "label1";
            // 
            // invoiceGridView
            // 
            invoiceGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            invoiceGridView.Location = new Point(12, 148);
            invoiceGridView.Name = "invoiceGridView";
            invoiceGridView.RowHeadersWidth = 51;
            invoiceGridView.Size = new Size(776, 188);
            invoiceGridView.TabIndex = 3;
            // 
            // printButton
            // 
            printButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            printButton.Location = new Point(268, 358);
            printButton.Name = "printButton";
            printButton.Size = new Size(276, 45);
            printButton.TabIndex = 4;
            printButton.Text = "طباعة";
            printButton.UseVisualStyleBackColor = true;
            printButton.Click += printButton_Click;
            // 
            // InvoiceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(printButton);
            Controls.Add(invoiceGridView);
            Controls.Add(labelTotalQuantity);
            Controls.Add(labelTotalPrice);
            Controls.Add(labelDate);
            Name = "InvoiceForm";
            Text = "InvoiceForm";
            ((System.ComponentModel.ISupportInitialize)invoiceGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDate;
        private Label labelTotalPrice;
        private Label labelTotalQuantity;
        private DataGridView invoiceGridView;
        private Button printButton;
    }
}