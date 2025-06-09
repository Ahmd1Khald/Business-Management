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
            searchBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(471, 24);
            label1.Name = "label1";
            label1.Size = new Size(131, 42);
            label1.TabIndex = 0;
            label1.Text = "الأصناف";
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
            UpdateCategoryBtn.Cursor = Cursors.Hand;
            UpdateCategoryBtn.FlatAppearance.BorderColor = Color.LightSeaGreen;
            UpdateCategoryBtn.FlatAppearance.BorderSize = 15;
            UpdateCategoryBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            UpdateCategoryBtn.FlatAppearance.MouseOverBackColor = Color.White;
            UpdateCategoryBtn.FlatStyle = FlatStyle.Popup;
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
            RemoveCategoryBtn.Cursor = Cursors.Hand;
            RemoveCategoryBtn.FlatAppearance.BorderColor = Color.Brown;
            RemoveCategoryBtn.FlatAppearance.BorderSize = 15;
            RemoveCategoryBtn.FlatStyle = FlatStyle.Popup;
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
            AddCategoryBtn.Cursor = Cursors.Hand;
            AddCategoryBtn.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 128);
            AddCategoryBtn.FlatAppearance.BorderSize = 15;
            AddCategoryBtn.FlatAppearance.MouseDownBackColor = Color.White;
            AddCategoryBtn.FlatStyle = FlatStyle.Popup;
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
            CategoryStatuslbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CategoryStatuslbl.AutoSize = true;
            CategoryStatuslbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CategoryStatuslbl.ForeColor = Color.Green;
            CategoryStatuslbl.Location = new Point(675, 40);
            CategoryStatuslbl.Name = "CategoryStatuslbl";
            CategoryStatuslbl.Size = new Size(0, 28);
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
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = SystemColors.MenuHighlight;
            dataGridView1.Location = new Point(14, 88);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RightToLeft = RightToLeft.Yes;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(623, 432);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.Click += dataGridView1_SelectionChanged;
            dataGridView1.MouseUp += dataGridView1_MouseUp;
            // 
            // searchBox
            // 
            searchBox.Cursor = Cursors.IBeam;
            searchBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchBox.Location = new Point(14, 37);
            searchBox.Margin = new Padding(3, 4, 3, 4);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "بحث  بإسم الصنف";
            searchBox.RightToLeft = RightToLeft.Yes;
            searchBox.Size = new Size(186, 39);
            searchBox.TabIndex = 7;
            searchBox.TextAlign = HorizontalAlignment.Center;
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1010, 608);
            ControlBox = false;
            Controls.Add(searchBox);
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
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CategoryForm";
            RightToLeft = RightToLeft.No;
            Text = "الأصناف";
            Load += CategoryForm_Load_1;
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
        private TextBox searchBox;
    }
}