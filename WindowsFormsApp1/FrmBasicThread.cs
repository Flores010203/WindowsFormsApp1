using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmBasicThread : Form
    {
        public FrmBasicThread()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-Before starting thread-");
            ThreadStart start = new ThreadStart(MyThreadClass.Thread1);
            Thread ThreadA = new Thread(MyThreadClass.Thread1);
            Thread ThreadB = new Thread(MyThreadClass.Thread1);

            ThreadA = new Thread(start);
            ThreadA.Name = "Thread A process = ";
            ThreadA.Start();

            ThreadB = new Thread(start);
            ThreadB.Name = "Thread B process = ";
            ThreadB.Start();


            ThreadA.Join();
            ThreadB.Join();
            Console.WriteLine("End Of Thread");
        }
    }
}
