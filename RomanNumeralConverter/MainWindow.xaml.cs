using System.Windows;

namespace RomanNumeralConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   
        //array to store the Roman numbers.
        string[] roman = { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X" };
        public MainWindow()
        {
            InitializeComponent();
            //focus to input field
            numberInput.Focus();
        }
        //function to convert number to Roman numeral
        private void To_Roman_clicked(object sender, RoutedEventArgs e)
        {
            //user input
            string myNum = numberInput.Text;
            //trying to parse input as an integer
            if (int.TryParse(myNum, out int formattedNumber))
            {
                if (formattedNumber >= 1 && formattedNumber <= roman.Length)
                {
                    //output result. eg: 1 -> I
                    convertedResult.Text = $"{formattedNumber}  ->  {roman[formattedNumber - 1]}";
                    numberInput.Focus();
                }
                else
                {
                    convertedResult.Text = "Enter a number from 1 to 10 only";
                    numberInput.Focus();

                }
            }
            else
            {
                if (myNum == "")
                {
                    convertedResult.Text = "Please input a number";
                    numberInput.Focus();
                }
                else
                {
                    convertedResult.Text = $"'{myNum}' is an invalid input";
                    numberInput.Focus();
                }
            }
        }
    }
}
