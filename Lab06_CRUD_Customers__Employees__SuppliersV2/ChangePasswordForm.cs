using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Lab06_CRUD_Customers__Employees__SuppliersV2
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        SqlConnection connection;

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string newPassword = txtPassword.Text;
            string confirmPass = txtConfirmPassword.Text;
            string homePhone = txtHomePhone.Text;

            // ตรวจสอบว่า รหัสผ่านและการยืนยันรหัสผ่านตรงกันหรือไม่
            if (newPassword != confirmPass)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql = "UPDATE employees SET Password = @Password WHERE username = @username AND HomePhone = @HomePhone";

            try
            {
                // เปิดการเชื่อมต่อกับฐานข้อมูล
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    // กำหนดค่าพารามิเตอร์
                    cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
                    cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = newPassword;  // เก็บรหัสผ่านตรงๆ
                    cmd.Parameters.Add("@HomePhone", SqlDbType.VarChar).Value = homePhone;

                    // ทำการอัปเดตข้อมูลในฐานข้อมูล
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // ตรวจสอบผลลัพธ์จากการอัปเดต
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or home phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // ตรวจสอบและปิดการเชื่อมต่อหากยังเปิดอยู่
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }


        private void ChangePasswordForm_Load_1(object sender, EventArgs e)
        {
            connection = connectDB.ConnectNortwind(); // เชื่อมต่อฐานข้อมูล
        }
    }
}
