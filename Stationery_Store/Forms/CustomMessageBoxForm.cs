using System;
using System.Drawing;
using System.Windows.Forms;

namespace Stationery_Store.Forms
{
    public partial class CustomMessageBoxForm : Form
    {
        public CustomMessageBoxForm(string message)
        {
            InitializeComponent();
            lblMessage.Text = message;
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "تأكيد الحذف"; // Set title to Arabic
            this.StartPosition = FormStartPosition.CenterParent;

            btnYes.Text = "نعم";
            btnNo.Text = "لا";

            btnYes.DialogResult = DialogResult.Yes;
            btnNo.DialogResult = DialogResult.No;
        }

        private void InitializeComponent()
        {
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMessage.Location = new System.Drawing.Point(12, 30);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(350, 60);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Message Text";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(190, 110);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(80, 35);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "نعم";
            this.btnYes.UseVisualStyleBackColor = true;
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(90, 110);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(80, 35);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "لا";
            this.btnNo.UseVisualStyleBackColor = true;
            // 
            // CustomMessageBoxForm
            // 
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomMessageBoxForm";
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
    }
} 