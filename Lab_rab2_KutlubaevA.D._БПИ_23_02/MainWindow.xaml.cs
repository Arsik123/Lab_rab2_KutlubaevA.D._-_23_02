using System;
using System.Windows;
using System.Windows.Controls;

namespace Lab_rab2_KutlubaevA.D._БПИ_23_02
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calc_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Radio1.IsChecked.GetValueOrDefault())
                {
                    double a = Convert.ToDouble(R1TextA.Text);
                    double f = Convert.ToDouble(((ComboBoxItem)R1ComboF.SelectedItem).Content.ToString());
                    double result = Math.Sin(f * a);
                    this.Title = "Ответ: " + result.ToString("F2");
                }
                else if (Radio2.IsChecked.GetValueOrDefault())
                {
                    double a = Convert.ToDouble(R2TextA.Text);
                    double b = Convert.ToDouble(R2TextB.Text);
                    double f = Convert.ToDouble(((ComboBoxItem)R2ComboF.SelectedItem).Content.ToString());
                    double result = Math.Cos(f * a) + Math.Sin(f * b);
                    this.Title = "Ответ: " + result.ToString("F2");
                }
                else if (Radio3.IsChecked.GetValueOrDefault())
                {
                    double a = Convert.ToDouble(R3TextA.Text);
                    double b = Convert.ToDouble(R3TextB.Text);
                    double c = Convert.ToDouble(((ComboBoxItem)R3ComboC.SelectedItem).Content.ToString());
                    double d = Convert.ToDouble(((ComboBoxItem)R3ComboD.SelectedItem).Content.ToString());
                    double result = c * Math.Pow(a, 2) + d * Math.Pow(b, 2);
                    this.Title = "Ответ: " + result.ToString("F2");
                }
                else if (Radio4.IsChecked.GetValueOrDefault())
                {
                    double a = Convert.ToDouble(R4TextA.Text);
                    int d = Convert.ToInt32(R4TextD.Text);
                    double c = Convert.ToDouble(((ComboBoxItem)R4ComboC.SelectedItem).Content.ToString());

                    double sum = 0;
                    for (int i = 0; i <= d; i++)
                    {
                        sum += Math.Pow(c + a, i);
                    }
                    this.Title = "Ответ: " + sum.ToString("F2");
                }
                else if (Radio5.IsChecked.GetValueOrDefault())
                {
                    int N = Convert.ToInt32(R5TextN.Text);
                    int K = Convert.ToInt32(R5TextK.Text);
                    double x = Convert.ToDouble(R5TextX.Text);
                    double f = Convert.ToDouble(R5TextF.Text);
                    double y = Convert.ToDouble(R5TextY.Text);

                    double Z = 0; 

                    for (int i = 1; i <= N; i++)
                    {
                        for (int j = 1; j <= K; j++)
                        {
                            double numerator = Math.Sin(x) * Math.Pow(x, i) + Math.Pow(f, j) * Math.Pow(y, j);
                            double denominator = i * j;
                            Z += numerator / denominator;
                        }
                    }

                    this.Title = "Ответ: " + Z.ToString("F2");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка! Проверьте правильность введенных данных. Используйте запятую для дробных чисел.", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
                this.Title = "Ответ: Ошибка!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла непредвиденная ошибка: " + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                this.Title = "Ответ: Ошибка!";
            }
        }
    }
}