using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Frpm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            testbottun Testbutton = new testbottun(0,0);
            Controls.Add(Testbutton);

            testbottun Testbutton2 = new testbottun(400,100);
            Controls.Add(Testbutton2);
        }
    }
}
