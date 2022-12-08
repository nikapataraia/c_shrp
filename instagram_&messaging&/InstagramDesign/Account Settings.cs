using Newtonsoft.Json;
using PCL.Implementation;
using PCL.Implementation.Models;
using PCL.Implementation.Services;
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
using PCL.Exstensions;
using PCL.Abstraction.Models;

namespace InstagramDesign
{
    public partial class Account_Settings : Form
    {
        private Account CurrentAccount;
        private Account RealCurrentAccount;
        private InstagramService instagram;
        private string PathToCurrentAccount = Directory.GetCurrentDirectory().Replace(@"\InstagramDesign\bin\Debug", @"\InstagramDesign\CurrentAccount.Json");
        public Account_Settings()
        {
            InitializeComponent();
            instagram = DIContainer.GetInstagramService();
            string account;
            using (StreamReader sr = new StreamReader(PathToCurrentAccount, System.Text.Encoding.Default))
            {
                account = sr.ReadToEnd();
            }
            CurrentAccount = JsonConvert.DeserializeObject<Account>(account);
            RealCurrentAccount = instagram.SearchAccount(CurrentAccount.UserName);
            using (StreamWriter sw = new StreamWriter(PathToCurrentAccount, false, System.Text.Encoding.Default))
            {
                sw.WriteLine("");
            }
            OldPassword.PasswordChar = '*';
            NewPassword.PasswordChar = '*';
            NewPassword.MaxLength = 16;
        }

        private void Account_Settings_Load(object sender, EventArgs e)
        {

        }

        private void UpdateUserName_Click(object sender, EventArgs e)
        {
            string OldUsername;
            List<Post> AllPosts;
            List<Post> UploaderPosts;
            if (!NewUserName.Text.IsNothing() && NewUserName.Text != "New UserName")
            {
                OldUsername = RealCurrentAccount.UserName;
                foreach (var i in RealCurrentAccount.Followers)
                {
                    List<FollowClass> Followers = instagram.SearchAccount(i.Username).Following.Where(o => o.Username == RealCurrentAccount.UserName).ToList();
                    foreach (var item in Followers)
                    {
                        item.Username = NewUserName.Text;
                    }
                }
                foreach (var i in RealCurrentAccount.Following)
                {
                    List<FollowClass> Following = instagram.SearchAccount(i.Username).Followers.Where(o => o.Username == RealCurrentAccount.UserName).ToList();
                    foreach (var item in Following)
                    {
                        item.Username = NewUserName.Text;
                    }
                }
                foreach (var o in RealCurrentAccount.SentMessages)
                {
                    o.Sender = NewUserName.Text;
                }
                foreach (var o in RealCurrentAccount.RecievedMessages)
                {
                    o.Reciever = NewUserName.Text;
                }
                RealCurrentAccount.UserName = NewUserName.Text;
                StatusLabel.Text = "Username Successfully Updated :)";
                instagram.UpdateDataBase();
                foreach (var item in RealCurrentAccount.posts)
                {
                    item.UploaderUserName = RealCurrentAccount.UserName;
                }
                AllPosts = instagram.GetAllPosts();
                UploaderPosts = AllPosts.Where(o => o.UploaderUserName == OldUsername).ToList();
                UploaderPosts.ForEach(o => o.UploaderUserName = RealCurrentAccount.UserName);
                instagram.UpdateAllPosts(AllPosts);
            }
            else
            {
                StatusLabel.Text = "Please try again";
            }
        }

        private void UpdateFullName_Click(object sender, EventArgs e)
        {
            if(!NewFullName.Text.IsNothing() && NewFullName.Text != "New Full Name")
            {
                RealCurrentAccount.person.FullName = NewFullName.Text;
                StatusLabel.Text = "Full Name Successfully Updated :)";
                instagram.UpdateDataBase();
            }
            else
            {
                StatusLabel.Text = "Please try again";
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(PathToCurrentAccount, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(JsonConvert.SerializeObject(RealCurrentAccount));
            }
            UserSide OpenForm = new UserSide();
            OpenForm.Show();
            Visible = false;
        }

        private void UpdateNumber_Click(object sender, EventArgs e)
        {
            if (!NewNumber.Text.IsNothing() && NewNumber.Text != "New Mobile Number")
            {
                RealCurrentAccount.person.MobileNumber = NewNumber.Text;
                StatusLabel.Text = "Mobile Number Successfully Updated :)";
                instagram.UpdateDataBase();
            }
            else
            {
                StatusLabel.Text = "Please try again";
            }
        }

        private void NewAge_TextChanged(object sender, EventArgs e)
        {
            if (!NewAge.Text.IsNothing() && NewAge.Text != "New Age")
            {
                RealCurrentAccount.person.Age = Convert.ToInt16(NewAge.Text);
                StatusLabel.Text = "Age Successfully Updated :)";
                instagram.UpdateDataBase();
            }
            else
            {
                StatusLabel.Text = "Please try again";
            }
        }

        private void UpdateGender_Click(object sender, EventArgs e)
        {
            if (!NewGender.Text.IsNothing() && (NewGender.Text == "Male" || NewGender.Text == "Female"))
            {
                GenderType _Gender = NewGender.Text == "Male" ? GenderType.Male : GenderType.Female;
                RealCurrentAccount.person.Gender = _Gender;
                StatusLabel.Text = "Gender Successfully Updated :)";
                instagram.UpdateDataBase();
            }
            else
            {
                StatusLabel.Text = "Please try again";
            }
        }
        int Counter = 0;
        private void Button1_Click(object sender, EventArgs e)
        {
            if (!OldPassword.Text.IsNothing() && !NewPassword.Text.IsNothing())
            {
                if (OldPassword.Text != RealCurrentAccount.Password)
                {
                    if (Counter < 3)
                    {
                        Counter++;
                        StatusLabel.Text = $"Please try again, {4-Counter} tries left";
                    }
                    else
                    {
                        Counter = 0;
                        Form1 OpenForm = new Form1();
                        OpenForm.Show();
                        Visible = false;
                    }
                }
                else
                {
                    RealCurrentAccount.Password = NewPassword.Text;
                    StatusLabel.Text = "Password Successfully Updated :)";
                    instagram.UpdateDataBase();
                }
            }
        }

        private void UpdatePicture_Click(object sender, EventArgs e)
        {
            List<Post> AllPosts;
            List<Post> UploaderPosts;
            if (!NewPicture.Text.IsNothing() && NewPicture.Text != "Profile Picture Url" && NewPicture.Text.Contains("/") && NewPicture.Text.Contains("."))
            {
                RealCurrentAccount.ProfilePictureUrl = NewPicture.Text;
                StatusLabel.Text = "Successfully updated profile picture :)";
                instagram.UpdateDataBase();
                foreach (var item in RealCurrentAccount.posts)
                {
                    item.ProfilePictureURL = NewPicture.Text;
                }
                AllPosts = instagram.GetAllPosts();
                UploaderPosts = AllPosts.Where(o => o.UploaderUserName == RealCurrentAccount.UserName).ToList();
                UploaderPosts.ForEach(o => o.ProfilePictureURL = RealCurrentAccount.ProfilePictureUrl);
                instagram.UpdateAllPosts(AllPosts);
            }
            else
            {
                StatusLabel.Text = "Please try again";
            }
        }

        private void TerminateAccount_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(PathToCurrentAccount, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(JsonConvert.SerializeObject(RealCurrentAccount));
            }
            Terminate OpenForm = new Terminate();
            OpenForm.Show();
            Visible = false;
        }
    }
}
