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

            int i;
            int n = 0;
            int s = 0;
            for (i = 0; i < 10; i++)
            {
               
                    testbottun Testbutton = new testbottun(n,s, 50, 50);
                                                         //
                    Controls.Add(Testbutton);
                n = n+50;
                if (n == n*4)
                {
                  s= s+50;
                  n = 0;
                }
            }
        }
    }
}
