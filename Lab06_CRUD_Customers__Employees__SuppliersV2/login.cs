using Microsoft.Data.SqlClient;
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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        SqlConnection connection;
        SqlDataAdapter da;
        SqlCommand cmd;
        public string LoginStatus { get; set; } // Fixed name
        public int EmployeeId { get; set; } // Fixed name
        public string EmployeeName { get; set; } // Fixed name
        public string Title { get; set; } // Fixed name


        private void Lonig_Click(object sender, EventArgs e)
        {
            string username = txtusename.Text;
            string password = txtpassword.Text;

            string sql = "SELECT EmployeeID, TitleOfCourtesy + FirstName + ' ' + LastName AS employeeName, Title " +
                         "FROM Employees WHERE Username = @username AND Password = @password";

            cmd = new SqlCommand(sql, connection); // ผูก SqlCommand กับ SqlConnection
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            da = new SqlDataAdapter(cmd); // ใช้ SqlCommand ใน SqlDataAdapter
            DataSet ds = new DataSet();

            try
            {
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    this.LoginStatus = "Pass";
                    this.EmployeeId = Convert.ToInt16(ds.Tables[0].Rows[0]["EmployeeID"]);
                    this.EmployeeName = ds.Tables[0].Rows[0]["employeeName"].ToString();
                    this.Title = ds.Tables[0].Rows[0]["Title"].ToString();
                }
                else
                {
                    MessageBox.Show("ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง", "เกิดข้อผิดพลาด");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"เกิดข้อผิดพลาด: {ex.Message}", "Error");
            }
            finally
            {
                this.Close();
            }
        }
        private void txtpassword_MouseHover(object sender, EventArgs e)
        {
            txtpassword.UseSystemPasswordChar = false;
        }

        private void txtpassword_MouseLeave(object sender, EventArgs e)
        {
            txtpassword.UseSystemPasswordChar = true;

        }
        private void login_Load_1(object sender, EventArgs e)
        {
            connection = connectDB.ConnectNortwind();

        }

        private void btnOpenChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm form = new ChangePasswordForm();
            form.ShowDialog();
        }
    }
}

