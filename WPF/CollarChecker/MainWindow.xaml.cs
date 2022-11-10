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

        List<MyColor> colorList = new List<MyColor>();
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
            colorArea.Background = new SolidColorBrush(Color.FromRgb((byte)rSlider.Value, (byte)gSlider.Value, (byte)bSlider.Value));

        }

        private void Border_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void setColor() {
            MyColor stColor = new MyColor();
            var r = byte.Parse(rValue.Text);
            var g = byte.Parse(gValue.Text);
            var b = byte.Parse(bValue.Text);
            stColor.Color =Color.FromRgb(r, g, b);
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            var mycolor = (MyColor)((ComboBox)sender).SelectedItem;
            var color = mycolor.Color;
            var name = mycolor.Name;

            colorArea.Background = new SolidColorBrush(Color.FromArgb(color.A, color.R, color.G, color.B));
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
            var colorName = ((IEnumerable<MyColor>)DataContext)
                .Where(c => c.Color.R == item.Color.R &&
                          c.Color.G == item.Color.G &&
                          c.Color.B == item.Color.B
                          ).FirstOrDefault();
            stockList.Items.Insert(0, colorName?.Name ?? "R:" + rValue.Text + "G:" + gValue.Text +"B:" + bValue.Text);
            colorList.Insert(0, item);

        }

        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (stockList.SelectedIndex == -1) return;
            rSlider.Value = colorList[stockList.SelectedIndex].Color.R;
            gSlider.Value = colorList[stockList.SelectedIndex].Color.G;
            bSlider.Value = colorList[stockList.SelectedIndex].Color.B;
            setColor();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (stockList.SelectedIndex == -1) return;
            colorList.RemoveAt(stockList.SelectedIndex);
            stockList.Items.RemoveAt(stockList.SelectedIndex);

        }
    }
}