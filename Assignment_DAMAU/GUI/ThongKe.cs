﻿using Assignment_DAMAU.DAL;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_DAMAU.GUI
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }
        private void LoadDataToChart()
        {
            using (var db = new SACHEntities3()) // hoặc context của bạn
            {
                // Khởi tạo mảng 12 tháng, mặc định là 0
                int[] soLuongTheoThang = new int[12];

                // Lấy danh sách hóa đơn và nhóm theo tháng
                var thongKe = db.HOADONs
                    .Where(h => h.NGAYLAP != null)
                    .GroupBy(h => h.NGAYLAP.Value.Month)
                    .Select(g => new
                    {
                        Thang = g.Key,
                        SoLuong = g.Count()
                    }).ToList();

                // Gán vào mảng dữ liệu
                foreach (var item in thongKe)
                {
                    soLuongTheoThang[item.Thang - 1] = item.SoLuong;
                }

                // Gán vào biểu đồ
                cartesianChart1.Series = new ISeries[]
                {
            new ColumnSeries<int>
            {
                Values = soLuongTheoThang,
                Name = "Số lượng hóa đơn",
                Fill = new SolidColorPaint(SKColors.DeepSkyBlue)
            }
                };

                cartesianChart1.XAxes = new Axis[]
                {
            new Axis
            {
                Labels = new[] { "Th1", "Th2", "Th3", "Th4", "Th5", "Th6", "Th7", "Th8", "Th9", "Th10", "Th11", "Th12" },
                Name = "Tháng"
            }
                };

                cartesianChart1.YAxes = new Axis[]
                {
            new Axis
            {
                Name = "Số lượng"
            }
                };
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            LoadDataToChart();
        }
    }
}
