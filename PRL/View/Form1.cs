using Microsoft.Data.SqlClient;
using Project_SHOE.View;

namespace Project_SHOE
{
    public partial class Form1 : Form
    {
        public string sdt;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (!ValidateInput())
            {
                return;
            }

            string username = textBox1.Text;
            string password = textBox2.Text;


            string connectionString = @"Data Source=QUANG\\SQLEXPRESS01;Initial Catalog=CuaHangBanHang;Integrated Security=True;TrustServerCertificate=true";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string query = "SELECT ID_CHUCVU FROM NHANVIEN WHERE SDT = @username AND MATKHAU = @password";



                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    






                    connection.Open();


                    SqlDataReader reader = command.ExecuteReader();


                    if (reader.Read())
                    {
                        string id = reader[0].ToString();
                        sdt = id;
                    }

                    if (reader.HasRows)
                    {
                        MessageBox.Show("Đăng nhập thành công!");

                        TrangChu trangchu = new TrangChu();
                        trangchu.idcv = sdt;
                        trangchu.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!");
                    }

                    reader.Close();
                }
            }
        }

        private bool ValidateInput()
        {
            bool isValid = true;
            string errorMessage = "";

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                errorMessage += "Tên đăng nhập không được trống!\n";
                isValid = false;
            }

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                errorMessage += "Mật khẩu không được trống!\n";
                isValid = false;
            }

            if (!isValid)
            {
                MessageBox.Show(errorMessage, "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isValid;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var option = MessageBox.Show("Bạn Thoát Thật à ?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                Close();
            }
            else
            {
                return;
            }


        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetPass reset = new ResetPass();
            reset.ShowDialog();
        }
    }
}
