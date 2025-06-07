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
            UserNamelabel = new Label();
            PassWordlabel = new Label();
            UserNametextBox = new TextBox();
            PasswordtextBox = new TextBox();
            Loginbutton = new Button();
            UserNameMessagelabel = new Label();
            PassWordMessagelabel = new Label();
            SuspendLayout();
            // 
            // UserNamelabel
            // 
            UserNamelabel.AutoSize = true;
            UserNamelabel.Font = new Font("PT Bold Heading", 12F, FontStyle.Regular, GraphicsUnit.Point, 178);
            UserNamelabel.Location = new Point(106, 115);
            UserNamelabel.Name = "UserNamelabel";
            UserNamelabel.Size = new Size(144, 35);
            UserNamelabel.TabIndex = 0;
            UserNamelabel.Text = "User Name";
            // 
            // PassWordlabel
            // 
            PassWordlabel.AutoSize = true;
            PassWordlabel.Font = new Font("PT Bold Heading", 12F, FontStyle.Regular, GraphicsUnit.Point, 178);
            PassWordlabel.Location = new Point(106, 199);
            PassWordlabel.Name = "PassWordlabel";
            PassWordlabel.Size = new Size(128, 35);
            PassWordlabel.TabIndex = 1;
            PassWordlabel.Text = "Password";
            // 
            // UserNametextBox
            // 
            UserNametextBox.Location = new Point(292, 122);
            UserNametextBox.Name = "UserNametextBox";
            UserNametextBox.Size = new Size(176, 27);
            UserNametextBox.TabIndex = 2;
            // 
            // PasswordtextBox
            // 
            PasswordtextBox.Location = new Point(292, 206);
            PasswordtextBox.Name = "PasswordtextBox";
            PasswordtextBox.PasswordChar = '*';
            PasswordtextBox.Size = new Size(176, 27);
            PasswordtextBox.TabIndex = 3;
            // 
            // Loginbutton
            // 
            Loginbutton.BackColor = Color.PeachPuff;
            Loginbutton.Font = new Font("PT Bold Heading", 9F, FontStyle.Regular, GraphicsUnit.Point, 178);
            Loginbutton.Location = new Point(292, 290);
            Loginbutton.Name = "Loginbutton";
            Loginbutton.Size = new Size(112, 53);
            Loginbutton.TabIndex = 4;
            Loginbutton.Text = "Login";
            Loginbutton.UseVisualStyleBackColor = false;
            Loginbutton.Click += Loginbutton_Click;
            // 
            // UserNameMessagelabel
            // 
            UserNameMessagelabel.AutoSize = true;
            UserNameMessagelabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserNameMessagelabel.ForeColor = Color.Red;
            UserNameMessagelabel.Location = new Point(533, 122);
            UserNameMessagelabel.Name = "UserNameMessagelabel";
            UserNameMessagelabel.Size = new Size(55, 23);
            UserNameMessagelabel.TabIndex = 5;
            UserNameMessagelabel.Text = "label1";
            UserNameMessagelabel.Visible = false;
            // 
            // PassWordMessagelabel
            // 
            PassWordMessagelabel.AutoSize = true;
            PassWordMessagelabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PassWordMessagelabel.ForeColor = Color.Red;
            PassWordMessagelabel.Location = new Point(533, 213);
            PassWordMessagelabel.Name = "PassWordMessagelabel";
            PassWordMessagelabel.Size = new Size(55, 23);
            PassWordMessagelabel.TabIndex = 6;
            PassWordMessagelabel.Text = "label2";
            PassWordMessagelabel.Visible = false;
            // 
            // LoginForm
            // 
            AcceptButton = Loginbutton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 451);
            Controls.Add(PassWordMessagelabel);
            Controls.Add(UserNameMessagelabel);
            Controls.Add(Loginbutton);
            Controls.Add(PasswordtextBox);
            Controls.Add(UserNametextBox);
            Controls.Add(PassWordlabel);
            Controls.Add(UserNamelabel);
            Name = "LoginForm";
            Text = "MainForm";
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
    }
}
