namespace Stationery_Store.Forms
{
    partial class SellForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            SellGridView = new DataGridView();
            AddBtn = new Button();
            productsGridView = new DataGridView();
            SearchTextBox = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            RemoveBtn = new Button();
            TotalQuantity = new Label();
            TotalPrice = new Label();
            SellBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)SellGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // SellGridView
            // 
            SellGridView.AllowUserToAddRows = false;
            SellGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            SellGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            SellGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SellGridView.Location = new Point(557, 23);
            SellGridView.Margin = new Padding(3, 4, 3, 4);
            SellGridView.Name = "SellGridView";
            SellGridView.RightToLeft = RightToLeft.Yes;
            SellGridView.RowHeadersWidth = 51;
            SellGridView.Size = new Size(504, 373);
            SellGridView.TabIndex = 7;
            // 
            // AddBtn
            // 
            AddBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddBtn.BackColor = Color.RoyalBlue;
            AddBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBtn.Location = new Point(157, 415);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(216, 41);
            AddBtn.TabIndex = 2;
            AddBtn.Text = "إضافة";
            AddBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // productsGridView
            // 
            productsGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            productsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsGridView.Location = new Point(11, 132);
            productsGridView.Name = "productsGridView";
            productsGridView.RightToLeft = RightToLeft.Yes;
            productsGridView.RowHeadersWidth = 51;
            productsGridView.Size = new Size(540, 264);
            productsGridView.TabIndex = 3;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            SearchTextBox.Location = new Point(11, 82);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(540, 27);
            SearchTextBox.TabIndex = 0;
            SearchTextBox.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(142, 23);
            label1.Name = "label1";
            label1.Size = new Size(251, 45);
            label1.TabIndex = 1;
            label1.Text = "ابحث بأسم المنتج";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(RemoveBtn);
            panel1.Controls.Add(TotalQuantity);
            panel1.Controls.Add(TotalPrice);
            panel1.Controls.Add(SellBtn);
            panel1.Controls.Add(SellGridView);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(SearchTextBox);
            panel1.Controls.Add(productsGridView);
            panel1.Controls.Add(AddBtn);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1070, 532);
            panel1.TabIndex = 4;
            // 
            // RemoveBtn
            // 
            RemoveBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RemoveBtn.BackColor = Color.Red;
            RemoveBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RemoveBtn.Location = new Point(841, 403);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new Size(220, 39);
            RemoveBtn.TabIndex = 9;
            RemoveBtn.Text = "إزالة من القائمة";
            RemoveBtn.UseVisualStyleBackColor = false;
            RemoveBtn.Click += RemoveBtn_Click_1;
            // 
            // TotalQuantity
            // 
            TotalQuantity.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            TotalQuantity.AutoSize = true;
            TotalQuantity.Location = new Point(958, 351);
            TotalQuantity.Name = "TotalQuantity";
            TotalQuantity.Size = new Size(17, 20);
            TotalQuantity.TabIndex = 8;
            TotalQuantity.Text = "0";
            // 
            // TotalPrice
            // 
            TotalPrice.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            TotalPrice.AutoSize = true;
            TotalPrice.Location = new Point(958, 303);
            TotalPrice.Name = "TotalPrice";
            TotalPrice.Size = new Size(17, 20);
            TotalPrice.TabIndex = 6;
            TotalPrice.Text = "0";
            // 
            // SellBtn
            // 
            SellBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SellBtn.BackColor = Color.Green;
            SellBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SellBtn.Location = new Point(650, 467);
            SellBtn.Name = "SellBtn";
            SellBtn.Size = new Size(295, 53);
            SellBtn.TabIndex = 4;
            SellBtn.Text = "بيع";
            SellBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            SellBtn.UseVisualStyleBackColor = false;
            SellBtn.Click += SellBtn_Click;
            // 
            // SellForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1070, 532);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "SellForm";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sell";
            ((System.ComponentModel.ISupportInitialize)SellGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView SellGridView;
        private Button AddBtn;
        private DataGridView productsGridView;
        private TextBox SearchTextBox;
        private Label label1;
        private Panel panel1;
        private Button SellBtn;
        private Label TotalPrice;
        private Label TotalQuantity;
        private Button RemoveBtn;
    }
}
