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
               
                    testbottun Testbutton = new testbottun(i,n,s, 50, 50);
                    Controls.Add(Testbutton);
                n = n+50;
                if (n == 200) //((i+1)%4 == 0)
                {
                  s= s+50;
                  n = 0;
                }
            }
            /*  回答
            for (i = 0; i < 10; i++)
            {

                testbottun Testbutton = new testbottun(i*50,0, 50, 50);
                                                      ↑すでにカウントに使っているものを使うと効率がいい
                Controls.Add(Testbutton);

            }

            きれいな位置に配置する方法の回答
            for (i = 0; i < 10; i++)
            {

                testbottun Testbutton = new testbottun((i%3)*50,(i/3)*50, 50, 50);
                                                      //↑すでにカウントに使っているものを使うと効率がいい
                Controls.Add(Testbutton);

            }*/

            TestLabel testLabel = new TestLabel("ラベル",100,300,50,50);
            Controls.Add(testLabel);
        }
    }
}
