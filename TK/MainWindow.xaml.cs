using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

namespace TK
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            Calc();
        }

        private void Calc()
        {
            int first;
            int second;
            int third;
            int fourth;
            int flag = 0;
            if (int.TryParse(First.Text, out first) && int.TryParse(Second.Text, out second) && int.TryParse(Third.Text, out third) && int.TryParse(Fourth.Text, out fourth))
            {
                if (first > 10 || first < 0)
                {
                    MessageBox.Show("В первом задании максимум 10 баллов");
                    flag = 1;
                    First.Text = "";
                }
                if (second > 50 || second < 0)
                {
                    MessageBox.Show("Во втором задании максимум 50 баллов");
                    flag = 1;
                    Second.Text = "";
                }
                if (third > 30 || third < 0)
                {
                    MessageBox.Show("В третьем задании максимум 30 баллов");
                    flag = 1;
                    Third.Text = "";
                }
                if (fourth > 10 || fourth < 0)
                {
                    MessageBox.Show("В четвертом задании максимум 10 баллов");
                    flag = 1;
                    Fourth.Text = "";
                }
                if (flag == 1) { CountBals.Text = ""; Estimate.Text = ""; }
                else
                {
                    int sum = first + second + third + fourth;
                    var result = calculatiing(sum);
                    string text = result.ToString();
                    string sumText = sum.ToString();
                    CountBals.Text = sumText;
                    Estimate.Text = text;
                }

            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Вы ввели букву, не заполнили поле или ввели дробное чилсло\nВведите целое чилсо");
                Estimate.Text = "";
                CountBals.Text = "";
            }
        }

        private int calculatiing(int sum) 
        {
            int estimate;
            if(sum >= 0 &&  sum <= 19) { return estimate = 2; }
            else if(sum >= 20 && sum <= 39) {  return estimate = 3; }
            else if(sum >= 40 &&  sum <= 69) { return estimate = 4; }
            else if(sum >= 70 && sum <= 100) { return estimate = 5; }
            else { return 0; }
        }

        public int Test(int First, int Second, int Third, int Fourth)
        {
            int countBalls = First + Second + Third + Fourth;
            int estimate = calculatiing(countBalls);
            

            if (estimate <= 2 || estimate >= 5)
            {
                MessageBox.Show("Оценка вышла за границы");
            }
            if (countBalls <= 0 || countBalls > 100)
            {
                MessageBox.Show("Максимальное количество баллов вышли за границы");
            }
            return estimate;

        }
    }
}
