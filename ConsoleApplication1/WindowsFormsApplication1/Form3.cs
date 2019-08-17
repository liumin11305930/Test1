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

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ParameterizedThreadStart ps = (obj) => {
                //Console.WriteLine("参数的值:"+obj);
                //StringBuilder sb = new StringBuilder();
                //sb.Append("线程名称:"+Thread.CurrentThread.Name+"\n");
                //sb.Append("线程优先级:"+Thread.CurrentThread.Priority+"\n");
                //sb.Append("线程的状态:"+Thread.CurrentThread.ThreadState + "\n");
                for (int i = 0; i < 50; i++)
                {
                    Console.WriteLine("我是{0},运行第{1}次", Thread.CurrentThread.Name, i);
                }
               
            };
            Thread td = new Thread(ps);
            td.Name = "子线程1";
            td.Priority = ThreadPriority.Highest;
            td.IsBackground = true;
            td.Start(2);

            ParameterizedThreadStart ps2 = (obj) => {
                //Console.WriteLine("参数的值:"+obj);
                //StringBuilder sb = new StringBuilder();
                //sb.Append("线程名称:"+Thread.CurrentThread.Name+"\n");
                //sb.Append("线程优先级:"+Thread.CurrentThread.Priority+"\n");
                //sb.Append("线程的状态:"+Thread.CurrentThread.ThreadState + "\n");
                for (int i = 0; i < 50; i++)
                {
                    Console.WriteLine("我是{0},运行第{1}次", Thread.CurrentThread.Name, i);
                }

            };
            Thread td2 = new Thread(ps2);
            td2.Name = "子线程2";
            td2.IsBackground = true;
            td2.Priority = ThreadPriority.Lowest;
            td2.Start(2);
        }
    }
}
