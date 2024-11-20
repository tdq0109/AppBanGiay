namespace PRL.View
{
    partial class ThongKeForm
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
            label10 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            dataGridView2 = new DataGridView();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label10.ForeColor = SystemColors.HotTrack;
            label10.Location = new Point(292, 25);
            label10.Name = "label10";
            label10.Size = new Size(202, 54);
            label10.TabIndex = 30;
            label10.Text = "Thống Kê";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 311);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(358, 420);
            dataGridView1.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 288);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 32;
            label1.Text = "Thông Tin Hóa Đơn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(420, 250);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 33;
            label2.Text = "Tìm Kiếm";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(514, 247);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 27);
            textBox1.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 123);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 35;
            label3.Text = "Thông tin";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(413, 288);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 37;
            label4.Text = "Doanh Thu";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(413, 311);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(358, 420);
            dataGridView2.TabIndex = 38;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(121, 123);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(66, 24);
            checkBox1.TabIndex = 39;
            checkBox1.Text = "Ngày";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(121, 209);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(72, 24);
            checkBox2.TabIndex = 40;
            checkBox2.Text = "Tháng";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(121, 165);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(63, 24);
            checkBox3.TabIndex = 41;
            checkBox3.Text = "Tuần";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(276, 134);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 42;
            button1.Text = "Xuất File";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(276, 187);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 43;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ThongKeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 743);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(dataGridView2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(label10);
            Name = "ThongKeForm";
            Text = "ThongKeForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Button button1;
        private Button button2;
    }
}