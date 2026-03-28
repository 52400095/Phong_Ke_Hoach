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
    public partial class UCThietLapMau : UserControl
    {
        public UCThietLapMau()
        {
            InitializeComponent();
            btnThemNenMau.Enabled = false;
            cboxHopDong.Enabled = false;
            LoadComboBox();

            cboxCongTy.SelectedIndexChanged += (s, e) =>
            {
                if (cboxCongTy.SelectedIndex > 0)
                {
                    cboxHopDong.Enabled = true;
                    cboxHopDong.Items.Clear();
                    cboxHopDong.Items.Add("-- Chọn hợp đồng --");

                    if (cboxCongTy.SelectedItem.ToString() == "Nhà Máy Phú Lộc")
                    {
                        cboxHopDong.Items.Add("HĐ-001");
                        cboxHopDong.Items.Add("HĐ-002");
                    }
                    else if (cboxCongTy.SelectedItem.ToString() == "KCN Tân Tạo")
                    {
                        cboxHopDong.Items.Add("HĐ-003");
                        cboxHopDong.Items.Add("HĐ-004");
                    }
                    else if (cboxCongTy.SelectedItem.ToString() == "Sông Hương")
                    {
                        cboxHopDong.Items.Add("HĐ-005");
                        cboxHopDong.Items.Add("HĐ-006");
                    }

                    cboxHopDong.SelectedIndex = 0;
                }
                else
                {
                    cboxHopDong.Enabled = false;
                    cboxHopDong.Items.Clear();
                    cboxHopDong.Items.Add("-- Chọn hợp đồng --");
                    cboxHopDong.SelectedIndex = 0;
                }
                KiemTraDuDieuKien();
            };

            cboxHopDong.SelectedIndexChanged += (s, e) => KiemTraDuDieuKien();
        }

        private void KiemTraDuDieuKien()
        {
            btnThemNenMau.Enabled = cboxCongTy.SelectedIndex > 0
                                  && cboxHopDong.SelectedIndex > 0;
        }

        private void LoadComboBox()
        {
            cboxCongTy.Items.Clear();
            cboxCongTy.Items.Add("-- Chọn công ty --");
            cboxCongTy.Items.Add("Nhà Máy Phú Lộc");
            cboxCongTy.Items.Add("KCN Tân Tạo");
            cboxCongTy.Items.Add("Sông Hương");
            cboxCongTy.SelectedIndex = 0;

            cboxHopDong.Items.Clear();
            cboxHopDong.Items.Add("-- Chọn hợp đồng --");
            cboxHopDong.SelectedIndex = 0;
        }

        private void btnThemNenMau_Click(object sender, EventArgs e)
        {
            using (var form = new FormThemNenMau())
            {
                form.ShowDialog(this.FindForm());
            }
        }
    }
}