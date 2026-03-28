using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phòng_Kế_Hoạch
{
    public partial class UCPhanCongNhanVien : UserControl
    {
        public UCPhanCongNhanVien()
        {
            InitializeComponent();
            LoadDuLieuTam();
        }
        private void LoadDuLieuTam()
        {
            dgvPhanCongNVHT.Rows.Clear();
            dgvPhanCongNVHT.Rows.Add("KK1: Khu vực A", "Lê Văn C", "10/02/2026", "✓ Đã phân công");
            dgvPhanCongNVHT.Rows.Add("KK2: Khu vực B", "Trần Thị B", "10/02/2026", "✓ Đã phân công");
            dgvPhanCongNVHT.Rows.Add("KK3: Khu vực C", "-- Chọn NV --", "", "⚠ Chưa phân công");
        }
    }
}