using Dan_XLIX_Nemanja_Pilipovic.Views;
using System.IO;
using System.Windows;

namespace Dan_XLIX_Nemanja_Pilipovic
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

        private readonly string _location = @"~\..\..\..\OwnerAccess.txt";
        private string _ownerUsername;
        private string _ownerPassword;

        private void GetOwnerCredentials()
        {
            if (File.Exists(_location))
            {
                string[] allLines = File.ReadAllLines(_location);
                string[] usernameLine = allLines[0].Split(':');
                string[] passwordLine = allLines[1].Split(':');

                _ownerUsername = usernameLine[1];
                _ownerPassword = passwordLine[1];
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("File not Found");
            }
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            GetOwnerCredentials();
            if(txtUsername.Text == _ownerUsername && txtPassword.Password == _ownerPassword)
            {
                OwnerView view = new OwnerView();
                view.ShowDialog();
            }
            else
            {
                MessageBox.Show("Username or Password Not Valid");
            }
        }
    }
}
