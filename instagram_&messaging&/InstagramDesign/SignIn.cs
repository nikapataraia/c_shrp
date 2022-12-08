using PCL.Implementation;
using PCL.Implementation.Models;
using PCL.Implementation.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCL.Exstensions;
using System.IO;
using Newtonsoft.Json;

namespace InstagramDesign
{
    public partial class SignIn : Form
    {
        private string PathToCurrentAccount = Directory.GetCurrentDirectory().Replace(@"\InstagramDesign\bin\Debug", @"\InstagramDesign\CurrentAccount.Json");
        private InstagramService instagram;
        public SignIn()
        {
            InitializeComponent();
            instagram = DIContainer.GetInstagramService();
            InPassword.PasswordChar = '*';
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            if (!InUserName.Text.IsNothing() && InUserName.Text != "UserName" && !InPassword.Text.IsNothing() && InPassword.Text != "Password")
            {
                Account SearchedAccount = InstagramData.Instance.GetAccounts().FirstOrDefault(o => o.UserName == InUserName.Text);
                if (SearchedAccount == null || InPassword.Text != SearchedAccount.Password)
                {
                    return;
                }
                using (StreamWriter sw = new StreamWriter(PathToCurrentAccount, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine("");
                    sw.WriteLine(JsonConvert.SerializeObject(SearchedAccount));
                }
                UserSide OpenForm = new UserSide();
                OpenForm.Show();
                Visible = false;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form1 OpenForm = new Form1();
            OpenForm.Show();
            Visible = false;
        }
    }
}
