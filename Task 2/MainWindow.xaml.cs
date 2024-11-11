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

namespace Lab5._2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Underline_Click(object sender, RoutedEventArgs e)
        {
            ToggleTextDecoration(TextDecorations.Underline);
        }

        private void Strikethrough_Click(object sender, RoutedEventArgs e)
        {
            ToggleTextDecoration(TextDecorations.Strikethrough);
        }


        private void ToggleTextDecoration(TextDecorationCollection decoration)
        {
            TextSelection selection = textBox.Selection;
            if (selection != null && !selection.IsEmpty)
            {
                object prop = selection.GetPropertyValue(Inline.TextDecorationsProperty);

                if (prop == DependencyProperty.UnsetValue || !decoration.Equals(prop as TextDecorationCollection))
                {
                    selection.ApplyPropertyValue(Inline.TextDecorationsProperty, decoration);
                }
                else
                {
                    selection.ApplyPropertyValue(Inline.TextDecorationsProperty, null);
                }
            }
        }
    }
}