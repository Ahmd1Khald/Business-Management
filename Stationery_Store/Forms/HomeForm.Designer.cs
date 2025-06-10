namespace Stationery_Store.Forms
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            panel1 = new Panel();
            label1 = new Label();
            btnHome = new PictureBox();
            sidebar = new FlowLayoutPanel();
            panel2 = new Panel();
            buttonHome = new Button();
            panel3 = new Panel();
            buttonSell = new Button();
            panel4 = new Panel();
            buttonCategories = new Button();
            panel5 = new Panel();
            buttonProducts = new Button();
            panel6 = new Panel();
            buttonReports = new Button();
            panel7 = new Panel();
            buttonUsers = new Button();
            BackupBtn = new Button();
            sidebarTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            sidebar.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnHome);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.Yes;
            panel1.Size = new Size(925, 38);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 178);
            label1.Location = new Point(81, 5);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 3;
            label1.Text = "إدارة المكتبة";
            // 
            // btnHome
            // 
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.Location = new Point(0, 0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(66, 38);
            btnHome.SizeMode = PictureBoxSizeMode.StretchImage;
            btnHome.TabIndex = 1;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = SystemColors.GradientActiveCaption;
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(panel4);
            sidebar.Controls.Add(panel5);
            sidebar.Controls.Add(panel6);
            sidebar.Controls.Add(panel7);
            sidebar.Controls.Add(BackupBtn);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 38);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(191, 519);
            sidebar.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonHome);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(184, 65);
            panel2.TabIndex = 3;
            // 
            // buttonHome
            // 
            buttonHome.BackColor = SystemColors.ActiveCaption;
            buttonHome.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 178);
            buttonHome.ForeColor = Color.Black;
            buttonHome.Image = (Image)resources.GetObject("buttonHome.Image");
            buttonHome.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHome.Location = new Point(0, 0);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(184, 62);
            buttonHome.TabIndex = 2;
            buttonHome.Text = "الصفحة الرئيسية";
            buttonHome.TextAlign = ContentAlignment.MiddleRight;
            buttonHome.UseVisualStyleBackColor = false;
            buttonHome.Click += buttonHome_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(buttonSell);
            panel3.Location = new Point(3, 74);
            panel3.Name = "panel3";
            panel3.Size = new Size(184, 65);
            panel3.TabIndex = 4;
            // 
            // buttonSell
            // 
            buttonSell.BackColor = SystemColors.ActiveCaption;
            buttonSell.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 178);
            buttonSell.ForeColor = Color.Black;
            buttonSell.Image = (Image)resources.GetObject("buttonSell.Image");
            buttonSell.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSell.Location = new Point(-3, -3);
            buttonSell.Name = "buttonSell";
            buttonSell.Size = new Size(184, 62);
            buttonSell.TabIndex = 2;
            buttonSell.Text = "  البيع          ";
            buttonSell.TextAlign = ContentAlignment.MiddleRight;
            buttonSell.UseVisualStyleBackColor = false;
            buttonSell.Click += buttonSell_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(buttonCategories);
            panel4.Location = new Point(3, 145);
            panel4.Name = "panel4";
            panel4.Size = new Size(184, 65);
            panel4.TabIndex = 4;
            // 
            // buttonCategories
            // 
            buttonCategories.BackColor = SystemColors.ActiveCaption;
            buttonCategories.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 178);
            buttonCategories.ForeColor = Color.Black;
            buttonCategories.Image = (Image)resources.GetObject("buttonCategories.Image");
            buttonCategories.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCategories.Location = new Point(0, 3);
            buttonCategories.Name = "buttonCategories";
            buttonCategories.Size = new Size(184, 62);
            buttonCategories.TabIndex = 2;
            buttonCategories.Text = "الأصناف       ";
            buttonCategories.TextAlign = ContentAlignment.MiddleRight;
            buttonCategories.UseVisualStyleBackColor = false;
            buttonCategories.Click += buttonCategories_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(buttonProducts);
            panel5.Location = new Point(3, 216);
            panel5.Name = "panel5";
            panel5.Size = new Size(184, 65);
            panel5.TabIndex = 4;
            // 
            // buttonProducts
            // 
            buttonProducts.BackColor = SystemColors.ActiveCaption;
            buttonProducts.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 178);
            buttonProducts.ForeColor = Color.Black;
            buttonProducts.Image = (Image)resources.GetObject("buttonProducts.Image");
            buttonProducts.ImageAlign = ContentAlignment.MiddleLeft;
            buttonProducts.Location = new Point(0, 0);
            buttonProducts.Name = "buttonProducts";
            buttonProducts.Size = new Size(184, 62);
            buttonProducts.TabIndex = 2;
            buttonProducts.Text = "المنتجات       ";
            buttonProducts.TextAlign = ContentAlignment.MiddleRight;
            buttonProducts.UseVisualStyleBackColor = false;
            buttonProducts.Click += buttonProducts_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(buttonReports);
            panel6.Location = new Point(3, 287);
            panel6.Name = "panel6";
            panel6.Size = new Size(184, 65);
            panel6.TabIndex = 5;
            // 
            // buttonReports
            // 
            buttonReports.BackColor = SystemColors.ActiveCaption;
            buttonReports.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 178);
            buttonReports.ForeColor = Color.Black;
            buttonReports.Image = (Image)resources.GetObject("buttonReports.Image");
            buttonReports.ImageAlign = ContentAlignment.MiddleLeft;
            buttonReports.Location = new Point(0, 0);
            buttonReports.Name = "buttonReports";
            buttonReports.Size = new Size(184, 62);
            buttonReports.TabIndex = 2;
            buttonReports.Text = "التقارير        ";
            buttonReports.TextAlign = ContentAlignment.MiddleRight;
            buttonReports.UseVisualStyleBackColor = false;
            buttonReports.Click += buttonReports_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(buttonUsers);
            panel7.Location = new Point(3, 358);
            panel7.Name = "panel7";
            panel7.Size = new Size(184, 57);
            panel7.TabIndex = 6;
            // 
            // buttonUsers
            // 
            buttonUsers.BackColor = SystemColors.ActiveCaption;
            buttonUsers.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 178);
            buttonUsers.ForeColor = Color.Black;
            buttonUsers.Image = (Image)resources.GetObject("buttonUsers.Image");
            buttonUsers.ImageAlign = ContentAlignment.MiddleLeft;
            buttonUsers.Location = new Point(0, -3);
            buttonUsers.Name = "buttonUsers";
            buttonUsers.Size = new Size(184, 62);
            buttonUsers.TabIndex = 2;
            buttonUsers.Text = "المستخدمين        ";
            buttonUsers.TextAlign = ContentAlignment.MiddleRight;
            buttonUsers.UseVisualStyleBackColor = false;
            buttonUsers.Click += buttonUsers_Click;
            // 
            // BackupBtn
            // 
            BackupBtn.AutoSize = true;
            BackupBtn.BackColor = SystemColors.ActiveCaption;
            BackupBtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 178);
            BackupBtn.ForeColor = Color.Black;
            BackupBtn.Image = (Image)resources.GetObject("BackupBtn.Image");
            BackupBtn.ImageAlign = ContentAlignment.MiddleLeft;
            BackupBtn.Location = new Point(3, 421);
            BackupBtn.Name = "BackupBtn";
            BackupBtn.Size = new Size(184, 60);
            BackupBtn.TabIndex = 2;
            BackupBtn.Text = "النسخ الإحتياطي     ";
            BackupBtn.TextAlign = ContentAlignment.MiddleRight;
            BackupBtn.UseVisualStyleBackColor = false;
            BackupBtn.Click += BackupBtn_Click;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // HomeForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(925, 557);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MaximizeBox = false;
            Name = "HomeForm";
            RightToLeft = RightToLeft.No;
            Text = "Home";
            Resize += HomeForm_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            sidebar.ResumeLayout(false);
            sidebar.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox btnHome;
        private Label label1;
        private FlowLayoutPanel sidebar;
        private Button buttonHome;
        private Panel panel2;
        private Panel panel3;
        private Button buttonCategories;
        private Panel panel4;
        private Button buttonProducts;
        private Panel panel5;
        private Button buttonSell;
        private Panel panel6;
        private Button buttonReports;
        private System.Windows.Forms.Timer sidebarTransition;
        private Panel panel7;
        private Button buttonUsers;
        private Button BackupBtn;
    }
}