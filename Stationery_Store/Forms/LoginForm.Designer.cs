namespace Stationery_Store
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            UserNamelabel = new Label();
            PassWordlabel = new Label();
            UserNametextBox = new TextBox();
            PasswordtextBox = new TextBox();
            Loginbutton = new Button();
            UserNameMessagelabel = new Label();
            PassWordMessagelabel = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // UserNamelabel
            // 
            UserNamelabel.AutoSize = true;
            UserNamelabel.Font = new Font("PT Bold Heading", 12F, FontStyle.Regular, GraphicsUnit.Point, 178);
            UserNamelabel.ForeColor = SystemColors.ActiveCaptionText;
            UserNamelabel.Location = new Point(514, 210);
            UserNamelabel.Name = "UserNamelabel";
            UserNamelabel.Size = new Size(118, 35);
            UserNamelabel.TabIndex = 0;
            UserNamelabel.Text = "اسم المستخدم";
            // 
            // PassWordlabel
            // 
            PassWordlabel.AutoSize = true;
            PassWordlabel.Font = new Font("PT Bold Heading", 12F, FontStyle.Regular, GraphicsUnit.Point, 178);
            PassWordlabel.Location = new Point(514, 272);
            PassWordlabel.Name = "PassWordlabel";
            PassWordlabel.Size = new Size(89, 35);
            PassWordlabel.TabIndex = 1;
            PassWordlabel.Text = "كلمة السر";
            // 
            // UserNametextBox
            // 
            UserNametextBox.Location = new Point(193, 218);
            UserNametextBox.Name = "UserNametextBox";
            UserNametextBox.Size = new Size(271, 27);
            UserNametextBox.TabIndex = 2;
            // 
            // PasswordtextBox
            // 
            PasswordtextBox.Location = new Point(193, 280);
            PasswordtextBox.Name = "PasswordtextBox";
            PasswordtextBox.PasswordChar = '*';
            PasswordtextBox.Size = new Size(271, 27);
            PasswordtextBox.TabIndex = 3;
            // 
            // Loginbutton
            // 
            Loginbutton.BackColor = Color.Azure;
            Loginbutton.Font = new Font("PT Bold Heading", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 178);
            Loginbutton.ForeColor = SystemColors.ControlText;
            Loginbutton.Location = new Point(251, 356);
            Loginbutton.Name = "Loginbutton";
            Loginbutton.Size = new Size(176, 53);
            Loginbutton.TabIndex = 4;
            Loginbutton.Text = "تسجيل الدخول";
            Loginbutton.UseVisualStyleBackColor = false;
            Loginbutton.Click += Loginbutton_Click;
            // 
            // UserNameMessagelabel
            // 
            UserNameMessagelabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserNameMessagelabel.ForeColor = Color.Red;
            UserNameMessagelabel.Location = new Point(1, 218);
            UserNameMessagelabel.Name = "UserNameMessagelabel";
            UserNameMessagelabel.RightToLeft = RightToLeft.Yes;
            UserNameMessagelabel.Size = new Size(186, 35);
            UserNameMessagelabel.TabIndex = 5;
            UserNameMessagelabel.Text = "label1";
            UserNameMessagelabel.TextAlign = ContentAlignment.MiddleLeft;
            UserNameMessagelabel.Visible = false;
            // 
            // PassWordMessagelabel
            // 
            PassWordMessagelabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PassWordMessagelabel.ForeColor = Color.Red;
            PassWordMessagelabel.Location = new Point(1, 280);
            PassWordMessagelabel.Name = "PassWordMessagelabel";
            PassWordMessagelabel.RightToLeft = RightToLeft.Yes;
            PassWordMessagelabel.Size = new Size(186, 35);
            PassWordMessagelabel.TabIndex = 6;
            PassWordMessagelabel.Text = "label2";
            PassWordMessagelabel.TextAlign = ContentAlignment.MiddleLeft;
            PassWordMessagelabel.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(256, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 162);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(470, 200);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(470, 268);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(38, 39);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // LoginForm
            // 
            AcceptButton = Loginbutton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(749, 441);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(PassWordMessagelabel);
            Controls.Add(UserNameMessagelabel);
            Controls.Add(Loginbutton);
            Controls.Add(PasswordtextBox);
            Controls.Add(UserNametextBox);
            Controls.Add(PassWordlabel);
            Controls.Add(UserNamelabel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UserNamelabel;
        private Label PassWordlabel;
        private TextBox UserNametextBox;
        private TextBox PasswordtextBox;
        private Button Loginbutton;
        private Label UserNameMessagelabel;
        private Label PassWordMessagelabel;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
