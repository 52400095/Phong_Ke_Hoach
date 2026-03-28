using System;
using System.Windows.Forms;
using System.Drawing;

namespace Phong_Ke_Hoach
{
    public partial class UCThietLapMau : UserControl
    {
        public UCThietLapMau()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.LocationLabel = new Label();
            this.LocationComboBox = new ComboBox();
            this.ParametersPanel = new FlowLayoutPanel();
            this.AddParameterButton = new Button();
            this.ColorPickerButton = new Button();
            this.TemplatesListBox = new ListBox();
            this.SaveTemplateButton = new Button();

            // Location Label
            this.LocationLabel.Text = "Select Location:";
            this.LocationLabel.Location = new Point(10, 10);
            this.Controls.Add(this.LocationLabel);

            // Location ComboBox
            this.LocationComboBox.Location = new Point(130, 10);
            this.Controls.Add(this.LocationComboBox);

            // Parameters Panel
            this.ParametersPanel.Location = new Point(10, 50);
            this.ParametersPanel.Size = new Size(300, 100);
            this.Controls.Add(this.ParametersPanel);

            // Add Parameter Button
            this.AddParameterButton.Text = "Add Parameter";
            this.AddParameterButton.Location = new Point(10, 160);
            this.AddParameterButton.Click += new EventHandler(this.AddParameterButton_Click);
            this.Controls.Add(this.AddParameterButton);

            // Color Picker Button
            this.ColorPickerButton.Text = "Select Color";
            this.ColorPickerButton.Location = new Point(150, 160);
            this.ColorPickerButton.Click += new EventHandler(this.ColorPickerButton_Click);
            this.Controls.Add(this.ColorPickerButton);

            // Templates ListBox
            this.TemplatesListBox.Location = new Point(10, 200);
            this.TemplatesListBox.Size = new Size(300, 100);
            this.Controls.Add(this.TemplatesListBox);

            // Save Template Button
            this.SaveTemplateButton.Text = "Save Template";
            this.SaveTemplateButton.Location = new Point(10, 310);
            this.SaveTemplateButton.Click += new EventHandler(this.SaveTemplateButton_Click);
            this.Controls.Add(this.SaveTemplateButton);
        }

        private void AddParameterButton_Click(object sender, EventArgs e)
        {
            // Logic to add parameter to ParametersPanel
        }

        private void ColorPickerButton_Click(object sender, EventArgs e)
        {
            // Logic to open color picker and set color
        }

        private void SaveTemplateButton_Click(object sender, EventArgs e)
        {
            // Logic to save the current template
        }
    }
}