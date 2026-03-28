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
    public partial class FormThemNenMau : Form
    {
        public FormThemNenMau()
        {
            InitializeComponent();
            boxSoLuongViTri.Enter += (s, e) => boxSoLuongViTri.BorderColor = Color.FromArgb(0, 77, 64);
            boxSoLuongViTri.Leave += (s, e) => boxSoLuongViTri.BorderColor = Color.LightGray;

            cboxLoaiNenMau.Enter += (s, e) => cboxLoaiNenMau.BorderColor = Color.FromArgb(0, 77, 64);
            cboxLoaiNenMau.Leave += (s, e) => cboxLoaiNenMau.BorderColor = Color.LightGray;

            txtboxMaViTri.Enter += (s, e) => txtboxMaViTri.BorderColor = Color.FromArgb(0, 77, 64);
            txtboxMaViTri.Leave += (s, e) => txtboxMaViTri.BorderColor = Color.LightGray;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
