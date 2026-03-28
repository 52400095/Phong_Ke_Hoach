using System;
using System.Windows.Forms;

namespace PhongKeHoach
{
    public partial class FormPKH : Form
    {
        public FormPKH()
        {
            InitializeComponent();
        }

        private void FormPKH_Load(object sender, EventArgs e)
        {
            // Load logic for the form
        }

        private void InitializeComponent()
        {
            this.Text = "Phòng Kế Hoạch";
            this.Size = new System.Drawing.Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Top Bar
            Panel topBar = new Panel();
            topBar.Dock = DockStyle.Top;
            topBar.Height = 50;
            topBar.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(topBar);

            // Sidebar
            Panel sideBar = new Panel();
            sideBar.Dock = DockStyle.Left;
            sideBar.Width = 200;
            sideBar.BackColor = System.Drawing.Color.White;
            this.Controls.Add(sideBar);

            // Tab Control
            TabControl tabControl = new TabControl();
            tabControl.Dock = DockStyle.Fill;
            this.Controls.Add(tabControl);

            // Creating Tabs
            for (int i = 1; i <= 7; i++)
            {
                TabPage tabPage = new TabPage("Tab " + i);
                tabPage.BackColor = System.Drawing.Color.White;
                tabControl.TabPages.Add(tabPage);

                // Tab content
                Label label = new Label();
                label.Text = "This is content for Tab " + i;
                label.Dock = DockStyle.Fill;
                label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                tabPage.Controls.Add(label);
            }
        }
    }
}