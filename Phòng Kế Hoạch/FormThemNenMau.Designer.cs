namespace Phòng_Kế_Hoạch
{
    partial class FormThemNenMau
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
            this.components = new System.ComponentModel.Container();
            this.labelThemNenMau = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.thanhngang1 = new Guna.UI2.WinForms.Guna2Separator();
            this.labelLoaiNenMau = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboxLoaiNenMau = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelSoLuongViTri = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.boxSoLuongViTri = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.labelMaViTri = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtboxMaViTri = new Guna.UI2.WinForms.Guna2TextBox();
            this.thanhngang2 = new Guna.UI2.WinForms.Guna2Separator();
            this.btnTaoNenMau = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.boxSoLuongViTri)).BeginInit();
            this.SuspendLayout();
            // 
            // labelThemNenMau
            // 
            this.labelThemNenMau.BackColor = System.Drawing.Color.Transparent;
            this.labelThemNenMau.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelThemNenMau.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelThemNenMau.Location = new System.Drawing.Point(12, 12);
            this.labelThemNenMau.Name = "labelThemNenMau";
            this.labelThemNenMau.Size = new System.Drawing.Size(215, 26);
            this.labelThemNenMau.TabIndex = 6;
            this.labelThemNenMau.Text = "THÊM NỀN MẪU MỚI";
            // 
            // thanhngang1
            // 
            this.thanhngang1.Location = new System.Drawing.Point(-3, 44);
            this.thanhngang1.Name = "thanhngang1";
            this.thanhngang1.Size = new System.Drawing.Size(606, 10);
            this.thanhngang1.TabIndex = 7;
            // 
            // labelLoaiNenMau
            // 
            this.labelLoaiNenMau.BackColor = System.Drawing.Color.Transparent;
            this.labelLoaiNenMau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelLoaiNenMau.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelLoaiNenMau.Location = new System.Drawing.Point(12, 60);
            this.labelLoaiNenMau.Name = "labelLoaiNenMau";
            this.labelLoaiNenMau.Size = new System.Drawing.Size(122, 21);
            this.labelLoaiNenMau.TabIndex = 8;
            this.labelLoaiNenMau.Text = "LOẠI NỀN MẪU";
            // 
            // cboxLoaiNenMau
            // 
            this.cboxLoaiNenMau.BackColor = System.Drawing.Color.Transparent;
            this.cboxLoaiNenMau.BorderRadius = 10;
            this.cboxLoaiNenMau.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxLoaiNenMau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxLoaiNenMau.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxLoaiNenMau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxLoaiNenMau.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.cboxLoaiNenMau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboxLoaiNenMau.ItemHeight = 30;
            this.cboxLoaiNenMau.Location = new System.Drawing.Point(12, 87);
            this.cboxLoaiNenMau.Name = "cboxLoaiNenMau";
            this.cboxLoaiNenMau.Size = new System.Drawing.Size(560, 36);
            this.cboxLoaiNenMau.TabIndex = 9;
            // 
            // labelSoLuongViTri
            // 
            this.labelSoLuongViTri.BackColor = System.Drawing.Color.Transparent;
            this.labelSoLuongViTri.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelSoLuongViTri.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelSoLuongViTri.Location = new System.Drawing.Point(12, 129);
            this.labelSoLuongViTri.Name = "labelSoLuongViTri";
            this.labelSoLuongViTri.Size = new System.Drawing.Size(140, 21);
            this.labelSoLuongViTri.TabIndex = 10;
            this.labelSoLuongViTri.Text = "SỐ LƯỢNG VỊ TRÍ";
            // 
            // boxSoLuongViTri
            // 
            this.boxSoLuongViTri.BackColor = System.Drawing.Color.Transparent;
            this.boxSoLuongViTri.BorderRadius = 10;
            this.boxSoLuongViTri.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.boxSoLuongViTri.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.boxSoLuongViTri.Location = new System.Drawing.Point(12, 156);
            this.boxSoLuongViTri.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.boxSoLuongViTri.Name = "boxSoLuongViTri";
            this.boxSoLuongViTri.Size = new System.Drawing.Size(560, 36);
            this.boxSoLuongViTri.TabIndex = 11;
            this.boxSoLuongViTri.UpDownButtonFillColor = System.Drawing.Color.White;
            this.boxSoLuongViTri.UpDownButtonForeColor = System.Drawing.Color.Green;
            this.boxSoLuongViTri.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelMaViTri
            // 
            this.labelMaViTri.BackColor = System.Drawing.Color.Transparent;
            this.labelMaViTri.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelMaViTri.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelMaViTri.Location = new System.Drawing.Point(12, 198);
            this.labelMaViTri.Name = "labelMaViTri";
            this.labelMaViTri.Size = new System.Drawing.Size(238, 21);
            this.labelMaViTri.TabIndex = 12;
            this.labelMaViTri.Text = "MÃ VỊ TRÍ (tự động tạo theo mẫu)";
            // 
            // txtboxMaViTri
            // 
            this.txtboxMaViTri.BorderRadius = 10;
            this.txtboxMaViTri.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxMaViTri.DefaultText = "";
            this.txtboxMaViTri.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtboxMaViTri.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtboxMaViTri.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxMaViTri.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxMaViTri.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxMaViTri.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.txtboxMaViTri.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxMaViTri.Location = new System.Drawing.Point(10, 225);
            this.txtboxMaViTri.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtboxMaViTri.Name = "txtboxMaViTri";
            this.txtboxMaViTri.PlaceholderText = "";
            this.txtboxMaViTri.SelectedText = "";
            this.txtboxMaViTri.Size = new System.Drawing.Size(562, 34);
            this.txtboxMaViTri.TabIndex = 13;
            // 
            // thanhngang2
            // 
            this.thanhngang2.Location = new System.Drawing.Point(-13, 274);
            this.thanhngang2.Name = "thanhngang2";
            this.thanhngang2.Size = new System.Drawing.Size(606, 10);
            this.thanhngang2.TabIndex = 14;
            // 
            // btnTaoNenMau
            // 
            this.btnTaoNenMau.BorderRadius = 15;
            this.btnTaoNenMau.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTaoNenMau.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTaoNenMau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTaoNenMau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTaoNenMau.FillColor = System.Drawing.Color.ForestGreen;
            this.btnTaoNenMau.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnTaoNenMau.ForeColor = System.Drawing.Color.White;
            this.btnTaoNenMau.Location = new System.Drawing.Point(358, 290);
            this.btnTaoNenMau.Name = "btnTaoNenMau";
            this.btnTaoNenMau.Size = new System.Drawing.Size(214, 46);
            this.btnTaoNenMau.TabIndex = 15;
            this.btnTaoNenMau.Text = "Tạo Nền Mẫu";
            // 
            // btnHuy
            // 
            this.btnHuy.BorderRadius = 15;
            this.btnHuy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHuy.FillColor = System.Drawing.Color.DarkGray;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(252, 290);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 46);
            this.btnHuy.TabIndex = 16;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // FormThemNenMau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 346);
            this.ControlBox = false;
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnTaoNenMau);
            this.Controls.Add(this.thanhngang2);
            this.Controls.Add(this.txtboxMaViTri);
            this.Controls.Add(this.labelMaViTri);
            this.Controls.Add(this.boxSoLuongViTri);
            this.Controls.Add(this.labelSoLuongViTri);
            this.Controls.Add(this.cboxLoaiNenMau);
            this.Controls.Add(this.labelLoaiNenMau);
            this.Controls.Add(this.thanhngang1);
            this.Controls.Add(this.labelThemNenMau);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThemNenMau";
            this.ShowIcon = false;
            this.Text = "FormThemNenMau";
            ((System.ComponentModel.ISupportInitialize)(this.boxSoLuongViTri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel labelThemNenMau;
        private Guna.UI2.WinForms.Guna2Separator thanhngang1;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelLoaiNenMau;
        private Guna.UI2.WinForms.Guna2ComboBox cboxLoaiNenMau;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelSoLuongViTri;
        private Guna.UI2.WinForms.Guna2NumericUpDown boxSoLuongViTri;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelMaViTri;
        private Guna.UI2.WinForms.Guna2TextBox txtboxMaViTri;
        private Guna.UI2.WinForms.Guna2Separator thanhngang2;
        private Guna.UI2.WinForms.Guna2Button btnTaoNenMau;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}