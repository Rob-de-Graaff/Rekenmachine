using System;
using System.Windows;
using System.Windows.Controls;

namespace Rekenmachine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool newNumber = false;
        private string number1 = "";
        private string number2 = "";
        private string operation = "";
        //private double tempVar1 = 0;
        //private double tempVar2 = 0;

        // tempVar1 + tempvar2 zijn voor het proces eventueel efficienter te laten verlopen. vanwege
        // minder ervaring is de juiste manier niet altijd even duidelijk.

        public MainWindow()
        {
            InitializeComponent();

            button1.Click += NumberButton_Click;
            button2.Click += NumberButton_Click;
            button3.Click += NumberButton_Click;
            button4.Click += NumberButton_Click;
            button5.Click += NumberButton_Click;
            button6.Click += NumberButton_Click;
            button7.Click += NumberButton_Click;
            button8.Click += NumberButton_Click;
            button9.Click += NumberButton_Click;
            button0.Click += NumberButton_Click;
            buttonDivide.Click += OperatorButton_Click;
            buttonTimes.Click += OperatorButton_Click;
            buttonPlus.Click += OperatorButton_Click;
            buttonMinus.Click += OperatorButton_Click;
        }

        private void ButtonBackspace_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = number1.Substring(0, number1.Length - 1);
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = number2.Substring(0, number2.Length - 1);
                textDisplay.Text = number2.ToString();
            }
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            number1 = "";
            number2 = "";
            operation = "";
            textDisplay.Text = "";
            newNumber = false;
        }

        private void ButtonClearEntry_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = "";
            }
            else
            {
                number2 = "";
            }
            textDisplay.Text = "";
        }

        private void ButtonDot_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "" || newNumber)
            {
                number1 = number1 + Convert.ToString(((Button)sender).Content);
                textDisplay.Text = number1;
            }
            else
            {
                number2 = number2 + Convert.ToString(((Button)sender).Content);
                textDisplay.Text = number2;
            }
        }

        private void ButtonEquals_Click(object sender, RoutedEventArgs e)
        {
            //tempVar1 = Convert.ToDouble(number1);
            //tempVar2 = Convert.ToDouble(number2);
            switch (operation)
            {
                case "+":
                    number1 = (Convert.ToDouble(number1) + Convert.ToDouble(number2)).ToString();
                    //number1 = (tempVar1 + tempVar2).ToString();
                    //textDisplay.Text = number1.ToString();
                    break;

                case "-":
                    number1 = (Convert.ToDouble(number1) - Convert.ToDouble(number2)).ToString();
                    //number1 = (tempVar1 - tempVar2).ToString();
                    //textDisplay.Text = number1.ToString();
                    break;

                case "*":
                    number1 = (Convert.ToDouble(number1) * Convert.ToDouble(number2)).ToString();
                    //number1 = (tempVar1 * tempVar2).ToString();
                    //textDisplay.Text = number1.ToString();
                    break;

                case "/":
                    number1 = (Convert.ToDouble(number1) / Convert.ToDouble(number2)).ToString();
                    //number1 = (tempVar1 / tempVar2).ToString();
                    //textDisplay.Text = number1.ToString();
                    break;

                default:
                    break;
            }
            textDisplay.Text = number1.ToString();
            number2 = "";
            newNumber = true;
            operation = "";
        }

        private void ButtonPercentage_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "" || newNumber)
            {
                //tempVar1 = Convert.ToDouble(number1);

                number1 = (Convert.ToDouble(number1) / 100).ToString();
                //number1 = (tempVar1 / 100).ToString();
                textDisplay.Text = number1.ToString();
            }
        }

        private void ButtonPositiveNegative_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                //tempVar1 = Convert.ToDouble(number1);

                number1 = (Convert.ToDouble(number1) * -1).ToString();
                //number1 = (tempVar1 * -1).ToString();
                textDisplay.Text = number1.ToString();
            }
            else
            {
                //tempVar2 = Convert.ToDouble(number2);

                number2 = (Convert.ToDouble(number2) * -1).ToString();
                //number2 = (tempVar2 * -1).ToString();
                textDisplay.Text = number2.ToString();
            }
        }

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                //tempVar1 = Convert.ToDouble(number1);

                number1 = number1 + Convert.ToString(((Button)sender).Content);
                //number1 = (tempVar1 * 10 + Convert.ToInt32(((Button)sender).Content)).ToString();
                textDisplay.Text = number1.ToString();
            }
            else
            {
                //tempVar2 = Convert.ToDouble(number2);

                number2 = number2 + Convert.ToString(((Button)sender).Content);
                //number2 = (tempVar2 * 10 + Convert.ToInt32(((Button)sender).Content)).ToString();
                textDisplay.Text = number2.ToString();
            }
        }

        private void OperatorButton_Click(object sender, RoutedEventArgs e)
        {
            switch (Convert.ToString(((Button)sender).Content))
            {
                case "+":
                case "-":
                case "*":
                case "/":
                    operation = Convert.ToString(((Button)sender).Content);
                    textDisplay.Text = operation;
                    newNumber = false;
                    break;

                default:
                    break;
            }
        }
    }
}