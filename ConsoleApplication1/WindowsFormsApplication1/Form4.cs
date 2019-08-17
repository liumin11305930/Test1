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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread td = new Thread(()=> {
                for (int i = 0; i < 10; i++)
                {
                    if (i==5)
                    {
                        try
                        {
                            Thread.CurrentThread.Abort();//线程自杀
                        }
                        catch (Exception)
                        {

                            Thread.ResetAbort();//线程复活
                        }
                    }
                    Console.WriteLine(i);
                }
            });
            td.IsBackground = true;
            td.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread td = new Thread(()=> {

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(2000);
                }
            });
            td.IsBackground = true;
            td.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread td = new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("我是子线程，运行第{0}次",i);
                }
            });
            td.IsBackground = true;
            td.Start();
            td.Join();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("我是主线程，运行第 {0}次",i);
            }
        }
    }
}
