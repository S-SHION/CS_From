﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;


namespace CS_Frpm
{
    internal class testbottun : Button
    {
        /// <summary>
        /// コンストラクタ
        /// クラスを生成したときに呼び出される
        /// </summary>
        public testbottun(int x, int y) 
        {
            //ClickイベントにOnClick関数を登録
            //ボタンをクリックした時に登録した関数を実行します。
            Click += OnClick;

            //ボタン内に文字を表示させる
            Text = "ボタン";

            Location = new Point(x,y);
        }



        ///<summarry>
        ///ボタンをクリックした際の処理を記述する
        ///</summarry>
        ///<param name="sender"></param>
        ///<param name="s"></param>
        public void OnClick(object sender,EventArgs s) 
        {
            MessageBox.Show("OK");
        }
    }
}
