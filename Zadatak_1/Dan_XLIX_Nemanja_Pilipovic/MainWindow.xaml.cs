using Dan_XLIX_Nemanja_Pilipovic.Models;
using Dan_XLIX_Nemanja_Pilipovic.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Documents;

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
        private bool _logged;

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
            if (txtUsername.Text == _ownerUsername && txtPassword.Password == _ownerPassword)
            {
                _logged = true;
                OwnerView view = new OwnerView();
                view.ShowDialog();
            }
            else
            {
                List<IUser> allusers = new List<IUser>();
                try
                {
                    using (HotelEntities db = new HotelEntities())
                    {
                        foreach (tblManager manager in db.tblManagers)
                        {
                            allusers.Add(manager as IUser);
                        }

                        foreach (tblStaff staff in db.tblStaffs)
                        {
                            allusers.Add(staff as IUser);
                        }
                    }
                    foreach (IUser user in allusers)
                    {
                        if (user.Username == txtUsername.Text && user.HashedPassword == txtPassword.Password)
                        {
                            if (user is tblManager)
                            {
                                _logged = true;
                                ManagerView view = new ManagerView();
                                view.ShowDialog();
                                break;
                            }
                            else
                            {
                                _logged = true;
                                StaffView view = new StaffView();
                                view.ShowDialog();
                                break;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                }
            }
            if (_logged == false)
            {
                MessageBox.Show("Username or Password Not Valid");
            }
        }
    }
}
