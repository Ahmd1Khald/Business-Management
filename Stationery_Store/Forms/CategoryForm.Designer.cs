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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(224, 18);
            label1.Name = "label1";
            label1.Size = new Size(145, 33);
            label1.TabIndex = 0;
            label1.Text = "اضافة صنف";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(591, 102);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "اكتب اسم الصنف هنا";
            textBox1.Size = new Size(225, 39);
            textBox1.TabIndex = 2;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(633, 66);
            label2.Name = "label2";
            label2.Size = new Size(135, 33);
            label2.TabIndex = 0;
            label2.Text = "اسم الصنف";
            // 
            // UpdateCategoryBtn
            // 
            UpdateCategoryBtn.BackColor = Color.DodgerBlue;
            UpdateCategoryBtn.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateCategoryBtn.Location = new Point(27, 396);
            UpdateCategoryBtn.Name = "UpdateCategoryBtn";
            UpdateCategoryBtn.Padding = new Padding(2);
            UpdateCategoryBtn.Size = new Size(238, 42);
            UpdateCategoryBtn.TabIndex = 1;
            UpdateCategoryBtn.Text = "تحديث صنف";
            UpdateCategoryBtn.UseVisualStyleBackColor = false;
            UpdateCategoryBtn.Click += UpdateCategoryBtn_Click;
            // 
            // RemoveCategoryBtn
            // 
            RemoveCategoryBtn.BackColor = Color.Red;
            RemoveCategoryBtn.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RemoveCategoryBtn.Location = new Point(271, 396);
            RemoveCategoryBtn.Name = "RemoveCategoryBtn";
            RemoveCategoryBtn.Padding = new Padding(2);
            RemoveCategoryBtn.Size = new Size(238, 42);
            RemoveCategoryBtn.TabIndex = 1;
            RemoveCategoryBtn.Text = "ازالة صنف";
            RemoveCategoryBtn.UseVisualStyleBackColor = false;
            RemoveCategoryBtn.Click += RemoveCategoryBtn_Click;
            // 
            // AddCategoryBtn
            // 
            AddCategoryBtn.BackColor = Color.Green;
            AddCategoryBtn.FlatAppearance.BorderSize = 0;
            AddCategoryBtn.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddCategoryBtn.Location = new Point(518, 396);
            AddCategoryBtn.Name = "AddCategoryBtn";
            AddCategoryBtn.Padding = new Padding(2);
            AddCategoryBtn.Size = new Size(238, 42);
            AddCategoryBtn.TabIndex = 1;
            AddCategoryBtn.Text = "اضافة صنف";
            AddCategoryBtn.UseVisualStyleBackColor = false;
            AddCategoryBtn.Click += AddCategoryBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(591, 161);
            label3.Name = "label3";
            label3.Size = new Size(225, 33);
            label3.TabIndex = 0;
            label3.Text = "معلومات عن الصنف";
            // 
            // CategoryStatuslbl
            // 
            CategoryStatuslbl.AutoSize = true;
            CategoryStatuslbl.ForeColor = Color.Green;
            CategoryStatuslbl.Location = new Point(491, 33);
            CategoryStatuslbl.Name = "CategoryStatuslbl";
            CategoryStatuslbl.Size = new Size(0, 15);
            CategoryStatuslbl.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ButtonHighlight;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(591, 197);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "اكتب معلومات عن الصنف هنا";
            textBox2.Size = new Size(225, 193);
            textBox2.TabIndex = 5;
            textBox2.TextAlign = HorizontalAlignment.Right;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RightToLeft = RightToLeft.Yes;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(545, 324);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.Click += dataGridView1_SelectionChanged;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(884, 456);
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