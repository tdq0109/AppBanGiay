using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_SHOE.View
{
    public partial class ResetPass : Form
    {
        public ResetPass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            string Sodienthoai = txt_sdt.Text;
            string MatkhauMoi = txt_newpass.Text;
            string XacNhanMatKhau = txt_confirmpass.Text;

           
            if (MatkhauMoi != XacNhanMatKhau)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không trùng khớp!");
                return;
            }

            string connectionString = @"Data Source=QUANG\\SQLEXPRESS01;Initial Catalog=CuaHangBanHang;Integrated Security=True;TrustServerCertificate=true";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                string query = "UPDATE NHANVIEN SET MATKHAU = @MatKhauMoi WHERE SDT = @SDT";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SDT", Sodienthoai);
                    command.Parameters.AddWithValue("@MatKhauMoi", MatkhauMoi);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Mật khẩu đã được cập nhật thành công!");
        }

        private bool ValidateInput()
        {
            bool isValid = true;
            string errorMessage = "";

            if (string.IsNullOrEmpty(txt_sdt.Text))
            {
                errorMessage += "Số điện thoại không được trống!\n";
                isValid = false;
            }
            else if (!ValidatePhoneNumber(txt_sdt.Text)) 
            {
                errorMessage += "Số điện thoại không hợp lệ!\n";
                isValid = false;
            }

            if (string.IsNullOrEmpty(txt_newpass.Text))
            {
                errorMessage += "Mật khẩu mới không được trống!\n";
                isValid = false;
            }

            if (string.IsNullOrEmpty(txt_confirmpass.Text))
            {
                errorMessage += "Xác nhận mật khẩu không được trống!\n";
                isValid = false;
            }

            if (!isValid)
            {
                MessageBox.Show(errorMessage, "Lỗi lấy lại mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isValid;
        }

        private bool ValidatePhoneNumber(string phoneNumber)
        {
            string regex = @"^[0-9]+$";
            if(!Regex.IsMatch(phoneNumber, regex))
            {
                MessageBox.Show("Mật khẩu không được có A-Z,a-z và kí tự đặc biệt");
            }
            return Regex.IsMatch(phoneNumber, regex);
        }

        private string GenerateNewPassword() 
        {
           
            string password = "";
            return password;
        }

        private void SendEmail(string email, string password) // xóa
        {
           
        }
    }
}

    

