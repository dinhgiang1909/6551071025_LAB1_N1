using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ClosedXML.Excel;
using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;
using ScottPlot;

namespace HotelManagement.ThongKe
{
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            dtpTuNgay.Value = new DateTime(now.Year, now.Month, 1);
            dtpDenNgay.Value = now.Date;

            SapXepCards();
            TaiDuLieuThongKe();
        }

        private void FormThongKe_Resize(object sender, EventArgs e)
        {
            SapXepCards();
        }

        private void SapXepCards()
        {
            int totalW = panelCards.ClientSize.Width - panelCards.Padding.Left - panelCards.Padding.Right;
            int gap = 12;
            int cardW = Math.Max(180, (totalW - gap * 3) / 4);
            int cardH = panelCards.ClientSize.Height - panelCards.Padding.Top - panelCards.Padding.Bottom;
            int top = panelCards.Padding.Top;

            panelCard1.SetBounds(panelCards.Padding.Left, top, cardW, cardH);
            panelCard2.SetBounds(panelCards.Padding.Left + cardW + gap, top, cardW, cardH);
            panelCard3.SetBounds(panelCards.Padding.Left + (cardW + gap) * 2, top, cardW, cardH);
            panelCard4.SetBounds(panelCards.Padding.Left + (cardW + gap) * 3, top, cardW, cardH);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (dtpTuNgay.Value.Date > dtpDenNgay.Value.Date)
            {
                MessageBox.Show("Từ ngày không thể lớn hơn đến ngày!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TaiDuLieuThongKe();
        }

        private void TaiDuLieuThongKe()
        {
            try
            {
                DateTime tuNgay = dtpTuNgay.Value.Date;
                DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1).AddTicks(-1);

                using var db = new HotelManagementContext();

                var danhSachHd = db.HoaDons
                    .AsNoTracking()
                    .Include(h => h.MaCtdpNavigation)
                        .ThenInclude(c => c.MaPhNavigation)
                            .ThenInclude(p => p.MaLphNavigation)
                    .Where(h => h.DaXoa != true && h.NgHd >= tuNgay && h.NgHd <= denNgay)
                    .ToList();

                // 1. Thống kê thẻ KPI tổng quan
                decimal tongDoanhThu = danhSachHd.Sum(h => h.TriGia ?? 0);
                int soHoaDon = danhSachHd.Count;
                int soLuotThue = danhSachHd.Select(h => h.MaCtdp).Where(m => !string.IsNullOrEmpty(m)).Distinct().Count();
                decimal doanhThuTB = soHoaDon > 0 ? tongDoanhThu / soHoaDon : 0;

                lblTongDoanhThu.Text = tongDoanhThu.ToString("N0") + " VNĐ";
                lblSoHoaDon.Text = soHoaDon.ToString("N0");
                lblSoLuotThue.Text = soLuotThue.ToString("N0");
                lblDoanhThuTB.Text = doanhThuTB.ToString("N0") + " VNĐ";

                // 2. Doanh thu theo loại phòng
                var theoLoaiPhong = danhSachHd
                    .Where(h => h.MaCtdpNavigation?.MaPhNavigation?.MaLphNavigation != null)
                    .GroupBy(h => new
                    {
                        h.MaCtdpNavigation.MaPhNavigation.MaLphNavigation.MaLph,
                        h.MaCtdpNavigation.MaPhNavigation.MaLphNavigation.TenLph
                    })
                    .Select(g => new
                    {
                        MaLoaiPhong = g.Key.MaLph,
                        TenLoaiPhong = g.Key.TenLph,
                        SoLuot = g.Count(),
                        DoanhThu = g.Sum(x => x.TriGia ?? 0)
                    })
                    .OrderByDescending(x => x.DoanhThu)
                    .ToList();

                DataTable dtLoaiPhong = new DataTable();
                dtLoaiPhong.Columns.Add("STT", typeof(int));
                dtLoaiPhong.Columns.Add("Mã loại", typeof(string));
                dtLoaiPhong.Columns.Add("Tên loại phòng", typeof(string));
                dtLoaiPhong.Columns.Add("Số lượt", typeof(int));
                dtLoaiPhong.Columns.Add("Doanh thu (VNĐ)", typeof(string));

                int stt = 1;
                foreach (var lp in theoLoaiPhong)
                {
                    dtLoaiPhong.Rows.Add(stt++, lp.MaLoaiPhong, lp.TenLoaiPhong, lp.SoLuot, lp.DoanhThu.ToString("N0"));
                }
                dtgDoanhThuLoaiPhong.DataSource = dtLoaiPhong;

                // Cập nhật Biểu đồ Loại Phòng (Pie chart hoặc Bar chart)
                CapNhatBieuDoLoaiPhong(theoLoaiPhong.Select(x => (x.TenLoaiPhong, (double)x.DoanhThu)).ToList());

                // 3. Doanh thu theo từng ngày
                var theoNgay = danhSachHd
                    .Where(h => h.NgHd.HasValue)
                    .GroupBy(h => h.NgHd.Value.Date)
                    .Select(g => new
                    {
                        Ngay = g.Key,
                        SoHoaDon = g.Count(),
                        DoanhThu = g.Sum(x => x.TriGia ?? 0)
                    })
                    .OrderBy(x => x.Ngay)
                    .ToList();

                DataTable dtTheoNgay = new DataTable();
                dtTheoNgay.Columns.Add("STT", typeof(int));
                dtTheoNgay.Columns.Add("Ngày", typeof(string));
                dtTheoNgay.Columns.Add("Số hóa đơn", typeof(int));
                dtTheoNgay.Columns.Add("Tổng thu (VNĐ)", typeof(string));

                stt = 1;
                foreach (var item in theoNgay)
                {
                    dtTheoNgay.Rows.Add(stt++, item.Ngay.ToString("dd/MM/yyyy"), item.SoHoaDon, item.DoanhThu.ToString("N0"));
                }
                dtgDoanhThuTheoNgay.DataSource = dtTheoNgay;

                // Cập nhật Biểu đồ Cột theo Ngày
                CapNhatBieuDoTheoNgay(theoNgay.Select(x => (x.Ngay.ToString("dd/MM"), (double)x.DoanhThu)).ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tổng hợp báo cáo thống kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CapNhatBieuDoLoaiPhong(List<(string Ten, double DoanhThu)> data)
        {
            chartLoaiPhong.Plot.Clear();
            if (data.Count == 0)
            {
                chartLoaiPhong.Plot.Title("Chưa có dữ liệu loại phòng");
                chartLoaiPhong.Refresh();
                return;
            }

            var bars = new List<ScottPlot.Bar>();
            var tickLabels = new List<string>();

            for (int i = 0; i < data.Count; i++)
            {
                bars.Add(new ScottPlot.Bar
                {
                    Position = i,
                    Value = data[i].DoanhThu,
                    FillColor = ScottPlot.Colors.Category10[i % 10]
                });
                tickLabels.Add(data[i].Ten);
            }

            chartLoaiPhong.Plot.Add.Bars(bars);
            chartLoaiPhong.Plot.Axes.Bottom.SetTicks(Enumerable.Range(0, data.Count).Select(x => (double)x).ToArray(), tickLabels.ToArray());
            chartLoaiPhong.Plot.Axes.Bottom.TickLabelStyle.Rotation = 15;
            chartLoaiPhong.Plot.Title("Doanh thu theo Loại phòng");
            chartLoaiPhong.Plot.Axes.AutoScale();
            chartLoaiPhong.Refresh();
        }

        private void CapNhatBieuDoTheoNgay(List<(string Ngay, double DoanhThu)> data)
        {
            chartTheoNgay.Plot.Clear();
            if (data.Count == 0)
            {
                chartTheoNgay.Plot.Title("Chưa có dữ liệu doanh thu ngày");
                chartTheoNgay.Refresh();
                return;
            }

            var bars = new List<ScottPlot.Bar>();
            var tickLabels = new List<string>();

            for (int i = 0; i < data.Count; i++)
            {
                bars.Add(new ScottPlot.Bar
                {
                    Position = i,
                    Value = data[i].DoanhThu,
                    FillColor = ScottPlot.Colors.SteelBlue
                });
                tickLabels.Add(data[i].Ngay);
            }

            chartTheoNgay.Plot.Add.Bars(bars);
            chartTheoNgay.Plot.Axes.Bottom.SetTicks(Enumerable.Range(0, data.Count).Select(x => (double)x).ToArray(), tickLabels.ToArray());
            chartTheoNgay.Plot.Axes.Bottom.TickLabelStyle.Rotation = 25;
            chartTheoNgay.Plot.Title("Biểu đồ Doanh thu theo Ngày");
            chartTheoNgay.Plot.Axes.AutoScale();
            chartTheoNgay.Refresh();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (dtgDoanhThuLoaiPhong.Rows.Count == 0 && dtgDoanhThuTheoNgay.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu thống kê để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using var sfd = new SaveFileDialog();
            sfd.Filter = "Excel Files (*.xlsx)|*.xlsx";
            sfd.FileName = $"BaoCaoDoanhThu_{dtpTuNgay.Value:yyyyMMdd}_{dtpDenNgay.Value:yyyyMMdd}.xlsx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using var workbook = new XLWorkbook();

                    var wsNgay = workbook.Worksheets.Add("Doanh thu theo ngày");
                    wsNgay.Cell(1, 1).Value = "BÁO CÁO DOANH THU THEO NGÀY";
                    wsNgay.Cell(1, 1).Style.Font.Bold = true;
                    wsNgay.Cell(1, 1).Style.Font.FontSize = 14;
                    wsNgay.Cell(2, 1).Value = $"Từ ngày: {dtpTuNgay.Value:dd/MM/yyyy} - Đến ngày: {dtpDenNgay.Value:dd/MM/yyyy}";

                    if (dtgDoanhThuTheoNgay.DataSource is DataTable dtN)
                    {
                        wsNgay.Cell(4, 1).InsertTable(dtN);
                    }
                    wsNgay.Columns().AdjustToContents();

                    var wsLp = workbook.Worksheets.Add("Doanh thu theo loại phòng");
                    wsLp.Cell(1, 1).Value = "BÁO CÁO DOANH THU THEO LOẠI PHÒNG";
                    wsLp.Cell(1, 1).Style.Font.Bold = true;
                    wsLp.Cell(1, 1).Style.Font.FontSize = 14;
                    wsLp.Cell(2, 1).Value = $"Từ ngày: {dtpTuNgay.Value:dd/MM/yyyy} - Đến ngày: {dtpDenNgay.Value:dd/MM/yyyy}";

                    if (dtgDoanhThuLoaiPhong.DataSource is DataTable dtL)
                    {
                        wsLp.Cell(4, 1).InsertTable(dtL);
                    }
                    wsLp.Columns().AdjustToContents();

                    workbook.SaveAs(sfd.FileName);

                    var res = MessageBox.Show("Xuất báo cáo thống kê Excel thành công!\nBạn có muốn mở file vừa xuất không?",
                        "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (res == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                        {
                            FileName = sfd.FileName,
                            UseShellExecute = true
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất file Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
