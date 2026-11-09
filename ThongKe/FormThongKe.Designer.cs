namespace HotelManagement.ThongKe
{
    partial class FormThongKe
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            panelHeader = new Panel();
            btnXuatExcel = new Button();
            btnThongKe = new Button();
            dtpDenNgay = new DateTimePicker();
            label2 = new Label();
            dtpTuNgay = new DateTimePicker();
            label1 = new Label();
            lblTieuDe = new Label();
            panelCards = new Panel();
            panelCard4 = new Panel();
            lblDoanhThuTB = new Label();
            label7 = new Label();
            panelCard3 = new Panel();
            lblSoLuotThue = new Label();
            label6 = new Label();
            panelCard2 = new Panel();
            lblSoHoaDon = new Label();
            label5 = new Label();
            panelCard1 = new Panel();
            lblTongDoanhThu = new Label();
            label3 = new Label();
            panelContent = new Panel();
            splitContainer = new SplitContainer();
            groupBox1 = new GroupBox();
            panelLoaiPhongContent = new Panel();
            dtgDoanhThuLoaiPhong = new DataGridView();
            chartLoaiPhong = new ScottPlot.WinForms.FormsPlot();
            groupBox2 = new GroupBox();
            panelNgayContent = new Panel();
            dtgDoanhThuTheoNgay = new DataGridView();
            chartTheoNgay = new ScottPlot.WinForms.FormsPlot();
            panelHeader.SuspendLayout();
            panelCards.SuspendLayout();
            panelCard4.SuspendLayout();
            panelCard3.SuspendLayout();
            panelCard2.SuspendLayout();
            panelCard1.SuspendLayout();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            groupBox1.SuspendLayout();
            panelLoaiPhongContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDoanhThuLoaiPhong).BeginInit();
            groupBox2.SuspendLayout();
            panelNgayContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDoanhThuTheoNgay).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(btnXuatExcel);
            panelHeader.Controls.Add(btnThongKe);
            panelHeader.Controls.Add(dtpDenNgay);
            panelHeader.Controls.Add(label2);
            panelHeader.Controls.Add(dtpTuNgay);
            panelHeader.Controls.Add(label1);
            panelHeader.Controls.Add(lblTieuDe);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1160, 85);
            panelHeader.TabIndex = 0;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXuatExcel.BackColor = Color.SeaGreen;
            btnXuatExcel.Cursor = Cursors.Hand;
            btnXuatExcel.FlatStyle = FlatStyle.Flat;
            btnXuatExcel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXuatExcel.ForeColor = Color.White;
            btnXuatExcel.Location = new Point(1021, 42);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(125, 33);
            btnXuatExcel.TabIndex = 6;
            btnXuatExcel.Text = "Xuất Excel";
            btnXuatExcel.UseVisualStyleBackColor = false;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThongKe.BackColor = Color.DarkTurquoise;
            btnThongKe.Cursor = Cursors.Hand;
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThongKe.ForeColor = Color.White;
            btnThongKe.Location = new Point(890, 42);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(125, 33);
            btnThongKe.TabIndex = 5;
            btnThongKe.Text = "Lọc dữ liệu";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            dtpDenNgay.Font = new Font("Segoe UI", 10F);
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new Point(722, 45);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(150, 30);
            dtpDenNgay.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(636, 48);
            label2.Name = "label2";
            label2.Size = new Size(86, 23);
            label2.TabIndex = 3;
            label2.Text = "Đến ngày:";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            dtpTuNgay.Font = new Font("Segoe UI", 10F);
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new Point(470, 45);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(150, 30);
            dtpTuNgay.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(394, 48);
            label1.Name = "label1";
            label1.Size = new Size(75, 23);
            label1.TabIndex = 1;
            label1.Text = "Từ ngày:";
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.DarkSlateGray;
            lblTieuDe.Location = new Point(14, 18);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(309, 37);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "BÁO CÁO DOANH THU";
            // 
            // panelCards
            // 
            panelCards.BackColor = Color.FromArgb(245, 247, 250);
            panelCards.Controls.Add(panelCard4);
            panelCards.Controls.Add(panelCard3);
            panelCards.Controls.Add(panelCard2);
            panelCards.Controls.Add(panelCard1);
            panelCards.Dock = DockStyle.Top;
            panelCards.Location = new Point(0, 85);
            panelCards.Name = "panelCards";
            panelCards.Padding = new Padding(14, 12, 14, 12);
            panelCards.Size = new Size(1160, 120);
            panelCards.TabIndex = 1;
            // 
            // panelCard4
            // 
            panelCard4.BackColor = Color.FromArgb(230, 126, 34);
            panelCard4.Controls.Add(lblDoanhThuTB);
            panelCard4.Controls.Add(label7);
            panelCard4.Location = new Point(798, 12);
            panelCard4.Name = "panelCard4";
            panelCard4.Size = new Size(250, 95);
            panelCard4.TabIndex = 3;
            // 
            // lblDoanhThuTB
            // 
            lblDoanhThuTB.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblDoanhThuTB.ForeColor = Color.White;
            lblDoanhThuTB.Location = new Point(10, 42);
            lblDoanhThuTB.Name = "lblDoanhThuTB";
            lblDoanhThuTB.Size = new Size(230, 42);
            lblDoanhThuTB.TabIndex = 1;
            lblDoanhThuTB.Text = "0 VNĐ";
            lblDoanhThuTB.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(10, 12);
            label7.Name = "label7";
            label7.Size = new Size(162, 21);
            label7.TabIndex = 0;
            label7.Text = "DOANH THU TB / HĐ";
            // 
            // panelCard3
            // 
            panelCard3.BackColor = Color.FromArgb(155, 89, 182);
            panelCard3.Controls.Add(lblSoLuotThue);
            panelCard3.Controls.Add(label6);
            panelCard3.Location = new Point(536, 12);
            panelCard3.Name = "panelCard3";
            panelCard3.Size = new Size(250, 95);
            panelCard3.TabIndex = 2;
            // 
            // lblSoLuotThue
            // 
            lblSoLuotThue.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblSoLuotThue.ForeColor = Color.White;
            lblSoLuotThue.Location = new Point(10, 42);
            lblSoLuotThue.Name = "lblSoLuotThue";
            lblSoLuotThue.Size = new Size(230, 42);
            lblSoLuotThue.TabIndex = 1;
            lblSoLuotThue.Text = "0";
            lblSoLuotThue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(10, 12);
            label6.Name = "label6";
            label6.Size = new Size(157, 21);
            label6.TabIndex = 0;
            label6.Text = "LƯỢT PHÒNG THUÊ";
            // 
            // panelCard2
            // 
            panelCard2.BackColor = Color.FromArgb(46, 204, 113);
            panelCard2.Controls.Add(lblSoHoaDon);
            panelCard2.Controls.Add(label5);
            panelCard2.Location = new Point(274, 12);
            panelCard2.Name = "panelCard2";
            panelCard2.Size = new Size(250, 95);
            panelCard2.TabIndex = 1;
            // 
            // lblSoHoaDon
            // 
            lblSoHoaDon.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblSoHoaDon.ForeColor = Color.White;
            lblSoHoaDon.Location = new Point(10, 42);
            lblSoHoaDon.Name = "lblSoHoaDon";
            lblSoHoaDon.Size = new Size(230, 42);
            lblSoHoaDon.TabIndex = 1;
            lblSoHoaDon.Text = "0";
            lblSoHoaDon.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(10, 12);
            label5.Name = "label5";
            label5.Size = new Size(160, 21);
            label5.TabIndex = 0;
            label5.Text = "TỔNG SỐ HÓA ĐƠN";
            // 
            // panelCard1
            // 
            panelCard1.BackColor = Color.FromArgb(52, 152, 219);
            panelCard1.Controls.Add(lblTongDoanhThu);
            panelCard1.Controls.Add(label3);
            panelCard1.Location = new Point(12, 12);
            panelCard1.Name = "panelCard1";
            panelCard1.Size = new Size(250, 95);
            panelCard1.TabIndex = 0;
            // 
            // lblTongDoanhThu
            // 
            lblTongDoanhThu.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTongDoanhThu.ForeColor = Color.White;
            lblTongDoanhThu.Location = new Point(10, 42);
            lblTongDoanhThu.Name = "lblTongDoanhThu";
            lblTongDoanhThu.Size = new Size(230, 42);
            lblTongDoanhThu.TabIndex = 1;
            lblTongDoanhThu.Text = "0 VNĐ";
            lblTongDoanhThu.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(10, 12);
            label3.Name = "label3";
            label3.Size = new Size(149, 21);
            label3.TabIndex = 0;
            label3.Text = "TỔNG DOANH THU";
            // 
            // panelContent
            // 
            panelContent.Controls.Add(splitContainer);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 205);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(14);
            panelContent.Size = new Size(1160, 520);
            panelContent.TabIndex = 2;
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(14, 14);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(groupBox2);
            splitContainer.Size = new Size(1132, 492);
            splitContainer.SplitterDistance = 560;
            splitContainer.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panelLoaiPhongContent);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.ForeColor = Color.DarkSlateGray;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10);
            groupBox1.Size = new Size(560, 492);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "DOANH THU THEO LOẠI PHÒNG (BIỂU ĐỒ & BẢNG)";
            // 
            // panelLoaiPhongContent
            // 
            panelLoaiPhongContent.Controls.Add(dtgDoanhThuLoaiPhong);
            panelLoaiPhongContent.Controls.Add(chartLoaiPhong);
            panelLoaiPhongContent.Dock = DockStyle.Fill;
            panelLoaiPhongContent.Location = new Point(10, 33);
            panelLoaiPhongContent.Name = "panelLoaiPhongContent";
            panelLoaiPhongContent.Size = new Size(540, 449);
            panelLoaiPhongContent.TabIndex = 0;
            // 
            // dtgDoanhThuLoaiPhong
            // 
            dtgDoanhThuLoaiPhong.AllowUserToAddRows = false;
            dtgDoanhThuLoaiPhong.AllowUserToDeleteRows = false;
            dtgDoanhThuLoaiPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDoanhThuLoaiPhong.BackgroundColor = Color.White;
            dtgDoanhThuLoaiPhong.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(240, 243, 246);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgDoanhThuLoaiPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgDoanhThuLoaiPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDoanhThuLoaiPhong.Dock = DockStyle.Fill;
            dtgDoanhThuLoaiPhong.Location = new Point(0, 230);
            dtgDoanhThuLoaiPhong.MultiSelect = false;
            dtgDoanhThuLoaiPhong.Name = "dtgDoanhThuLoaiPhong";
            dtgDoanhThuLoaiPhong.ReadOnly = true;
            dtgDoanhThuLoaiPhong.RowHeadersVisible = false;
            dtgDoanhThuLoaiPhong.RowHeadersWidth = 51;
            dtgDoanhThuLoaiPhong.RowTemplate.Height = 29;
            dtgDoanhThuLoaiPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDoanhThuLoaiPhong.Size = new Size(540, 219);
            dtgDoanhThuLoaiPhong.TabIndex = 0;
            // 
            // chartLoaiPhong
            // 
            chartLoaiPhong.Dock = DockStyle.Top;
            chartLoaiPhong.Location = new Point(0, 0);
            chartLoaiPhong.Name = "chartLoaiPhong";
            chartLoaiPhong.Size = new Size(540, 230);
            chartLoaiPhong.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panelNgayContent);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox2.ForeColor = Color.DarkSlateGray;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(10);
            groupBox2.Size = new Size(568, 492);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "DOANH THU THEO NGÀY (BIỂU ĐỒ & BẢNG)";
            // 
            // panelNgayContent
            // 
            panelNgayContent.Controls.Add(dtgDoanhThuTheoNgay);
            panelNgayContent.Controls.Add(chartTheoNgay);
            panelNgayContent.Dock = DockStyle.Fill;
            panelNgayContent.Location = new Point(10, 33);
            panelNgayContent.Name = "panelNgayContent";
            panelNgayContent.Size = new Size(548, 449);
            panelNgayContent.TabIndex = 0;
            // 
            // dtgDoanhThuTheoNgay
            // 
            dtgDoanhThuTheoNgay.AllowUserToAddRows = false;
            dtgDoanhThuTheoNgay.AllowUserToDeleteRows = false;
            dtgDoanhThuTheoNgay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDoanhThuTheoNgay.BackgroundColor = Color.White;
            dtgDoanhThuTheoNgay.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(240, 243, 246);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgDoanhThuTheoNgay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgDoanhThuTheoNgay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDoanhThuTheoNgay.Dock = DockStyle.Fill;
            dtgDoanhThuTheoNgay.Location = new Point(0, 230);
            dtgDoanhThuTheoNgay.MultiSelect = false;
            dtgDoanhThuTheoNgay.Name = "dtgDoanhThuTheoNgay";
            dtgDoanhThuTheoNgay.ReadOnly = true;
            dtgDoanhThuTheoNgay.RowHeadersVisible = false;
            dtgDoanhThuTheoNgay.RowHeadersWidth = 51;
            dtgDoanhThuTheoNgay.RowTemplate.Height = 29;
            dtgDoanhThuTheoNgay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDoanhThuTheoNgay.Size = new Size(548, 219);
            dtgDoanhThuTheoNgay.TabIndex = 0;
            // 
            // chartTheoNgay
            // 
            chartTheoNgay.Dock = DockStyle.Top;
            chartTheoNgay.Location = new Point(0, 0);
            chartTheoNgay.Name = "chartTheoNgay";
            chartTheoNgay.Size = new Size(548, 230);
            chartTheoNgay.TabIndex = 1;
            // 
            // FormThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1160, 725);
            Controls.Add(panelContent);
            Controls.Add(panelCards);
            Controls.Add(panelHeader);
            Name = "FormThongKe";
            Text = "Thống Kê Doanh Thu";
            Load += FormThongKe_Load;
            Resize += FormThongKe_Resize;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelCards.ResumeLayout(false);
            panelCard4.ResumeLayout(false);
            panelCard4.PerformLayout();
            panelCard3.ResumeLayout(false);
            panelCard3.PerformLayout();
            panelCard2.ResumeLayout(false);
            panelCard2.PerformLayout();
            panelCard1.ResumeLayout(false);
            panelCard1.PerformLayout();
            panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            splitContainer.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panelLoaiPhongContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgDoanhThuLoaiPhong).EndInit();
            groupBox2.ResumeLayout(false);
            panelNgayContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgDoanhThuTheoNgay).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTieuDe;
        private DateTimePicker dtpTuNgay;
        private Label label1;
        private DateTimePicker dtpDenNgay;
        private Label label2;
        private Button btnThongKe;
        private Button btnXuatExcel;
        private Panel panelCards;
        private Panel panelCard1;
        private Label label3;
        private Label lblTongDoanhThu;
        private Panel panelCard2;
        private Label lblSoHoaDon;
        private Label label5;
        private Panel panelCard3;
        private Label lblSoLuotThue;
        private Label label6;
        private Panel panelCard4;
        private Label lblDoanhThuTB;
        private Label label7;
        private Panel panelContent;
        private SplitContainer splitContainer;
        private GroupBox groupBox1;
        private Panel panelLoaiPhongContent;
        private DataGridView dtgDoanhThuLoaiPhong;
        private ScottPlot.WinForms.FormsPlot chartLoaiPhong;
        private GroupBox groupBox2;
        private Panel panelNgayContent;
        private DataGridView dtgDoanhThuTheoNgay;
        private ScottPlot.WinForms.FormsPlot chartTheoNgay;
    }
}
