﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Frpm
{
    internal class TestTextBox : TextBox
    {

        /// <summary>
        /// コンストラクタ
        /// クラスを生成したときに呼び出される
        /// </summary>


        public TestTextBox (string str, int x, int y, int width, int height)
        {

            //テキストボックス内に文字を表示させる
            Text = str;


            //テキストボックスの生成場所を指定
            Location = new Point(x, y);

            //テキストボックスの大きさを指定する
            Size = new Size(width, height);

        }
        /// <summary>
        /// テキストボックスの文字更新関数
        /// </summary>
        /// <param name="str"></param>
        public string TextUpdate(string str)
        {
            string temp = Text;

            Text = str;

            return temp;
        }
    }
}
