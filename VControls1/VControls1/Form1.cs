using System;
using System.Drawing;
using System.Windows.Forms;

namespace VControls1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGibAus_Click(object sender, EventArgs e)
        {
            this.labelAusgabe.Text = this.textBoxEingabe.Text;
            this.pictureUnpassend.Image = Image.FromFile("bb-8.png");
        }
    }
}
