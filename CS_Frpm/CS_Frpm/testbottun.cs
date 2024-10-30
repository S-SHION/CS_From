using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;


namespace CS_Frpm
{
    internal class testbottun : Button
    {
        public testbottun() 
        {
            Click += OnClick;
        }

        public void OnClick(object sender,EventArgs s) 
        {
            MessageBox.Show("OK");
        }
    }
}
