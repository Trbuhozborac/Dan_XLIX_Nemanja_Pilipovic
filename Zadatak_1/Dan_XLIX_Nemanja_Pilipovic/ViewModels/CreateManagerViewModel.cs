using Dan_XLIX_Nemanja_Pilipovic.Commands;
using Dan_XLIX_Nemanja_Pilipovic.Models;
using Dan_XLIX_Nemanja_Pilipovic.Views;
using System;
using System.Security.Policy;
using System.Windows;
using System.Windows.Input;

namespace Dan_XLIX_Nemanja_Pilipovic.ViewModels
{
    public class CreateManagerViewModel : BaseViewModel
    {
        #region Objects

        CreateManagerView main;

        #endregion

        #region Constructors

        public CreateManagerViewModel(CreateManagerView mainOpen)
        {
            main = mainOpen;
            Manager = new tblManager();
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

        private ICommand save;
        public ICommand Save
        {
            get
            {
                if (save == null)
                {
                    save = new RelayCommand(param => SaveExecute(), param => CanSaveExecute());
                }
                return save;
            }
        }

        private ICommand close;
        public ICommand Close
        {
            get
            {
                if (close == null)
                {
                    close = new RelayCommand(param => CloseExecute(), param => CanCloseExecute());
                }
                return close;
            }
        }

        #endregion

        #region Functions

        private void SaveExecute()
        {
            try
            {
                using(HotelEntities db = new HotelEntities())
                {
                    db.tblManagers.Add(Manager);
                    db.SaveChanges();
                }
                MessageBox.Show("Manager Created Successfully!");
                main.Close();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);                
            }
        }

        private bool CanSaveExecute()
        {
            if(string.IsNullOrWhiteSpace(Manager.Name) || string.IsNullOrWhiteSpace(Manager.Surname) || 
                string.IsNullOrWhiteSpace(Manager.Mail) || string.IsNullOrWhiteSpace(Manager.Username) ||
                string.IsNullOrWhiteSpace(Manager.HashedPassword) || string.IsNullOrWhiteSpace(Manager.HotelLevel.ToString()) 
                || string.IsNullOrWhiteSpace(Manager.YearsOfExperience.ToString()) 
                || string.IsNullOrWhiteSpace(Manager.QualificationLevel.ToString()))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void CloseExecute()
        {
            main.Close();
        }

        private bool CanCloseExecute()
        {
            return true;
        }

        #endregion
    }
}
