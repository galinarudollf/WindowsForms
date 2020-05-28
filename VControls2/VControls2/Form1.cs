using System.Windows.Forms;

namespace VControls2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //KeyPreview = true;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        => Text = "Form - " + e.Location.ToString();

        private void button1_MouseDown(object sender, MouseEventArgs e)
        => (sender as Button).Text = "Button - " + e.Location.ToString();

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        => MessageBox.Show("Form1 Key Press Event");

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        => MessageBox.Show("Button1 Key Press Event");

        private void button2_KeyPress(object sender, KeyPressEventArgs e)
        => MessageBox.Show("Button2 Key Press Event");

    }
}
