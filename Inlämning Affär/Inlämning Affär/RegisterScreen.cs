using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inlämning_Affär
{
    public partial class RegisterScreen : Form
    {
        public StoreScreen StoreScreen;
        List<Account> accounts;
        public RegisterScreen()
        {
            InitializeComponent();
            successLabel.Hide();
            errorLabel.Hide();
            

        }
        public void SetAccountList(List<Account> accountList)
        {
            this.accounts = accountList;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void regButton_Click(object sender, EventArgs e)
        {



            string username = enterUsernameTB.Text;
            string password = enterPasswordTB.Text;
            
            if (accounts.Any(Account => Account.Username == username && Account.Password == password))
            {

                errorLabel.Show();
                return;

            }
            else
            {
                Account newAcc = new Account(username, password);
                accounts.Add(newAcc);
                successLabel.Show();

                CLearTextBoxes();
            }
            StoreAccount();
        }
            

            


        string folderPath = "accountFolder";
        string path = "accountFolder/Accounts.csv";
        string absolutePath = "C:\\Users\\Joaki\\source\\repos\\Inlämning Affär\\Inlämning Affär";

        public void StoreAccount()
        {
            Directory.CreateDirectory(folderPath);
            File.Delete(path);

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("Username, Password");
                foreach (Account account in accounts)
                {
                    sw.WriteLine(account.GetCSV());
                }
            }
        }
        private void CLearTextBoxes()
        {
            enterUsernameTB.Text = "";
            enterPasswordTB.Text = "";
        }

        private void RegisterScreen_Load(object sender, EventArgs e)
        {
            
        }
    }
}
