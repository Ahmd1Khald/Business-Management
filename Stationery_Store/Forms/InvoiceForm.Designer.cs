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
            labelDate.Location = new Point(61, 9);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(50, 20);
            labelDate.TabIndex = 0;
            labelDate.Text = "label1";
            // 
            // labelTotalPrice
            // 
            labelTotalPrice.AutoSize = true;
            labelTotalPrice.Location = new Point(61, 48);
            labelTotalPrice.Name = "labelTotalPrice";
            labelTotalPrice.Size = new Size(50, 20);
            labelTotalPrice.TabIndex = 1;
            labelTotalPrice.Text = "label1";
            // 
            // labelTotalQuantity
            // 
            labelTotalQuantity.AutoSize = true;
            labelTotalQuantity.Location = new Point(61, 88);
            labelTotalQuantity.Name = "labelTotalQuantity";
            labelTotalQuantity.Size = new Size(50, 20);
            labelTotalQuantity.TabIndex = 2;
            labelTotalQuantity.Text = "label1";
            // 
            // invoiceGridView
            // 
            invoiceGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            invoiceGridView.Location = new Point(12, 133);
            invoiceGridView.Name = "invoiceGridView";
            invoiceGridView.RowHeadersWidth = 51;
            invoiceGridView.Size = new Size(776, 188);
            invoiceGridView.TabIndex = 3;
            // 
            // printButton
            // 
            printButton.Location = new Point(84, 377);
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