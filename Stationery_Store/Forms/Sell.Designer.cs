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
            AddBtn = new Button();
            productsGridView = new DataGridView();
            SearchTextBox = new TextBox();
            label1 = new Label();
            SellGridView = new DataGridView();
            SellBtn = new Button();
            TotalPrice = new Label();
            TotalQuantity = new Label();
            RemoveBtn = new Button();
            label2 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)productsGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SellGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // AddBtn
            // 
            AddBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddBtn.BackColor = Color.RoyalBlue;
            AddBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBtn.Location = new Point(157, 433);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(216, 51);
            AddBtn.TabIndex = 2;
            AddBtn.Text = "إضافة إلى الفاتورة";
            AddBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // productsGridView
            // 
            productsGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            productsGridView.BackgroundColor = SystemColors.ButtonHighlight;
            productsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsGridView.Location = new Point(11, 150);
            productsGridView.Name = "productsGridView";
            productsGridView.ReadOnly = true;
            productsGridView.RightToLeft = RightToLeft.Yes;
            productsGridView.RowHeadersWidth = 51;
            productsGridView.Size = new Size(540, 264);
            productsGridView.TabIndex = 3;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SearchTextBox.Location = new Point(11, 100);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(540, 27);
            SearchTextBox.TabIndex = 0;
            SearchTextBox.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(140, 50);
            label1.Name = "label1";
            label1.Size = new Size(253, 47);
            label1.TabIndex = 1;
            label1.Text = "ابحث بأسم المنتج";
            // 
            // SellGridView
            // 
            SellGridView.AllowUserToAddRows = false;
            SellGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            SellGridView.BackgroundColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            SellGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            SellGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SellGridView.Location = new Point(557, 98);
            SellGridView.Margin = new Padding(3, 4, 3, 4);
            SellGridView.Name = "SellGridView";
            SellGridView.RightToLeft = RightToLeft.Yes;
            SellGridView.RowHeadersWidth = 51;
            SellGridView.Size = new Size(504, 313);
            SellGridView.TabIndex = 7;
            // 
            // SellBtn
            // 
            SellBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SellBtn.BackColor = Color.Green;
            SellBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SellBtn.Location = new Point(656, 482);
            SellBtn.Name = "SellBtn";
            SellBtn.Size = new Size(295, 53);
            SellBtn.TabIndex = 4;
            SellBtn.Text = "بيع";
            SellBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            SellBtn.UseVisualStyleBackColor = false;
            SellBtn.Click += SellBtn_Click;
            // 
            // TotalPrice
            // 
            TotalPrice.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            TotalPrice.BackColor = Color.Azure;
            TotalPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalPrice.Location = new Point(861, 447);
            TotalPrice.Name = "TotalPrice";
            TotalPrice.RightToLeft = RightToLeft.Yes;
            TotalPrice.Size = new Size(200, 20);
            TotalPrice.TabIndex = 6;
            TotalPrice.Text = "0";
            TotalPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TotalQuantity
            // 
            TotalQuantity.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            TotalQuantity.BackColor = Color.Azure;
            TotalQuantity.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalQuantity.Location = new Point(861, 418);
            TotalQuantity.Name = "TotalQuantity";
            TotalQuantity.RightToLeft = RightToLeft.Yes;
            TotalQuantity.Size = new Size(200, 20);
            TotalQuantity.TabIndex = 8;
            TotalQuantity.Text = "0";
            TotalQuantity.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RemoveBtn
            // 
            RemoveBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RemoveBtn.BackColor = Color.Red;
            RemoveBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RemoveBtn.Location = new Point(557, 418);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new Size(220, 49);
            RemoveBtn.TabIndex = 9;
            RemoveBtn.Text = "إزالة من الفاتورة";
            RemoveBtn.UseVisualStyleBackColor = false;
            RemoveBtn.Click += RemoveBtn_Click_1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(939, 36);
            label2.Name = "label2";
            label2.Size = new Size(122, 47);
            label2.TabIndex = 10;
            label2.Text = "الفاتورة";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(label2);
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
            // SellForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1070, 532);
            Controls.Add(panel1);
            Name = "SellForm";
            RightToLeftLayout = true;
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sell";
            Load += SellForm_Load;
            ((System.ComponentModel.ISupportInitialize)productsGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)SellGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddBtn;
        private DataGridView productsGridView;
        private TextBox SearchTextBox;
        private Label label1;
        private DataGridView SellGridView;
        private Button SellBtn;
        private Label TotalPrice;
        private Label TotalQuantity;
        private Button RemoveBtn;
        private Label label2;
        private Panel panel1;
    }
}
