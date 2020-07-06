using System;
using System.Windows.Controls;
using System.Windows.Input;

namespace AstroCalcWPF
{
    /// <summary>
    /// Логика взаимодействия для Telescopes.xaml
    /// </summary>
    public partial class Telescopes : Page
    {
        public Telescopes()
        {
            InitializeComponent();
        }

        public int DS_Count(string s)
        {
            string substr = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0].ToString();
            int count = (s.Length - s.Replace(substr, "").Length) / substr.Length;
            return count;
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.Text, 0) || ((e.Text == System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0].ToString()) && (DS_Count(((TextBox)sender).Text) < 1)));
        }
    }
}
