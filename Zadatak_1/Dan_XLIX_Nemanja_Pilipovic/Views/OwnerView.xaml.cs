using Dan_XLIX_Nemanja_Pilipovic.ViewModels;
using System.Windows;

namespace Dan_XLIX_Nemanja_Pilipovic.Views
{
    /// <summary>
    /// Interaction logic for OwnerView.xaml
    /// </summary>
    public partial class OwnerView : Window
    {
        public OwnerView()
        {
            InitializeComponent();
            this.DataContext = new OwnerViewModel(this);
        }
    }
}
