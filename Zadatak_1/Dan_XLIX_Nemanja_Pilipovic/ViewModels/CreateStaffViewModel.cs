using Dan_XLIX_Nemanja_Pilipovic.Commands;
using Dan_XLIX_Nemanja_Pilipovic.Models;
using Dan_XLIX_Nemanja_Pilipovic.Views;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace Dan_XLIX_Nemanja_Pilipovic.ViewModels
{
    public class CreateStaffViewModel : BaseViewModel
    {
        #region Objects

        CreateStaffView main;

        #endregion

        #region Constructors

        public CreateStaffViewModel(CreateStaffView mainOpen)
        {
            main = mainOpen;
            Staff = new tblStaff();
            AllEnqaqements = GetAllEnqaqements();
        }

        #endregion

        #region Properties

        private tblStaff staff;

        public tblStaff Staff
        {
            get { return staff; }
            set 
            {
                staff = value;
                OnPropertyChanged("Staff");
            }
        }

        private string enqaqement;

        public string Enqaqement
        {
            get { return enqaqement; }
            set 
            {
                enqaqement = value;
                OnPropertyChanged("Enqaqement");
            }
        }

        private List<string> allEnqaqements;

        public List<string> AllEnqaqements
        {
            get { return allEnqaqements; }
            set 
            {
                allEnqaqements = value;
                OnPropertyChanged("AllEnqaqements");
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

        private List<string> GetAllEnqaqements()
        {
            List<string> enqaqements = new List<string>();
            enqaqements.Add("Cleaning");
            enqaqements.Add("Cooking");
            enqaqements.Add("Monitoring");
            enqaqements.Add("Reporting");

            return enqaqements;
        }

        private void SaveExecute()
        {
            try
            {
                Staff.Engagement = Enqaqement;
                using(HotelEntities db = new HotelEntities())
                {
                    db.tblStaffs.Add(Staff);
                    db.SaveChanges();
                }
                MessageBox.Show("Staff Added Successfully!");
                main.Close();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        private bool CanSaveExecute()
        {
            if (string.IsNullOrWhiteSpace(Staff.Name) || string.IsNullOrWhiteSpace(Staff.Surname) ||
                string.IsNullOrWhiteSpace(Staff.Mail) || string.IsNullOrWhiteSpace(Staff.Username) ||
                string.IsNullOrWhiteSpace(Staff.HashedPassword) || string.IsNullOrWhiteSpace(Staff.HotelLevel.ToString())
                || string.IsNullOrWhiteSpace(Staff.Gender) || string.IsNullOrWhiteSpace(Staff.Citizenship)
                || string.IsNullOrWhiteSpace(enqaqement) || Staff.DateOfBirth >= new DateTime(2002,01,01))
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
