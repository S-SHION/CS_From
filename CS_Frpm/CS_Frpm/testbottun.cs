using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;


namespace CS_Frpm
{
    internal class testbottun : Button
    {

        Form1 _form1;

        TestTextBox _textbox;


        /// <summary>
        /// コンストラクタ
        /// クラスを生成したときに呼び出される
        /// </summary>

        public testbottun(Form1 form1,string st,int x, int y, int width,int height) 
        {
           
            _form1 = form1;

            //ClickイベントにOnClick関数を登録
            //ボタンをクリックした時に登録した関数を実行します。
            Click += OnClick;

            //ボタン内に文字を表示させる
            
            Text = st.ToString();
            

            //ボタンの位置を指定する
            Location = new Point(x,y);

            //ボタンの大きさを指定する
            Size = new Size(width, height);
        }



        ///<summarry>
        ///ボタンをクリックした際の処理を記述する
        ///</summarry>
        ///<param name="sender"></param>
        ///<param name="s"></param>
        //テキストボックスの作成
        

        public void OnClick(object sender,EventArgs s) 
        {


            _form1.LabelTextUpdate(Text);

            string w;

            w = Text;

            Text = _textbox.Text;
           
            _form1.TextBoxTextUpdate(w);
        }
    }
}
