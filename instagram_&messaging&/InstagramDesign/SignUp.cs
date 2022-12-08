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
using Newtonsoft.Json;
using PCL;
using PCL.Abstraction.Models;
using PCL.Abstraction.Services;
using PCL.Exstensions;
using PCL.Implementation;
using PCL.Implementation.Models;
using PCL.Implementation.Services;

namespace InstagramDesign
{
    public partial class SignUp : Form
    {
        private string PathToCurrentAccount = Directory.GetCurrentDirectory().Replace(@"\InstagramDesign\bin\Debug", @"\InstagramDesign\CurrentAccount.Json");
        private IInstagramService instagram;
        public SignUp()
        {
            InitializeComponent();
            UpPassword.PasswordChar = '*';
            UpPassword2.PasswordChar = '*';
            UpPassword.MaxLength = 16;
            UpUserName.MaxLength = 20;
            instagram = DIContainer.GetInstagramService();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (!UpFullName.Text.IsNothing() && UpFullName.Text != "Full Name" && !UpUserName.Text.IsNothing() && UpUserName.Text != "UserName" && !UpPassword.Text.IsNothing() && UpPassword.Text != "Password" && !UpNumber.Text.IsNothing() && UpNumber.Text != "Mobile Number" && !UpAge.Text.IsNothing() && UpAge.Text != "Age" && !UpGender.Text.IsNothing() && UpGender.Text != "Gender" && (UpGender.Text == "Male" || UpGender.Text == "Female") && DIContainer.GetInstagramService().SearchAccount(UpUserName.Text) == null && UpPassword.Text == UpPassword2.Text && UpUserName.Text != "Instagram")
            {
                GenderType gender = UpGender.Text == "Male" ? GenderType.Male : GenderType.Female;
                instagram.AddAccount(UpFullName.Text, Convert.ToInt32(UpAge.Text), gender, UpNumber.Text, UpUserName.Text, UpPassword.Text);
                using (StreamWriter sw = new StreamWriter(PathToCurrentAccount, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine("");
                    sw.WriteLine(JsonConvert.SerializeObject(new Account()
                    {
                        Password = UpPassword.Text,
                        UserName = UpUserName.Text,
                        person = new Person()
                        {
                            Age = Convert.ToInt32(UpAge.Text),
                            FullName = UpFullName.Text,
                            Gender = gender,
                            MobileNumber = UpNumber.Text
                        }
                    }));
                }
                UserSide OpenForm = new UserSide();
                OpenForm.Show();
                Visible = false;
            }
            else if (UpFullName.Text.IsNothing() || UpFullName.Text == "Full Name")
                StatusLabel.Text = "Please enter your full name";
            else if (DIContainer.GetInstagramService().SearchAccount(UpUserName.Text) != null || UpUserName.Text == "Instagram")
                StatusLabel.Text = "There is already an account with that username";
            else if (UpUserName.Text.IsNothing() || UpUserName.Text == "UserName")
                StatusLabel.Text = "Please enter your username";
            else if (UpPassword.Text.IsNothing() || UpPassword.Text == "Password")
                StatusLabel.Text = "Please enter your password";
            else if (UpPassword.Text != UpPassword2.Text)
                StatusLabel.Text = "Please enter your passwords correctly";
            else if (UpNumber.Text.IsNothing() || UpNumber.Text == "Mobile Number")
                StatusLabel.Text = "Please enter your mobile number";
            else if (UpAge.Text.IsNothing() || UpAge.Text == "Age")
                StatusLabel.Text = "Please enter your age";
            else if (UpGender.Text.IsNothing() || UpGender.Text == "Gender" || (UpGender.Text != "Male" || UpGender.Text != "Female"))
                StatusLabel.Text = "Please enter your gender";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form1 OpenForm = new Form1();
            OpenForm.Show();
            Visible = false;
        }
    }
}
