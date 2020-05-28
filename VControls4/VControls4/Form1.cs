using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VControls4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread myThread = new Thread(new ThreadStart(myMethod));

            myThread.Start();

        }
        public void myMethod()
        {
            Thread.Sleep(2000);
            string newText = "Grüße aus dem Thread";
            //Invoke blockiert die Ausführung, bis er abgeschlossen ist (synchroner code)
            this.label1.Invoke((MethodInvoker)delegate
            {
                //Running on the UI thread
                this.label1.Text = newText;
            });
        }


        private async void button2_Click(object sender, EventArgs e)
        {
            var progress = new Progress<string>(s => label2.Text = s);
            await Task.Factory.StartNew(() => SecondThread.LongWork(progress),
                                        TaskCreationOptions.LongRunning);
            label2.Text = "completed";

        }
    }
    class SecondThread
    {
        public static void LongWork(IProgress<string> progress)
        {
            //Perform a long running work...
            for (var i = 0; i < 10; i++)
            {
                Task.Delay(500).Wait();
                progress.Report(i.ToString());
            }
        }
    }
}
