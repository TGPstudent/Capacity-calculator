using MetroFramework.Components;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace Capacity_calculator
{
    public partial class Form_Info : MetroForm
    {
        public Form_Info()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
