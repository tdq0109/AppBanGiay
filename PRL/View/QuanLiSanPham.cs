﻿using BUS.Services;
using DAL.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_SHOE.View
{
    public partial class QuanLiSanPham : Form
    {
        SanPhamSer _sanPhamSer = new SanPhamSer();
        SanPhamCTSer _sanPhamCTSer = new SanPhamCTSer();

        private int _idSP;
        int idCellClick = -1;
        public QuanLiSanPham()
        {
            InitializeComponent();
        }
        private void LoadData(dynamic data)
        {
            dataGridView1.Rows.Clear();
            int stt = 1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnCount = 4;
            // Đặt tên cho các cột
            dataGridView1.Columns[0].Name = "STT";
            dataGridView1.Columns[1].Name = "Mã Sản Phẩm";
            dataGridView1.Columns[2].Name = "Tên Sản Phẩm";
            dataGridView1.Columns[3].Name = "Hãng";

            foreach (var sp in data)
            {
                dataGridView1.Rows.Add(stt++, sp.IdSanpham, sp.TenSanPham, sp.TenThuongHieu);
            }
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                int index = e.RowIndex;
                var selectChild = dataGridView1.Rows[index];
                txt_tenSP.Text = selectChild.Cells[2].Value.ToString();
                cbb_Hang.Text = selectChild.Cells[3].Value.ToString();
                txt_maSP.Text = selectChild.Cells[1].Value.ToString();
                btn_add.Enabled = false;
                btn_update.Enabled = true;
                btn_delete.Enabled = true;
            }
            else
            {
                // Nếu người dùng bấm vào bảng trống hoặc bảng tiêu đề, hiển thị một thông báo
                MessageBox.Show("Vui lòng chọn một dòng dữ liệu hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void cbb_Hang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void txt_tenSP_TextChanged(object sender, EventArgs e)
        {

        }
        private void txt_maSP_TextChanged(object sender, EventArgs e)
        {

        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            int maSP;
            if (!int.TryParse(txt_maSP.Text, out maSP))
            {
                MessageBox.Show("Vui lòng nhập một mã sản phẩm hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra xem sản phẩm có sản phẩm chi tiết liên quan không
            bool hasRelatedDetails = _sanPhamCTSer.GetAllSPCT().Any(i => i.IdSanpham == maSP);

            // Nếu có sản phẩm chi tiết liên quan, xác nhận trước khi xóa
            if (hasRelatedDetails)
            {
                var confirmation = MessageBox.Show("Sản phẩm đã có các sản phẩm chi tiết liên quan. Bạn có muốn tiếp tục xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmation == DialogResult.No)
                    return; // Người dùng không muốn xóa, không làm gì cả
            }

            // Xóa sản phẩm chính
            bool deleteResult = _sanPhamSer.DeleteSP(maSP);
            if (deleteResult)
            {
                MessageBox.Show("Xóa sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(_sanPhamSer.Getview());
            }
            else
            {
                MessageBox.Show("Xóa sản phẩm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void btn_add_Click(object sender, EventArgs e)
        {
            int m = cbb_Hang.SelectedIndex;
            var s1 = new Sanpham();
            s1.Tensanpham = txt_tenSP.Text;

            if (cbb_Hang.Text == "")
            {
                MessageBox.Show("Sản Phẩm chưa có Thương Hiệu");
                LoadData(_sanPhamSer.Getview());
            }
            else if (txt_tenSP.Text == "")
            {
                MessageBox.Show("Tên không được để trống");
                LoadData(_sanPhamSer.Getview());
            }
            else
            {
                // Kiểm tra xem tên sản phẩm đã tồn tại chưa
                if (_sanPhamSer.CheckDuplicate(s1.Tensanpham))
                {
                    MessageBox.Show("Tên sản phẩm đã tồn tại. Vui lòng chọn tên khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadData(_sanPhamSer.Getview());
                    return; // Ngăn chặn tiếp tục thêm sản phẩm
                }
                s1.IdThuonghieu = _sanPhamSer.GetAllTH().ElementAt(m).IdThuonghieu;
                MessageBox.Show(_sanPhamSer.AddSP(s1));
                LoadData(_sanPhamSer.Getview());
                Clear();
            }
            return;
        }



        private void btn_update_Click(object sender, EventArgs e)
        {
            int m = cbb_Hang.SelectedIndex;
            int maSP = int.Parse(txt_maSP.Text);
            string tenSanPhamMoi = txt_tenSP.Text;
            if (_sanPhamSer.CheckDuplicateForUpdate(tenSanPhamMoi, maSP))
            {
                MessageBox.Show("Tên sản phẩm đã tồn tại. Vui lòng chọn tên khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadData(_sanPhamSer.Getview());
                return; // Ngăn chặn tiếp tục sửa sản phẩm
            }

            var result = _sanPhamSer.UpdateSP(maSP, new Sanpham()
            {
                Tensanpham = txt_tenSP.Text,
                IdThuonghieu = _sanPhamSer.GetAllTH().ElementAt(m).IdThuonghieu

            });
            if (result == 3)
            {
                MessageBox.Show("Sửa thành công");
                LoadData(_sanPhamSer.Getview());
                Clear();
            }
            else if (result == 2)
            {
                MessageBox.Show("Tên không được để trống");
                LoadData(_sanPhamSer.Getview());
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void QuanLiSanPham_Load(object sender, EventArgs e)
        {
            LoadData(_sanPhamSer.Getview());
            foreach (var item in _sanPhamSer.GetAllTH())
            {
                cbb_Hang.Items.Add(item.Tenthuonghieu);
            }
            btn_add.Enabled = true;
            btn_delete.Enabled = false;
            btn_update.Enabled = false;
            txt_maSP.Enabled = false;
        }

        private void btn_Clean_Click(object sender, EventArgs e)
        {
            txt_maSP.Text = "";
            txt_tenSP.Text = "";
            // Xóa lựa chọn trong ComboBox nếu có
            cbb_Hang.ResetText();
            btn_add.Enabled = true;
            btn_delete.Enabled = false;
            btn_update.Enabled = false;
        }
        private void Clear()
        {
            txt_maSP.Text = "";
            txt_tenSP.Text = "";
            // Xóa lựa chọn trong ComboBox nếu có
            cbb_Hang.ResetText();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Lưu tham chiếu đến form hiện tại vào biến cục bộ
            Form currentForm = this;

            // Đóng form hiện tại (Form1)
            currentForm.Close();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            LoadData(_sanPhamSer.GetSearch1(txt_TimKiem.Text));
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadData(_sanPhamSer.GetSearch1(txt_TimKiem.Text));

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sảnPhẩmChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng của Form2
            QuanLiSanPhamChiTiet form2 = new QuanLiSanPhamChiTiet();

            //// Lưu tham chiếu đến form hiện tại vào biến cục bộ
            //Form currentForm = this;

            //// Đóng form hiện tại (Form1)
            //currentForm.Close();

            // Hiển thị Form2
            form2.Show();
        }
    }
}
