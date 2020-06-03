using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsCoreBsp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitControls();
        }

        private void InitControls()
        {
            labelAusgabe = new Label();
            labelAusgabe.Location = new Point(0, 0);
            labelAusgabe.Text = "ein Text";
            labelAusgabe.AutoSize = true;
            Controls.Add(labelAusgabe);
            gibaus = new Button();
            gibaus.Location = new Point(0, 40);
            gibaus.Text = "gib was aus";
            gibaus.AutoSize = true;
            gibaus.Click += new System.EventHandler(this.GibAus_Click);
            Controls.Add(gibaus);
        }

        private void GibAus_Click(object sender, EventArgs e)
        {
            labelAusgabe.Text = "neuer Text";
        }

        private Label labelAusgabe;
        private Button gibaus;
    }
}
