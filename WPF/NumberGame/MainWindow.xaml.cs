using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NumberGame {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        int number;
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            if (int.Parse(bt.Content.ToString()) == number)
            {
                infoDisp.Text = "正解!";
                bt.Background = Brushes.Red;
            }
            else {
                infoDisp.Text
                            = int.Parse((string)bt.Content) < number
                                                          ? "もっと大きいです！" : "もっと小さいです";
                bt.Background = int.Parse((string)bt.Content) < number
                                                    ? Brushes.Blue : Brushes.Green;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            infoDisp.Text = "ゲームスタート";
            number = new Random().Next(1, 25);//正解ナンバーを設定
            this.Title = number.ToString();//デバック用で正解を表示
        }
    }
}
