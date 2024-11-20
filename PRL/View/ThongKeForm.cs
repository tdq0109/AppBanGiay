using BUS.Servicer;
using BUS.Services;
using PRL.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL.View
{
    public partial class ThongKeForm : Form
    {
        private HoaDonSer _service;
        private HoaDonCTSer _hdservice;
        public ThongKeForm()
        {
            InitializeComponent();
            _hdservice = new HoaDonCTSer();
            _service = new HoaDonSer();
            LoadDataHoadon();
            LoadData();
        }

        public void LoadDataHoadon()
        {
            int stt = 1;
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "STT";
            dataGridView1.Columns[1].Name = "Mã Hóa Đơn";
            dataGridView1.Columns[2].Name = "Gía";
            dataGridView1.Columns[3].Name = "Ngày Lập";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var option = MessageBox.Show("Bạn Thoát Thật Rồi Đấy", "Thông Báo", MessageBoxButtons.OK);
            if (option == DialogResult.OK)
            {
                ThongKeForm.ActiveForm.Close();
            }
            HoaDon hoaDon = new HoaDon();
            hoaDon.ShowDialog();

        }

        public void LoadData()
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            
          
            
        }
    }
}
