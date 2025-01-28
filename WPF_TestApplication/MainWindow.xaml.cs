﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_TestApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Button_ShowName.IsEnabled = false;

            ComboBox_AccountRole.Items.Add("Teacher");
            ComboBox_AccountRole.Items.Add("Student");


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var inputName =  TextBox.Text;
            Label_FirstName.Content = inputName;    
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = TextBox.Text;
            var inputName = TextBox.Text;
            Label_FirstName.Content = inputName;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            bool acceptedRules = checkBox_AcceptRules.IsChecked.Value;
            if (acceptedRules) { Button_ShowName.IsEnabled = true; }
            else { Button_ShowName.IsEnabled = false; }

        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            bool acceptedRules = checkBox_AcceptRules.IsChecked.Value;
            if (acceptedRules) { Button_ShowName.IsEnabled = true; }
            else { Button_ShowName.IsEnabled = false; }

        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            Button_ShowName.IsEnabled = checkBox_AcceptRules.IsChecked.Value;

        }
        private void CheckBox_DoNotClick(object sender, RoutedEventArgs e)
        {
            Button_ShowName.IsEnabled = !checkBox_AcceptRules.IsChecked.Value;

        }
    }
}