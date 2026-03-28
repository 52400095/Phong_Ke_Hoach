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
    public partial class FormPKH : Form
    {
        public FormPKH()
        {
            InitializeComponent();
        }

        private void lblTenNV_Click(object sender, EventArgs e)
        {

        }

        private void thanhngang2_Click(object sender, EventArgs e)
        {

        }

        private void pnlContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelNameApp_Click(object sender, EventArgs e)
        {

        }

        private void btnTienDoHopDong_Click(object sender, EventArgs e)
        {

        }

        private void btnLichSuPhanCong_Click(object sender, EventArgs e)
        {

        }

        private void btnTiepNhanDonHang_Click(object sender, EventArgs e)
        {

        }

        private void btnThietLapMau_Click(object sender, EventArgs e)
        {
            // 1. Xóa các giao diện cũ đang hiển thị trong Panel (nếu có)
            panelcontent.Controls.Clear();

            // 2. Khởi tạo giao diện User Control Thiết Lập Mẫu (Cái bạn vừa tạo ở Bước 1)
            UCThietLapMau ucThietLap = new UCThietLapMau();

            // 3. Cài đặt để nó phóng to lấp đầy toàn bộ cái Panel
            ucThietLap.Dock = DockStyle.Fill;

            // 4. Thêm nó vào Panel để hiển thị lên màn hình (KHÔNG nhét nút vào)
            panelcontent.Controls.Add(ucThietLap);
        }

        private void FormPKH_Load(object sender, EventArgs e)
        {

        }
    }
}
