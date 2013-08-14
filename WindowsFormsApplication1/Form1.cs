using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void button2_Click(object sender, EventArgs e)
        {
            string name = "Matt";
            MessageBox.Show(name);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Hey click me already", "HOVERING");
        }
    }
}
