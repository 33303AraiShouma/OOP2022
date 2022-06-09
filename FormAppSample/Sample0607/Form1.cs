using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0607 {
    public partial class Form1 : Form {
        private Random rand = new Random();

        private int randomNumber;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            //乱数取得 
            randomNumber = rand.Next(1, (int)Number1.Value);
            this.Text = randomNumber.ToString();
        }

        //判定ボタンイベントハンドラ
        private void btRandom_Click(object sender, EventArgs e) {
            //入力した値とあらかじめ取得した乱数を比較し結果を表示
            if (Number2.Value == randomNumber)
            {
                text.Text = "正解";
            }
            else if (Number2.Value > randomNumber)  {
                text.Text = "乱数は" + Number2.Value + "より小さいです";
            }
            else if (Number2.Value < randomNumber) {
                text.Text = "乱数は" + Number2.Value + "より大きいです";
            }
        }

        private void Number1_ValueChanged(object sender, EventArgs e) {
            randomNumber =rand.Next(1,(int)Number1.Value);
            this.Text = randomNumber.ToString();
        }
    }
}
