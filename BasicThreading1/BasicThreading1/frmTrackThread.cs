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

namespace BasicThreading1
{
    public partial class frmTrackThread : Form
    {

        public frmTrackThread()
        {
            InitializeComponent();
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            ThreadStart Thread1 = new ThreadStart(MyThreadClass.Thread1);
            ThreadStart Thread2 = new ThreadStart(MyThreadClass.Thread2);

            Thread ThreadA = new Thread(Thread1);
            Thread ThreadB = new Thread(Thread2);
            Thread ThreadC = new Thread(Thread1);
            Thread ThreadD = new Thread(Thread2);

            ThreadA.Name = "Thread A Process";
            ThreadB.Name = "Thread B Process";
            ThreadC.Name = "Thread C Process";
            ThreadD.Name = "Thread D Process";

            ThreadA.Priority = ThreadPriority.Highest;
            ThreadB.Priority = ThreadPriority.Normal;
            ThreadC.Priority = ThreadPriority.AboveNormal;
            ThreadD.Priority = ThreadPriority.BelowNormal;
          
            ThreadA.Start();
            ThreadB.Start();
            ThreadC.Start();
            ThreadD.Start();

            ThreadA.Join();
            ThreadB.Join();
            ThreadC.Join();
            ThreadD.Join();

            label1.Text = "-End of thread-";
            Console.WriteLine(label1.Text.ToString());
        }
    }
}
