using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_World_V_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Editing text for second button 
        private void button1_Click(object sender, EventArgs e)
        {
            helloButton2.Text = "And then click me!!!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            helloButton3.Text = "Then finally click me!!!";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            helloWorldText.Text = "Hello this sweet world of ours!!!";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            helloButton1.Text = "Now click me!!!";
        }
    }
}
