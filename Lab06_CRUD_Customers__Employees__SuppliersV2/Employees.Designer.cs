namespace Lab06_CRUD_Customers__Employees__SuppliersV2
{
    partial class Employees
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
            Home = new Button();
            btnReset = new Button();
            txtDeleteEmployees = new Button();
            btninsertCustomer = new Button();
            dataGridView2 = new DataGridView();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // Home
            // 
            Home.Location = new Point(1028, 376);
            Home.Name = "Home";
            Home.Size = new Size(94, 29);
            Home.TabIndex = 18;
            Home.Text = "Home";
            Home.UseVisualStyleBackColor = true;
            Home.Click += Home_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnReset.Location = new Point(415, 364);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(107, 53);
            btnReset.TabIndex = 17;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // txtDeleteEmployees
            // 
            txtDeleteEmployees.Font = new Font("Microsoft Sans Serif", 8.25F);
            txtDeleteEmployees.Location = new Point(302, 364);
            txtDeleteEmployees.Margin = new Padding(3, 4, 3, 4);
            txtDeleteEmployees.Name = "txtDeleteEmployees";
            txtDeleteEmployees.Size = new Size(107, 53);
            txtDeleteEmployees.TabIndex = 16;
            txtDeleteEmployees.Text = "Delete";
            txtDeleteEmployees.UseVisualStyleBackColor = true;
            txtDeleteEmployees.Click += btnDeleteCustomerID_Click;
            // 
            // btninsertCustomer
            // 
            btninsertCustomer.Location = new Point(76, 364);
            btninsertCustomer.Name = "btninsertCustomer";
            btninsertCustomer.Size = new Size(107, 53);
            btninsertCustomer.TabIndex = 14;
            btninsertCustomer.Text = "Add";
            btninsertCustomer.UseVisualStyleBackColor = true;
            btninsertCustomer.Click += btninsertCustomer_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(47, 42);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(1286, 266);
            dataGridView2.TabIndex = 13;
            dataGridView2.CellMouseUp += dataGridView2_CellMouseUp;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(189, 364);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(107, 53);
            btnEdit.TabIndex = 20;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click_1;
            // 
            // Employees
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1408, 450);
            Controls.Add(btnEdit);
            Controls.Add(Home);
            Controls.Add(btnReset);
            Controls.Add(txtDeleteEmployees);
            Controls.Add(btninsertCustomer);
            Controls.Add(dataGridView2);
            Name = "Employees";
            Text = "Employees";
            Load += Employees_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Home;
        private Button btnReset;
        private Button txtDeleteEmployees;
        private Button btninsertCustomer;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button btnEdit;
    }
}