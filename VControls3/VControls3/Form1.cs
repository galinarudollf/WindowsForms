using System;
using System.Drawing;
using System.Windows.Forms;

namespace VControls3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }





        private void button_Click(object sender, EventArgs e)
        {
            if (sender.Equals(button1)) MessageBox.Show("Button1");
            if (sender.Equals(button2)) MessageBox.Show("Button2");
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'b': this.BackColor = Color.Blue; break;
                case 'r': this.BackColor = Color.Red; break;
            }

        }

        private void button_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'b': (sender as Button).BackColor = Color.Blue; break;
                case 'r': (sender as Button).BackColor = Color.Red; break;
            }

        }

    }
}
