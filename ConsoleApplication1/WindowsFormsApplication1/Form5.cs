using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread td = new Thread(() =>
            {
                FileStream file = new FileStream(@"E:\班机信息\理工15班\Y2\MVC\T1\1.txt", FileMode.Open);
                byte[] bt = new byte[file.Length];
                file.Read(bt, 0, bt.Length);
               string s= Encoding.Default.GetString(bt);
                // textBox1.Text = s;
                if (textBox1.InvokeRequired)
                {
                    Action<string, TextBox> at = (a, b) =>
                    {
                        b.Text = a;
                    };
                    textBox1.Invoke(at,s,textBox1);
                }
            });
            td.IsBackground = true;
            td.Start();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream(@"E:\班机信息\理工15班\Y2\MVC\T1\1.txt", FileMode.Open);
            byte[] bt = new byte[file.Length];
           // file.Read(bt, 0, bt.Length);
           await file.ReadAsync(bt, 0, bt.Length);
            string s = Encoding.Default.GetString(bt);
            textBox1.Text = s;
        }
    }
}
