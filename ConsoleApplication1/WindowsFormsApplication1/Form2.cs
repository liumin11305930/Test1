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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int j = 0;
            for (int i = 0; i < 600000000; i++)
            {
                j += 1;
            }
            MessageBox.Show(j.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThreadStart ts = () =>
            {
                int j = 0;
                for (int i = 0; i < 600000000; i++)
                {
                    j += 1;
                }
                MessageBox.Show(j.ToString());
            };
            Thread td = new Thread(ts);
            td.Name = "子线程1";
            td.IsBackground = true;//设置为后台线程
            td.Start();//启动子线程
        }
    }
}
