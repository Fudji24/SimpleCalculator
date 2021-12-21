using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static readonly Regex _numReg = new Regex("[^0-9.-]+");
        double x, y, result;
        char operation;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void number_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            operationsTxtBox.AppendText(btn.Content.ToString());
        }
        

        private void equal_Click(object sender, RoutedEventArgs e)
        {
            if (IsTextAllowed(operationsTxtBox.Text))
            {
                if (operationsTxtBox.Text != null)
                {
                    y = Convert.ToDouble(operationsTxtBox.Text);
                }
                
            }
            
            operationsTxtBox.Text = "";
            switch (operation)
            {
                case '+':
                    result = x + y;
                    operationsTxtBox.Text = result.ToString();
                    secondNum.Text = y.ToString();
                    break;
                case '-':
                    result = x - y;
                    operationsTxtBox.Text = result.ToString();
                    secondNum.Text = y.ToString();
                    break;
                case '*':
                    result = x * y;
                    operationsTxtBox.Text = result.ToString();
                    secondNum.Text = y.ToString();
                    break;
                case '/':
                    result = x / y;
                    operationsTxtBox.Text = result.ToString();
                    secondNum.Text = y.ToString();
                    break;
                case '%':
                    result = x * y / 100;
                    operationsTxtBox.Text = result.ToString();
                    secondNum.Text = y.ToString();
                    break;
               

                default:
                    break;
            }
           
        }

        private void sumBtn_Click(object sender, RoutedEventArgs e)
        {
            if (IsTextAllowed(operationsTxtBox.Text))
            {
                x = Convert.ToDouble(operationsTxtBox.Text);
                operationsTxtBox.Text = "";
                operation = '+';
                firstNum.Text = x.ToString();
                secondNum.Text = "";
                operatorBox.Text = operation.ToString();
            }
            else
            {
                operationsTxtBox.Text = "";
            }
        }
        private void subBtn_Click(object sender, RoutedEventArgs e)
        {
           

            if (IsTextAllowed(operationsTxtBox.Text))
            {
                x = Convert.ToDouble(operationsTxtBox.Text);
                operationsTxtBox.Text = "";
                operation = '-';
                secondNum.Text = "";
                firstNum.Text = x.ToString();
                operatorBox.Text = operation.ToString();
            }
            else
            {
                operationsTxtBox.Text = "";
            }
            
            
        }


        private void multBtn_Click(object sender, RoutedEventArgs e)
        {
            if (IsTextAllowed(operationsTxtBox.Text))
            {
                x = Convert.ToDouble(operationsTxtBox.Text);
                operationsTxtBox.Text = "";
                operation = '*';
                secondNum.Text = "";
                firstNum.Text = x.ToString();
                operatorBox.Text = operation.ToString();
            }
            else
            {
                operationsTxtBox.Text = "";
            }
        }
        private void divBtn_Click(object sender, RoutedEventArgs e)
        {
            if (IsTextAllowed(operationsTxtBox.Text))
            {
                x = Convert.ToDouble(operationsTxtBox.Text);
                operationsTxtBox.Text = "";
                operation = '/';
                secondNum.Text = "";
                firstNum.Text = x.ToString();
                operatorBox.Text = operation.ToString();
            }
            else
            {
                operationsTxtBox.Text = "";
            }
        }

        private void clearBtn_Click(object sender, RoutedEventArgs e)
        {
            operationsTxtBox.Text = "";
            y = 0;
            x = 0;
        }

        private void rootBtn_Click(object sender, RoutedEventArgs e)
        {
            if (operationsTxtBox.Text != null)
            {
                x = Convert.ToDouble(operationsTxtBox.Text);
                result = Math.Sqrt(x);
                operationsTxtBox.Text = result.ToString();

                firstNum.Text = "√" + x.ToString();
            }
            

        }

        private void squareBtn_Click(object sender, RoutedEventArgs e)
        {
            if (IsTextAllowed(operationsTxtBox.Text))
            {
                if (operationsTxtBox.Text != null)
                {
                    x = Convert.ToDouble(operationsTxtBox.Text);
                    result = x * x;
                    operationsTxtBox.Text = result.ToString();

                    firstNum.Text = x.ToString() + "2";
                }
                
            }
            else
            {
                operationsTxtBox.Text = "";
            }

        }

        private void proBtn_Click(object sender, RoutedEventArgs e)
        {
            if (IsTextAllowed(operationsTxtBox.Text))
            {
                x = Convert.ToDouble(operationsTxtBox.Text);
                operationsTxtBox.Text = "";
                operation = '%';
                secondNum.Text = "";
                firstNum.Text = x.ToString();
                operatorBox.Text = operation.ToString();
            }
            else
            {
                operationsTxtBox.Text = "";
            }
        }

        private static bool IsTextAllowed(string text)
        {
            return !_numReg.IsMatch(text);
        }
    }
}
