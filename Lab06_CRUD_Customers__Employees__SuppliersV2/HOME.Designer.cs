namespace Lab06_CRUD_Customers__Employees__SuppliersV2
{
    partial class HOME
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
            groupBox1 = new GroupBox();
            logout = new Button();
            Suppliers = new Button();
            Employees = new Button();
            customer = new Button();
            login = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(logout);
            groupBox1.Controls.Add(Suppliers);
            groupBox1.Controls.Add(Employees);
            groupBox1.Controls.Add(customer);
            groupBox1.Location = new Point(3, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(673, 158);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Visible = false;
            // 
            // logout
            // 
            logout.Location = new Point(461, 123);
            logout.Name = "logout";
            logout.Size = new Size(94, 29);
            logout.TabIndex = 7;
            logout.Text = "logout";
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click_1;
            // 
            // Suppliers
            // 
            Suppliers.Location = new Point(353, 33);
            Suppliers.Name = "Suppliers";
            Suppliers.Size = new Size(134, 59);
            Suppliers.TabIndex = 5;
            Suppliers.Text = "Suppliers";
            Suppliers.UseVisualStyleBackColor = true;
            Suppliers.Click += Suppliers_Click;
            // 
            // Employees
            // 
            Employees.Location = new Point(213, 33);
            Employees.Name = "Employees";
            Employees.Size = new Size(134, 59);
            Employees.TabIndex = 4;
            Employees.Text = "Employees";
            Employees.UseVisualStyleBackColor = true;
            Employees.Click += Employees_Click;
            // 
            // customer
            // 
            customer.Location = new Point(73, 33);
            customer.Name = "customer";
            customer.Size = new Size(134, 59);
            customer.TabIndex = 3;
            customer.Text = "customer";
            customer.UseVisualStyleBackColor = true;
            customer.Click += customer_Click_1;
            // 
            // login
            // 
            login.Location = new Point(513, 41);
            login.Name = "login";
            login.Size = new Size(94, 29);
            login.TabIndex = 6;
            login.Text = "loging";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // button1
            // 
            button1.Location = new Point(493, 33);
            button1.Name = "button1";
            button1.Size = new Size(134, 59);
            button1.TabIndex = 8;
            button1.Text = "FRMMinimartMSi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // HOME
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(676, 279);
            Controls.Add(login);
            Controls.Add(groupBox1);
            Name = "HOME";
            Text = "HOME";
            Load += HOME_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button logout;
        private Button Suppliers;
        private Button Employees;
        private Button customer;
        private Button login;
        private Button button1;
    }
}