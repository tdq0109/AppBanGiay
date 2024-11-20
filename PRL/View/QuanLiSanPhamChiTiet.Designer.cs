namespace Project_SHOE.View
{
    partial class QuanLiSanPhamChiTiet
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            txt_giaban = new TextBox();
            cbb_Size = new ComboBox();
            cbb_ChatLieu = new ComboBox();
            label10 = new Label();
            cbb_Mau = new ComboBox();
            label12 = new Label();
            txt_soluong = new TextBox();
            label3 = new Label();
            label6 = new Label();
            label5 = new Label();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            quảnLýSảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            groupBox2 = new GroupBox();
            cbb_LoaiSP = new ComboBox();
            label7 = new Label();
            cbb_SP = new ComboBox();
            groupBox3 = new GroupBox();
            btn_Clean = new Button();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            groupBox4 = new GroupBox();
            label2 = new Label();
            cbb_LocSize = new ComboBox();
            dataGridView1 = new DataGridView();
            txt_Idspct = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 22);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 1;
            label1.Text = " Mã SP:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_giaban);
            groupBox1.Controls.Add(cbb_Size);
            groupBox1.Controls.Add(cbb_ChatLieu);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(cbb_Mau);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txt_soluong);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(90, 182);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(626, 89);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin";
            // 
            // txt_giaban
            // 
            txt_giaban.Location = new Point(106, 55);
            txt_giaban.Name = "txt_giaban";
            txt_giaban.Size = new Size(180, 23);
            txt_giaban.TabIndex = 11;
            // 
            // cbb_Size
            // 
            cbb_Size.FormattingEnabled = true;
            cbb_Size.Location = new Point(462, 22);
            cbb_Size.Name = "cbb_Size";
            cbb_Size.Size = new Size(125, 23);
            cbb_Size.TabIndex = 12;
            // 
            // cbb_ChatLieu
            // 
            cbb_ChatLieu.FormattingEnabled = true;
            cbb_ChatLieu.Location = new Point(103, 21);
            cbb_ChatLieu.Name = "cbb_ChatLieu";
            cbb_ChatLieu.Size = new Size(98, 23);
            cbb_ChatLieu.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(421, 25);
            label10.Name = "label10";
            label10.Size = new Size(30, 15);
            label10.TabIndex = 4;
            label10.Text = "Size:";
            // 
            // cbb_Mau
            // 
            cbb_Mau.FormattingEnabled = true;
            cbb_Mau.Location = new Point(262, 21);
            cbb_Mau.Name = "cbb_Mau";
            cbb_Mau.Size = new Size(125, 23);
            cbb_Mau.TabIndex = 12;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(34, 24);
            label12.Name = "label12";
            label12.Size = new Size(60, 15);
            label12.TabIndex = 4;
            label12.Text = "Chất Liệu:";
            // 
            // txt_soluong
            // 
            txt_soluong.Location = new Point(428, 54);
            txt_soluong.Name = "txt_soluong";
            txt_soluong.Size = new Size(180, 23);
            txt_soluong.TabIndex = 10;
            txt_soluong.TextChanged += txt_soluong_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(221, 23);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 4;
            label3.Text = "Màu:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(340, 56);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 6;
            label6.Text = "Số Lượng:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 56);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 5;
            label5.Text = "Giá Bán:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label9.ForeColor = SystemColors.HotTrack;
            label9.Location = new Point(159, 44);
            label9.Name = "label9";
            label9.Size = new Size(527, 54);
            label9.TabIndex = 23;
            label9.Text = "Quản Lý Sản Phẩm Chi Tiết";
            label9.Click += label9_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(15, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 84);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { thoátToolStripMenuItem, quảnLýSảnPhẩmToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 24;
            menuStrip1.Text = "menuStrip1";
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(49, 20);
            thoátToolStripMenuItem.Text = "Thoát";
            // 
            // quảnLýSảnPhẩmToolStripMenuItem
            // 
            quảnLýSảnPhẩmToolStripMenuItem.Name = "quảnLýSảnPhẩmToolStripMenuItem";
            quảnLýSảnPhẩmToolStripMenuItem.Size = new Size(118, 20);
            quảnLýSảnPhẩmToolStripMenuItem.Text = "Quản Lý Sản Phẩm";
            quảnLýSảnPhẩmToolStripMenuItem.Click += quảnLýSảnPhẩmToolStripMenuItem_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbb_LoaiSP);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(cbb_SP);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(90, 123);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(626, 54);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sách Sản Phẩm";
            // 
            // cbb_LoaiSP
            // 
            cbb_LoaiSP.FormattingEnabled = true;
            cbb_LoaiSP.Location = new Point(392, 20);
            cbb_LoaiSP.Name = "cbb_LoaiSP";
            cbb_LoaiSP.Size = new Size(178, 23);
            cbb_LoaiSP.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(331, 22);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 18;
            label7.Text = " Loại SP:";
            // 
            // cbb_SP
            // 
            cbb_SP.FormattingEnabled = true;
            cbb_SP.Location = new Point(99, 20);
            cbb_SP.Name = "cbb_SP";
            cbb_SP.Size = new Size(178, 23);
            cbb_SP.TabIndex = 17;
            cbb_SP.SelectedIndexChanged += cbb_SP_SelectedIndexChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_Clean);
            groupBox3.Controls.Add(btn_add);
            groupBox3.Controls.Add(btn_update);
            groupBox3.Controls.Add(btn_delete);
            groupBox3.Location = new Point(74, 277);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(668, 57);
            groupBox3.TabIndex = 26;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức Năng";
            // 
            // btn_Clean
            // 
            btn_Clean.Location = new Point(516, 20);
            btn_Clean.Name = "btn_Clean";
            btn_Clean.Size = new Size(95, 31);
            btn_Clean.TabIndex = 15;
            btn_Clean.Text = "Clean";
            btn_Clean.UseVisualStyleBackColor = true;
            btn_Clean.Click += btn_Clean_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(59, 20);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(95, 31);
            btn_add.TabIndex = 12;
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(217, 20);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(95, 31);
            btn_update.TabIndex = 13;
            btn_update.Text = "Sửa";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(370, 20);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(95, 31);
            btn_delete.TabIndex = 14;
            btn_delete.Text = "Xóa";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(cbb_LocSize);
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Controls.Add(txt_Idspct);
            groupBox4.Location = new Point(74, 338);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(668, 228);
            groupBox4.TabIndex = 27;
            groupBox4.TabStop = false;
            groupBox4.Text = "Dữ Liệu Sản Phẩm Chi Tiết";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 26);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 14;
            label2.Text = "Bộ Lọc Size:";
            // 
            // cbb_LocSize
            // 
            cbb_LocSize.FormattingEnabled = true;
            cbb_LocSize.Location = new Point(86, 23);
            cbb_LocSize.Name = "cbb_LocSize";
            cbb_LocSize.Size = new Size(98, 23);
            cbb_LocSize.TabIndex = 13;
            cbb_LocSize.SelectedIndexChanged += cbb_LocSize_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(5, 52);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(657, 172);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // txt_Idspct
            // 
            txt_Idspct.Location = new Point(24, 77);
            txt_Idspct.Name = "txt_Idspct";
            txt_Idspct.Size = new Size(25, 23);
            txt_Idspct.TabIndex = 13;
            // 
            // QuanLiSanPhamChiTiet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 581);
            Controls.Add(groupBox1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label9);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "QuanLiSanPhamChiTiet";
            Text = " Sản Phẩm Chi Tiết";
            Load += QuanLiSanPhamChiTiet_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txt_giaban;
        private TextBox txt_soluong;
        private Label label6;
        private Label label5;
        private Label label9;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ComboBox cbb_SP;
        private Button btn_Clean;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private ComboBox cbb_ChatLieu;
        private Label label12;
        private ComboBox cbb_Mau;
        private Label label3;
        private ComboBox cbb_Size;
        private Label label10;
        private ComboBox cbb_LoaiSP;
        private Label label7;
        private TextBox txt_Idspct;
        private Label label2;
        private ComboBox cbb_LocSize;
        private ToolStripMenuItem quảnLýSảnPhẩmToolStripMenuItem;
    }
}