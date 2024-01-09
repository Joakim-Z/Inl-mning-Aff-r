using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inlämning_Affär
{
    public partial class LogInScreen : Form
    {
        List<Account> accounts = new List<Account>();
        
        public LogInScreen()
        {
            InitializeComponent();
            
            
            errorMassageLabel.Hide();

        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            LoadAccounts();
            string username = loginUsername.Text;
            string password = loginPassword.Text;

            foreach (Account account in accounts)
            {
                if (username == account.Username && password == account.Password)
                {
                    account.Password = password;
                    account.Username = username;

                    
                    
                }
                else
                {
                    errorMassageLabel.Show();
                }
            }
            StoreScreen storeScreen = new StoreScreen();
            storeScreen.Show();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterScreen registerScreen = new RegisterScreen();
            registerScreen.SetAccountList(accounts);
            registerScreen.Show();
        }

        string folderPath = "accountFolder";
        string path = "accountFolder/Accounts.csv";
        string absolutePath = "C:\\Users\\Joaki\\source\\repos\\Inlämning Affär\\Inlämning Affär";

        

        private void LoadAccounts()
        {
            FileInfo file = new FileInfo(path);
            if (file.Exists)
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    sr.ReadLine();
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        string[] strings = line.Split(",");

                        string username = strings[0];
                        string password = strings[1];

                        Account newAcc = new Account(username, password);
                        accounts.Add(newAcc);

                        line = sr.ReadLine();
                    }
                }
            }
        }
    }
}
