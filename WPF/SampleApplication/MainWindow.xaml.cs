﻿using System;
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

namespace SampleApplication {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    /// 
    public partial class MainWindow : Window {
        public MainWindow()
        {
            InitializeComponent();
            seasonComboBox.SelectedIndex = setSeasonIndex(DateTime.Now.Month);
        }

        private int setSeasonIndex(int month) {
            switch (month)
            {
                case 3:
                case 4:
                case 5:
                    return 0;

                case 6:
                case 7:
                case 8:
                    return 1;

                case 9:
                case 10:
                case 11:
                    return 2;
                case 12:
                case 1:
                case 2:
                    return 3;
                default:
                    return 0;
            }

        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            checkBoxtextBlock.Text ="チェック済み";
        }

        private void checkBox_Unchecked(object sender, RoutedEventArgs e)
        {
            checkBoxtextBlock.Text ="未チェック";
        }

        private void redRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            colorTextBox.Text ="赤";
        }

        private void yellowRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            colorTextBox.Text ="黄";
        }

        private void blueRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            colorTextBox.Text ="青";
        }

        private void seasonComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            seasonTextBlock.Text = (string)((ComboBoxItem)seasonComboBox.SelectedItem).Content;
        }
    }
}
