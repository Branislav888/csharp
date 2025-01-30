using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tic_tac_toe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public char LastPlayer {  get; set; } = '☼';

        public char PlayerOne { get; set; } = '☽';

        public char PlayerTwo { get; set; } = '☼';
        public MainWindow()
        {
            InitializeComponent();
        }
        public void ProcessClick(Button button)
        {
            var buttonContent = button.Content.ToString();
            if (buttonContent.Contains(PlayerOne) || buttonContent.Contains(PlayerTwo))
            {
                return;
            }

            if (LastPlayer == PlayerOne)
            {
                    button.Content = PlayerTwo;
                    LastPlayer = PlayerTwo;

            }

            else if (LastPlayer == PlayerTwo)
            {
                    button.Content = PlayerOne;
                    LastPlayer = PlayerOne;


            }
           var isWinner = CheckWinner();
            if (isWinner)
            {

                MessageBox.Show("Vyhral hrac:" + LastPlayer);
            }
        }
        
        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            ProcessClick (sender as Button);
        }

        public bool CheckWinner()
        {
            var button0 = Button0.Content.ToString();
            var button1 = Button1.Content.ToString();
            var button2 = Button2.Content.ToString();
            var button3 = Button3.Content.ToString();
            var button4 = Button4.Content.ToString();
            var button5 = Button5.Content.ToString();
            var button6 = Button6.Content.ToString();
            var button7 = Button7.Content.ToString();
            var button8 = Button8.Content.ToString();

            // Kontrola rpveho riadku
            if (button0 == button1 && button0 == button2)
            {
                return true;
            }
            if (button3 == button4 && button3 ==button5)
            {
                return true;
            }
            return false;
        }
    }
}