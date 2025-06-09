namespace Stationery_Store.Forms
{
    partial class CategoryForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            UpdateCategoryBtn = new Button();
            RemoveCategoryBtn = new Button();
            AddCategoryBtn = new Button();
            label3 = new Label();
            CategoryStatuslbl = new Label();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            categoryBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(256, 24);
            label1.Name = "label1";
            label1.Size = new Size(180, 42);
            label1.TabIndex = 0;
            label1.Text = "اضافة صنف";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(675, 136);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "اكتب اسم الصنف هنا";
            textBox1.Size = new Size(257, 47);
            textBox1.TabIndex = 2;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(723, 88);
            label2.Name = "label2";
            label2.Size = new Size(167, 42);
            label2.TabIndex = 0;
            label2.Text = "اسم الصنف";
            // 
            // UpdateCategoryBtn
            // 
            UpdateCategoryBtn.Anchor = AnchorStyles.Bottom;
            UpdateCategoryBtn.BackColor = Color.DodgerBlue;
            UpdateCategoryBtn.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            UpdateCategoryBtn.Location = new Point(31, 528);
            UpdateCategoryBtn.Margin = new Padding(3, 4, 3, 4);
            UpdateCategoryBtn.Name = "UpdateCategoryBtn";
            UpdateCategoryBtn.Padding = new Padding(2, 3, 2, 3);
            UpdateCategoryBtn.Size = new Size(272, 56);
            UpdateCategoryBtn.TabIndex = 1;
            UpdateCategoryBtn.Text = "تحديث صنف";
            UpdateCategoryBtn.UseVisualStyleBackColor = false;
            UpdateCategoryBtn.Click += UpdateCategoryBtn_Click;
            // 
            // RemoveCategoryBtn
            // 
            RemoveCategoryBtn.Anchor = AnchorStyles.Bottom;
            RemoveCategoryBtn.BackColor = Color.Red;
            RemoveCategoryBtn.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            RemoveCategoryBtn.Location = new Point(310, 528);
            RemoveCategoryBtn.Margin = new Padding(3, 4, 3, 4);
            RemoveCategoryBtn.Name = "RemoveCategoryBtn";
            RemoveCategoryBtn.Padding = new Padding(2, 3, 2, 3);
            RemoveCategoryBtn.Size = new Size(272, 56);
            RemoveCategoryBtn.TabIndex = 1;
            RemoveCategoryBtn.Text = "ازالة صنف";
            RemoveCategoryBtn.UseVisualStyleBackColor = false;
            RemoveCategoryBtn.Click += RemoveCategoryBtn_Click;
            // 
            // AddCategoryBtn
            // 
            AddCategoryBtn.Anchor = AnchorStyles.Bottom;
            AddCategoryBtn.BackColor = Color.Green;
            AddCategoryBtn.FlatAppearance.BorderSize = 0;
            AddCategoryBtn.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            AddCategoryBtn.Location = new Point(592, 528);
            AddCategoryBtn.Margin = new Padding(3, 4, 3, 4);
            AddCategoryBtn.Name = "AddCategoryBtn";
            AddCategoryBtn.Padding = new Padding(2, 3, 2, 3);
            AddCategoryBtn.Size = new Size(272, 56);
            AddCategoryBtn.TabIndex = 1;
            AddCategoryBtn.Text = "اضافة صنف";
            AddCategoryBtn.UseVisualStyleBackColor = false;
            AddCategoryBtn.Click += AddCategoryBtn_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(675, 215);
            label3.Name = "label3";
            label3.Size = new Size(284, 42);
            label3.TabIndex = 0;
            label3.Text = "معلومات عن الصنف";
            // 
            // CategoryStatuslbl
            // 
            CategoryStatuslbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CategoryStatuslbl.AutoSize = true;
            CategoryStatuslbl.ForeColor = Color.Green;
            CategoryStatuslbl.Location = new Point(561, 44);
            CategoryStatuslbl.Name = "CategoryStatuslbl";
            CategoryStatuslbl.Size = new Size(0, 20);
            CategoryStatuslbl.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBox2.BackColor = SystemColors.ButtonHighlight;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(675, 263);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "اكتب معلومات عن الصنف هنا";
            textBox2.Size = new Size(257, 257);
            textBox2.TabIndex = 5;
            textBox2.TextAlign = HorizontalAlignment.Right;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 88);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RightToLeft = RightToLeft.Yes;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(623, 432);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.Click += dataGridView1_SelectionChanged;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1010, 608);
            Controls.Add(dataGridView1);
            Controls.Add(textBox2);
            Controls.Add(CategoryStatuslbl);
            Controls.Add(textBox1);
            Controls.Add(AddCategoryBtn);
            Controls.Add(RemoveCategoryBtn);
            Controls.Add(UpdateCategoryBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CategoryForm";
            Text = "الأصناف";
            Load += CategoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private Button UpdateCategoryBtn;
        private Button RemoveCategoryBtn;
        private Button AddCategoryBtn;
        private Label label3;
        private Label CategoryStatuslbl;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private BindingSource categoryBindingSource;
    }
}