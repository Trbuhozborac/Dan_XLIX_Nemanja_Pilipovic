using Dan_XLIX_Nemanja_Pilipovic.ViewModels;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace Dan_XLIX_Nemanja_Pilipovic.Views
{
    /// <summary>
    /// Interaction logic for CreateStaffView.xaml
    /// </summary>
    public partial class CreateStaffView : Window
    {
        public CreateStaffView()
        {
            InitializeComponent();
            this.DataContext = new CreateStaffViewModel(this);
        }

        /// <summary>
        /// Validate that User input are just letters
        /// </summary>
        private void LetterValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z ]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        /// <summary>
        /// Validate that User input is just letters and digits
        /// </summary>
        private void LetterAndNumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z0-9 ]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        /// <summary>
        /// Validate that User input is just numbers
        /// </summary>
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }


        /// <summary>
        /// Validate that User input is just numbers from 1 to 7
        /// </summary>
        private void EducationLevelValidation(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^1-7]+");
            e.Handled = regex.IsMatch(e.Text);
        }


        /// <summary>
        /// Validate that User input is just numbers, letters, @ and dot (.)
        /// </summary>
        private void MailValidation(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z0-9@.]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void GenderValidation(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^MmFf]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
