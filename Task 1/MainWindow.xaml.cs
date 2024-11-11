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

namespace Lab5._1
{
    public partial class MainWindow : Window
    {
        private double[] numbers = { 1, 5, 6, 8, 13, 17 };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double c = double.Parse(Expression.Text);
                double result = c + numbers.Sum(a => c / a);
                ResultTextBlock.Text = "Result: " + result;
            }

            catch (FormatException)
            {
                MessageBox.Show("Неправильний формат. Тільки числа");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Ділення на нуль");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка" + ex.Message);
            }
        }
    }
}