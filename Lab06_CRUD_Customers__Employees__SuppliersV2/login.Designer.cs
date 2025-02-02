namespace Lab06_CRUD_Customers__Employees__SuppliersV2
{
    partial class login
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
            cancel = new Button();
            lonig = new Button();
            label2 = new Label();
            label1 = new Label();
            txtpassword = new TextBox();
            txtusename = new TextBox();
            btnOpenChangePassword = new Button();
            SuspendLayout();
            // 
            // cancel
            // 
            cancel.Location = new Point(449, 227);
            cancel.Name = "cancel";
            cancel.Size = new Size(94, 29);
            cancel.TabIndex = 11;
            cancel.Text = "cancel";
            cancel.UseVisualStyleBackColor = true;
            // 
            // lonig
            // 
            lonig.Location = new Point(196, 227);
            lonig.Name = "lonig";
            lonig.Size = new Size(94, 29);
            lonig.TabIndex = 10;
            lonig.Text = "Lonig";
            lonig.UseVisualStyleBackColor = true;
            lonig.Click += Lonig_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 113);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 9;
            label2.Text = "password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 69);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 8;
            label1.Text = "usename";
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(219, 113);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(324, 27);
            txtpassword.TabIndex = 7;
            txtpassword.MouseLeave += txtpassword_MouseLeave;
            txtpassword.MouseHover += txtpassword_MouseHover;
            // 
            // txtusename
            // 
            txtusename.Location = new Point(219, 69);
            txtusename.Name = "txtusename";
            txtusename.Size = new Size(324, 27);
            txtusename.TabIndex = 6;
            // 
            // btnOpenChangePassword
            // 
            btnOpenChangePassword.Location = new Point(316, 268);
            btnOpenChangePassword.Name = "btnOpenChangePassword";
            btnOpenChangePassword.Size = new Size(94, 29);
            btnOpenChangePassword.TabIndex = 12;
            btnOpenChangePassword.Text = "ChangePassword";
            btnOpenChangePassword.UseVisualStyleBackColor = true;
            btnOpenChangePassword.Click += btnOpenChangePassword_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancel;
            ClientSize = new Size(689, 309);
            Controls.Add(btnOpenChangePassword);
            Controls.Add(cancel);
            Controls.Add(lonig);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtpassword);
            Controls.Add(txtusename);
            Name = "login";
            Text = "login";
            Load += login_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancel;
        private Button lonig;
        private Label label2;
        private Label label1;
        private TextBox txtpassword;
        private TextBox txtusename;
        private Button btnOpenChangePassword;
    }
}