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

namespace TestThreadPool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.tb_maxCompletionPortThreads.Text = "800";
            this.tb_maxWorkerThreads.Text = "800";
            this.tb_minCompletionPortThreads.Text = "400";
            this.tb_minWorkerThreads.Text = "400";
            this.tb_threadCount.Text = "1000";

            timer.Interval = 1000;
            timer.Tick += new EventHandler(UpdateThread);
            timer.Start();
        }

        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private static Object locks = new Object();

        public bool IsRunning { get; set; }
        public int RunningThreadCount { get; set; }
        public int CompleteThreadCount { get; set; }

        private Random random = new Random();

        private void bt_Start_Click(object sender, EventArgs e)
        {
            RunningThreadCount = 0;
            CompleteThreadCount = 0;
            IsRunning = true;
            TestMinTreads();
        }

        public void UpdateThread(object o, EventArgs e)
        {
            int availableWorkerThreads = 0;
            int availableCompletionPortThreads = 0;
            ThreadPool.GetAvailableThreads(out availableWorkerThreads, out availableCompletionPortThreads);
            this.rtb_result.AppendText(string.Format("availableWorkerThreads = {0};availableCompletionPortThreads = {1}\n", availableWorkerThreads, availableCompletionPortThreads));

            this.lb_RunningThreadCount.Text = "RunningThreadCount:" + RunningThreadCount;
            this.lb_CompleteThreadCount.Text = "CompleteThreadCount:" + CompleteThreadCount;
        }

        public void TestMinTreads()
        {
            ThreadPool.SetMaxThreads(int.Parse(this.tb_maxWorkerThreads.Text), int.Parse(this.tb_maxCompletionPortThreads.Text));
            ThreadPool.SetMinThreads(int.Parse(this.tb_minWorkerThreads.Text), int.Parse(this.tb_minCompletionPortThreads.Text));

            for (int i = 0; i < int.Parse(this.tb_threadCount.Text); i++)
            {
                Task.Factory.StartNew(testTask);
            }
        }

        //public void testTask()
        //{
        //    lock(locks)
        //    RunningThreadCount++;
        //    while (IsRunning)
        //        Thread.Sleep(10);
        //    lock (locks)
        //    RunningThreadCount--;
        //}

        public void testTask()
        {
            lock (locks)
            {
                RunningThreadCount++;
            }
            Thread.Sleep(random.Next(5000, 9000));
            lock (locks)
            {
                RunningThreadCount--;
                CompleteThreadCount++;
            }
        }

        private void bt_Stop_Click(object sender, EventArgs e)
        {
            IsRunning = false;
        }

        private void bt_AppendThreadCount_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < int.Parse(this.tb_threadCount.Text); i++)
            {
                Task.Factory.StartNew(testTask);
            }
        }
    }
}
