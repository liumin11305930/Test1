using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //获取本地计算机中所有的进程
          Process[] ps=  Process.GetProcesses();
            foreach (Process item in ps)
            {
                Console.WriteLine(item.ProcessName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("devenv.exe");
        }
    }
}
