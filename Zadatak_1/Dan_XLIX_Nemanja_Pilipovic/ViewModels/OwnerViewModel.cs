using Dan_XLIX_Nemanja_Pilipovic.Commands;
using Dan_XLIX_Nemanja_Pilipovic.Models;
using Dan_XLIX_Nemanja_Pilipovic.Views;
using System.Windows.Input;

namespace Dan_XLIX_Nemanja_Pilipovic.ViewModels
{
    public class OwnerViewModel : BaseViewModel
    {
        #region Objects

        OwnerView main;

        #endregion

        #region Constructors

        public OwnerViewModel(OwnerView mainOpen)
        {
            main = mainOpen;
        }

        #endregion

        #region Properties

        private tblManager manager;

        public tblManager Manager
        {
            get { return manager; }
            set 
            {
                manager = value;
                OnPropertyChanged("Manager");
            }
        }


        #endregion

        #region Commands

        private ICommand createStaff;
        public ICommand CreateStaff
        {
            get
            {
                if (createStaff == null)
                {
                    createStaff = new RelayCommand(param => CreateStaffExecute(), param => CanCreateStaff());
                }
                return createStaff;
            }
        }

        private ICommand createManager;
        public ICommand CreateManager
        {
            get
            {
                if (createManager == null)
                {
                    createManager = new RelayCommand(param => CreateManagerExecute(), param => CanCreateManager());
                }
                return createManager;
            }
        }

        #endregion

        #region Functions

        private void CreateStaffExecute()
        {
            CreateStaffView view = new CreateStaffView();
            view.ShowDialog();
        }

        private bool CanCreateStaff()
        {
            return true;
        }

        private void CreateManagerExecute()
        {
            CreateManagerView view = new CreateManagerView();
            view.ShowDialog();
        }

        private bool CanCreateManager()
        {
            return true;
        }

        #endregion
    }
}
