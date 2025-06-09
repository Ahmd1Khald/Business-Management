namespace Stationery_Store.Forms
{
    partial class UsersForm
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
            dataGridViewUsers = new DataGridView();
            textBoxUserName = new TextBox();
            textBoxPassword = new TextBox();
            textBoxNationalID = new TextBox();
            textBoxPhone = new TextBox();
            comboBoxRole = new ComboBox();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewUsers.BackgroundColor = Color.Azure;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Location = new Point(12, 57);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.RightToLeft = RightToLeft.Yes;
            dataGridViewUsers.RowHeadersWidth = 51;
            dataGridViewUsers.Size = new Size(1010, 172);
            dataGridViewUsers.TabIndex = 0;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Anchor = AnchorStyles.Bottom;
            textBoxUserName.Location = new Point(798, 279);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.RightToLeft = RightToLeft.Yes;
            textBoxUserName.Size = new Size(209, 27);
            textBoxUserName.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Bottom;
            textBoxPassword.Location = new Point(602, 279);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.RightToLeft = RightToLeft.Yes;
            textBoxPassword.Size = new Size(179, 27);
            textBoxPassword.TabIndex = 3;
            // 
            // textBoxNationalID
            // 
            textBoxNationalID.Anchor = AnchorStyles.Bottom;
            textBoxNationalID.Location = new Point(361, 279);
            textBoxNationalID.Name = "textBoxNationalID";
            textBoxNationalID.RightToLeft = RightToLeft.Yes;
            textBoxNationalID.Size = new Size(216, 27);
            textBoxNationalID.TabIndex = 4;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Anchor = AnchorStyles.Bottom;
            textBoxPhone.Location = new Point(140, 279);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.RightToLeft = RightToLeft.Yes;
            textBoxPhone.Size = new Size(196, 27);
            textBoxPhone.TabIndex = 5;
            // 
            // comboBoxRole
            // 
            comboBoxRole.Anchor = AnchorStyles.Bottom;
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "Admin", "User" });
            comboBoxRole.Location = new Point(22, 279);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.RightToLeft = RightToLeft.Yes;
            comboBoxRole.Size = new Size(91, 28);
            comboBoxRole.Sorted = true;
            comboBoxRole.TabIndex = 6;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Bottom;
            buttonAdd.BackColor = Color.Green;
            buttonAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdd.Location = new Point(686, 348);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(216, 53);
            buttonAdd.TabIndex = 7;
            buttonAdd.Text = "إضافة";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click_1;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Anchor = AnchorStyles.Bottom;
            buttonUpdate.BackColor = Color.Yellow;
            buttonUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUpdate.Location = new Point(396, 348);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(202, 53);
            buttonUpdate.TabIndex = 8;
            buttonUpdate.Text = "تعديل";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click_1;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Bottom;
            buttonDelete.BackColor = Color.Red;
            buttonDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDelete.Location = new Point(120, 348);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(183, 53);
            buttonDelete.TabIndex = 9;
            buttonDelete.Text = "حذف";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Location = new Point(906, 256);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 10;
            label2.Text = "اسم المستخدم";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Location = new Point(712, 256);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 11;
            label3.Text = "كلمة السر";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Location = new Point(486, 256);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 12;
            label4.Text = "الرقم القومي";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Location = new Point(247, 256);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 13;
            label5.Text = "رقم المحمول";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom;
            label6.AutoSize = true;
            label6.Location = new Point(73, 256);
            label6.Name = "label6";
            label6.Size = new Size(40, 20);
            label6.TabIndex = 14;
            label6.Text = "الدور";
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1034, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(comboBoxRole);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxNationalID);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUserName);
            Controls.Add(dataGridViewUsers);
            Name = "UsersForm";
            Text = "UsersForm";
            Load += UsersForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewUsers;
        private TextBox textBoxUserName;
        private TextBox textBoxPassword;
        private TextBox textBoxNationalID;
        private TextBox textBoxPhone;
        private ComboBox comboBoxRole;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}