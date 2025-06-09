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
            invoiceGridView = new DataGridView();
            printButton = new Button();
            ((System.ComponentModel.ISupportInitialize)invoiceGridView).BeginInit();
            SuspendLayout();
            // 
            // invoiceGridView
            // 
            invoiceGridView.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            invoiceGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            invoiceGridView.GridColor = SystemColors.ScrollBar;
            invoiceGridView.Location = new Point(12, 12);
            invoiceGridView.Name = "invoiceGridView";
            invoiceGridView.ReadOnly = true;
            invoiceGridView.RightToLeft = RightToLeft.Yes;
            invoiceGridView.RowHeadersWidth = 51;
            invoiceGridView.Size = new Size(776, 324);
            invoiceGridView.TabIndex = 3;
            // 
            // printButton
            // 
            printButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            printButton.Location = new Point(268, 358);
            printButton.Name = "printButton";
            printButton.Size = new Size(276, 53);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "InvoiceForm";
            Text = "InvoiceForm";
            ((System.ComponentModel.ISupportInitialize)invoiceGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView invoiceGridView;
        private Button printButton;
    }
}