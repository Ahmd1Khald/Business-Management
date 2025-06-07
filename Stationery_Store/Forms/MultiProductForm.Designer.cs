namespace Stationery_Store.Forms
{
    partial class MultiProductForm
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
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.btnRemoveRow = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.productsDataGridView.Size = new System.Drawing.Size(776, 350);
            this.productsDataGridView.TabIndex = 0;
            this.productsDataGridView.MultiSelect = true;
            this.productsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // btnAddRow
            // 
            this.btnAddRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddRow.Location = new System.Drawing.Point(12, 368);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(120, 30);
            this.btnAddRow.TabIndex = 1;
            this.btnAddRow.Text = "إضافة صف";
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // btnRemoveRow
            // 
            this.btnRemoveRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveRow.Location = new System.Drawing.Point(138, 368);
            this.btnRemoveRow.Name = "btnRemoveRow";
            this.btnRemoveRow.Size = new System.Drawing.Size(120, 30);
            this.btnRemoveRow.TabIndex = 2;
            this.btnRemoveRow.Text = "حذف الصف";
            this.btnRemoveRow.UseVisualStyleBackColor = true;
            this.btnRemoveRow.Click += new System.EventHandler(this.btnRemoveRow_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(668, 368);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 30);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(542, 368);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 30);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "إلغاء";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(264, 371);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(200, 24);
            this.categoryComboBox.TabIndex = 5;
            // 
            // MultiProductForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 410);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemoveRow);
            this.Controls.Add(this.btnAddRow);
            this.Controls.Add(this.productsDataGridView);
            this.Name = "MultiProductForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "إضافة عدة منتجات";
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.Button btnRemoveRow;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox categoryComboBox;
    }
} 