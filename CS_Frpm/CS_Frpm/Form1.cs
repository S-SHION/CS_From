﻿using System;
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

            testbottun Testbutton = new testbottun();

            Controls.Add(Testbutton);
        }
    }
}
