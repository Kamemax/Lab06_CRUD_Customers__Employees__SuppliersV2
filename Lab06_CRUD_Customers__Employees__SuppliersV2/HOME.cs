using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06_CRUD_Customers__Employees__SuppliersV2
{
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }



        private void HOME_Load(object sender, EventArgs e)
        {

        }


        private void login_Click(object sender, EventArgs e)
        {

            // Create a new instance of Form1
            login f = new login();

            f.ShowDialog(); // Open Form1 as a modal dialog
            MessageBox.Show(f.LoginStatus);
            if (f.LoginStatus == "Pass")
            {
                this.Text = "Northwind Id : " + f.EmployeeId.ToString();
                this.Text += " name :" + f.EmployeeName + " position :" + f.Title;
                groupBox1.Visible = true;
                logout.Visible = true;
                login.Visible = false;

            }
        }


        private void logout_Click_1(object sender, EventArgs e)
        {
            this.Text = "Northwind";
            groupBox1.Visible = false;
            logout.Visible = false;
            login.Visible = true;

        }

        private void customer_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();  // ใช้ Show() แทน ShowDialog()
            this.Hide();
        }

        private void Employees_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            employees.Show();  // ใช้ Show() แทน ShowDialog()
            this.Hide();
        }

        private void Suppliers_Click(object sender, EventArgs e)
        {
            Suppliers suppliers = new Suppliers();
            suppliers.Show();  // ใช้ Show() แทน ShowDialog()
            this.Hide();
        }
    }
}

