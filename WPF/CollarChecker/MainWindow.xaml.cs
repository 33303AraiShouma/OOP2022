using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace CollarChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            DataContext = GetColorList();
        }
        private MyColor[] GetColorList()
        {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        public class MyColor { 
            public Color Color { get; set; }
            public string Name { get; set; }
            public override string ToString() {
                return $"R:{Color.R} G:{Color.G} B:{Color.B}";
            }
        }
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            colorArea.Background = new SolidColorBrush(Color.FromRgb((byte)rSlider.Value,(byte)gSlider.Value,(byte)bSlider.Value));

        }

        private void Border_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            var mycolor = (MyColor)((ComboBox)sender).SelectedItem;
            var color = mycolor.Color;
            var name = mycolor.Name;

            colorArea.Background = new SolidColorBrush(Color.FromArgb(color.A,color.R,color.G,color.B));
            rValue.Text = color.R.ToString();
            gValue.Text = color.G.ToString();
            bValue.Text = color.B.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyColor item = new MyColor
            {
                Color = Color.FromRgb((byte)rSlider.Value, (byte)gSlider.Value, (byte)bSlider.Value)
            };

            stockList.Items.Add(item);
        }

        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e){
         

        }
    }
}
