namespace Lab06_CRUD_Customers__Employees__SuppliersV2
{
    partial class ChangePasswordForm
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
            HomePhone = new Label();
            ConfirmPassword = new Label();
            btcancel = new Button();
            btnChangePassword = new Button();
            txtHomePhone = new TextBox();
            txtUsername = new TextBox();
            txtConfirmPassword = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // HomePhone
            // 
            HomePhone.AutoSize = true;
            HomePhone.Location = new Point(93, 44);
            HomePhone.Name = "HomePhone";
            HomePhone.Size = new Size(91, 20);
            HomePhone.TabIndex = 12;
            HomePhone.Text = "HomePhone";
            // 
            // ConfirmPassword
            // 
            ConfirmPassword.AutoSize = true;
            ConfirmPassword.Location = new Point(61, 162);
            ConfirmPassword.Name = "ConfirmPassword";
            ConfirmPassword.Size = new Size(123, 20);
            ConfirmPassword.TabIndex = 15;
            ConfirmPassword.Text = "ConfirmPassword";
            // 
            // btcancel
            // 
            btcancel.Location = new Point(400, 211);
            btcancel.Name = "btcancel";
            btcancel.Size = new Size(94, 29);
            btcancel.TabIndex = 17;
            btcancel.Text = "cancel";
            btcancel.UseVisualStyleBackColor = true;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Location = new Point(147, 211);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(94, 29);
            btnChangePassword.TabIndex = 16;
            btnChangePassword.Text = "ChangePassword";
            btnChangePassword.UseVisualStyleBackColor = true;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // txtHomePhone
            // 
            txtHomePhone.Location = new Point(190, 44);
            txtHomePhone.Name = "txtHomePhone";
            txtHomePhone.Size = new Size(312, 27);
            txtHomePhone.TabIndex = 18;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(190, 85);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(312, 27);
            txtUsername.TabIndex = 19;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(190, 159);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(312, 27);
            txtConfirmPassword.TabIndex = 21;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(190, 118);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(312, 27);
            txtPassword.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 121);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 22;
            label1.Text = "newPassword";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 85);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 23;
            label2.Text = "username";
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btcancel;
            ClientSize = new Size(632, 286);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtHomePhone);
            Controls.Add(btcancel);
            Controls.Add(btnChangePassword);
            Controls.Add(ConfirmPassword);
            Controls.Add(HomePhone);
            Name = "ChangePasswordForm";
            Text = "ChangePassword";
            Load += ChangePasswordForm_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label HomePhone;
        private Label ConfirmPassword;
        private Button btcancel;
        private Button btnChangePassword;
        private TextBox txtHomePhone;
        private TextBox txtUsername;
        private TextBox txtConfirmPassword;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
    }
}