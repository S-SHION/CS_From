﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CS_Frpm
{
    public partial class Form1 : Form
    {

        /// <summary>
        /// ラベルの文字を更新したいため、
        /// Form1
        /// </summary>
        TestLabel _testLabel;

        TestTextBox _textbox;

        
        public Form1()
        {
           

            InitializeComponent();

            int i;
            int n = 0;
            int s = 0;
            string [] o =new string[10] {"a", "b", "c", "d", "e", "f", "g", "h", "i", "k"};
            for (i = 0; i < 10; i++) //テキストボタンを10個作成する
            {
                //ボタンの表示処理
                testbottun Testbutton = new testbottun(this, o[i],n,s, 50, 50);
                                                     // ↑自分自身を入れる 

                //ボタンの追加
                Controls.Add(Testbutton);           
                n = n+50;
                if (n == 200) //((i+1)%4 == 0)
                {
                  s= s+50;
                  n = 0;
                }
            }
            /*回答
            for (i = 0; i < 10; i++)
            {

                testbottun Testbutton = new testbottun(i*50,0, 50, 50);
                                                      ↑すでにカウントに使っているものを使うと効率がいい
                Controls.Add(Testbutton);

            }

            きれいな位置に配置する方法の回答
            for (i = 0; i < 10; i++)
            {

                testbottun Testbutton = new testbottun(this,i,(i%3)*50,(i/3)*50, 50, 50);
                                                      //↑すでにカウントに使っているものを使うと効率がいい
                Controls.Add(Testbutton);

            }*/

            //ラベルの作成
             _testLabel = new TestLabel("ラベル",500,300,100,100);

            //ラベルの追加
            Controls.Add(_testLabel);

            //テキストボックスの作成
            _textbox = new TestTextBox ("テキストボックス",10,400,500,100);

            //テキストボックスの追加
            Controls.Add(_textbox);
        }

        /// <summary>
        /// ラベルの文字を更新する
        /// </summary>
        /// <param name="str"></param>
        public void LabelTextUpdate(string str)
        {
            _testLabel.TextUpdate(str);
        }

        /// <summary>
        /// テキストボックスの文字を更新する
        /// </summary>
        /// <param name="str"></param>
        public string TextBoxTextUpdate(string str)
        {
            string s =_textbox.TextUpdate(str);

            return s;
        }
    }
}
