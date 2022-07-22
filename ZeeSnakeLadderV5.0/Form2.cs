using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZeeSnakeLadderV5._0
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label2.Text = "Version " + Form1.gameVersion;
            label3.Text = "Last Updated: " + Form1.lastUpdateDate;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
