﻿namespace Lab06_CRUD_Customers__Employees__SuppliersV2
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            btninsert = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnReset = new Button();
            Home = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1286, 266);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellMouseUp += dataGridView1_CellMouseUp;
            // 
            // btninsert
            // 
            btninsert.Location = new Point(41, 388);
            btninsert.Name = "btninsert";
            btninsert.Size = new Size(107, 53);
            btninsert.TabIndex = 1;
            btninsert.Text = "Add";
            btninsert.UseVisualStyleBackColor = true;
            btninsert.Click += btninsert_Click_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnEdit.Location = new Point(154, 388);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(107, 53);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnDelete.Location = new Point(267, 388);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(107, 53);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnReset.Location = new Point(380, 388);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(107, 53);
            btnReset.TabIndex = 11;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Home
            // 
            Home.Location = new Point(997, 400);
            Home.Name = "Home";
            Home.Size = new Size(94, 29);
            Home.TabIndex = 12;
            Home.Text = "Home";
            Home.UseVisualStyleBackColor = true;
            Home.Click += Home_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1304, 479);
            Controls.Add(Home);
            Controls.Add(btnReset);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btninsert);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Customer";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btninsert;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnReset;
        private Button Home;
    }
}
