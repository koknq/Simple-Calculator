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

namespace SimpleCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        float num;
        
        int count;
        

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            ClickAButton(button);

        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            ClickAButton(button);
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            ClickAButton(button);
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            ClickAButton(button);
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            ClickAButton(button);
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            ClickAButton(button);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            ClickAButton(button);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            ClickAButton(button);
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            ClickAButton(button);
        }

        private void button0_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            ClickAButton(button);
        }
        private void button7_MouseEnter(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            MouseEnterOnButton(button);
        }

        private void button7_MouseLeave(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            MouseLeaveTheButton(button);
        }

        private void button8_MouseEnter(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            MouseEnterOnButton(button);
        }

        private void button8_MouseLeave(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            MouseLeaveTheButton(button);
        }

        private void button9_MouseEnter(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            MouseEnterOnButton(button);
        }

        private void button9_MouseLeave(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            MouseLeaveTheButton(button);
        }

        private void button4_MouseEnter(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            MouseEnterOnButton(button);
        }

        private void button4_MouseLeave(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            MouseLeaveTheButton(button);
        }

        private void button5_MouseEnter(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            MouseEnterOnButton(button);
        }

        private void button5_MouseLeave(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            MouseLeaveTheButton(button);
        }

        private void button6_MouseEnter(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            MouseEnterOnButton(button);
        }

        private void button6_MouseLeave(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            MouseLeaveTheButton(button);
        }

        private void button1_MouseEnter(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            MouseEnterOnButton(button);
        }

        private void button1_MouseLeave(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            MouseLeaveTheButton(button);
        }

        private void button2_MouseEnter(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            MouseEnterOnButton(button);
        }

        private void button2_MouseLeave(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            MouseLeaveTheButton(button);
        }

        private void button3_MouseEnter(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            MouseEnterOnButton(button);
        }

        private void button3_MouseLeave(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            MouseLeaveTheButton(button);
        }

        private void button0_MouseEnter(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            MouseEnterOnButton(button);
        }

        private void button0_MouseLeave(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            MouseLeaveTheButton(button);
        }

        private void buttonC_MouseEnter(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            MouseEnterOnButton(button);
        }

        private void buttonC_MouseLeave(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            MouseLeaveTheButton(button);
        }

        private void buttonEquals_MouseEnter(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            MouseEnterOnButton(button);
        }

        private void buttonEquals_MouseLeave(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            MouseLeaveTheButton(button);
        }

        private void buttonPlus_MouseEnter(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            MouseEnterOnButton(button);
        }

        private void buttonPlus_MouseLeave(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            MouseLeaveTheButton(button);
        }

        private void buttonMinus_MouseEnter(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            MouseEnterOnButton(button);
        }

        private void buttonMinus_MouseLeave(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            MouseLeaveTheButton(button);
        }

        private void buttonMultiplication_MouseEnter(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            MouseEnterOnButton(button);
        }

        private void buttonMultiplication_MouseLeave(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            MouseLeaveTheButton(button);
        }

        private void buttonDivision_MouseEnter(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            MouseEnterOnButton(button);
        }

        private void buttonDivision_MouseLeave(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            MouseLeaveTheButton(button);
        }

        private void buttonC_Click(object sender, RoutedEventArgs e)
        {
            textBox.Clear();
            count = 0;
        }

        private void buttonEquals_Click(object sender, RoutedEventArgs e)
        {
            switch(count)
            {
                case 1:
                    num = num - float.Parse(textBox.Text);
                    textBox.Text = num.ToString();
                    break;
                case 2:
                    num = num + float.Parse(textBox.Text);
                    textBox.Text = num.ToString();
                    break;
                case 3:
                    num = num * float.Parse(textBox.Text);
                    textBox.Text = num.ToString();
                    break;
                case 4:
                    num = num / float.Parse(textBox.Text);
                    textBox.Text = num.ToString();
                    break;
                default:
                    break;
            }
        }

        private void buttonMinus_Click(object sender, RoutedEventArgs e)
        {
            Calculate();
            count = 1;
        } 

        private void buttonPlus_Click(object sender, RoutedEventArgs e)
        {
            Calculate();
            count = 2;
        }

        private void buttonMultiplication_Click(object sender, RoutedEventArgs e)
        {
            Calculate();
            count = 3;
        }

        private void buttonDivision_Click(object sender, RoutedEventArgs e)
        {
            Calculate();
            count = 4;

        }

        private void ClickAButton(Button button)
        {
            if (textBox.Text.Length < 9)
            {
                textBox.Text += button.Content;
            }
        }

        private void MouseEnterOnButton(Button button)
        {
            button.FontSize = 50;
            button.FontWeight = FontWeights.ExtraBold;
            
            
        }

        private void MouseLeaveTheButton(Button button)
        {
            button.FontSize = 25;
            button.FontWeight = FontWeights.ExtraLight;
        }

        private void Calculate()
        {
            if (textBox.Text != "")
            {
                num = float.Parse(textBox.Text);
                textBox.Clear();
                textBox.Focus();

            }
        }

        private void TakeOnlyNumbers(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

    }
}
