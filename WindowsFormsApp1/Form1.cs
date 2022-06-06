using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Programm start
        /// </summary>
        /// <param name="sender">Send command run</param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string name1 =textBox1.Text;
            string result = string.Format(name1+" ты супер!");
            label2.Text =result;
        }
    }
}
