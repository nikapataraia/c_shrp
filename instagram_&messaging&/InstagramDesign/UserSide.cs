using Newtonsoft.Json;
using PCL.Abstraction.Models;
using PCL.Implementation.Models;
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
using PCL.Implementation;
using PCL.Implementation.Services;
using PCL.Abstraction.Services;

namespace InstagramDesign
{
    public partial class UserSide : Form
    {
        private Account CurrentAccount;
        private Account RealCurrentAccount;
        private IInstagramService instagram;
        private string PathToCurrentAccount = Directory.GetCurrentDirectory().Replace(@"\InstagramDesign\bin\Debug", @"\InstagramDesign\CurrentAccount.Json");
        public UserSide()
        {
            InitializeComponent();
            string _gender;
            instagram = DIContainer.GetInstagramService();
            string account;
            using (StreamReader sr = new StreamReader(PathToCurrentAccount, System.Text.Encoding.Default))
            {
                account = sr.ReadToEnd();
            }
            CurrentAccount = JsonConvert.DeserializeObject<Account>(account);
            RealCurrentAccount = instagram.SearchAccount(CurrentAccount.UserName);
            label1.Text = $"Welcome back to Instagram {RealCurrentAccount.UserName}!";
            using (StreamWriter sw = new StreamWriter(PathToCurrentAccount, false, System.Text.Encoding.Default))
            {
                sw.WriteLine("");
            }
            ProfilePicture.ImageLocation = RealCurrentAccount.ProfilePictureUrl;
            List<int> LikeList = RealCurrentAccount.posts.Select(o => o.Likes).ToList();
            int likes = LikeList.Take(LikeList.Count).Sum();
            LikesLabel.Text = $"Likes: {likes}";
            UsernameLabel.Text = $"Username: {RealCurrentAccount.UserName}";
            FullNameLabel.Text = $"Full Name: {RealCurrentAccount.person.FullName}";
            AgeLabel.Text = $"Age: {RealCurrentAccount.person.Age}";
            _gender = RealCurrentAccount.person.Gender == GenderType.Male ? "Male" : "Female";
            GenderLabel.Text = $"Gender: {_gender}";
            UpdateDataGridViewFollowers();
            UpdateDataGridViewFollowing();
            UpdateFollowersLabel();
            UpdateFollowingLabel();
        }
        private void UpdateFollowersLabel()
        {
            FollowersLabel.Text = "Followers: " + RealCurrentAccount.Followers.Count;
        }
        private void UpdateFollowingLabel()
        {
            FollowingLabel.Text = "Following: " + RealCurrentAccount.Following.Count;
        }
        private void UpdateDataGridViewFollowers()
        {
            dataGridViewFollowers.DataSource = null;
            dataGridViewFollowers.DataSource = RealCurrentAccount.Followers;
        }
        private void UpdateDataGridViewFollowing()
        {
            dataGridViewFollowing.DataSource = null;
            dataGridViewFollowing.DataSource = RealCurrentAccount.Following;
        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Form1 OpenForm = new Form1();
            OpenForm.Show();
            Visible = false;
        }

        private void FollowButton_Click(object sender, EventArgs e)
        {
            if (!FollowUserName.Text.IsNothing() && FollowUserName.Text != "UserName" && FollowUserName.Text != RealCurrentAccount.UserName)
            {
                RealCurrentAccount.FollowAccount(FollowUserName.Text);
                UpdateDataGridViewFollowing();
                UpdateFollowingLabel();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(PathToCurrentAccount, false, System.Text.Encoding.Default))
            {
                sw.WriteLine("");
                sw.WriteLine(JsonConvert.SerializeObject(RealCurrentAccount));
            }
            Direct_Messages OpenForm = new Direct_Messages();
            OpenForm.Show();
            Visible = false;
        }

        private void AccountSettingsButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(PathToCurrentAccount, false, System.Text.Encoding.Default))
            {
                sw.WriteLine("");
                sw.WriteLine(JsonConvert.SerializeObject(RealCurrentAccount));
            }
            Account_Settings OpenForm = new Account_Settings();
            OpenForm.Show();
            Visible = false;
        }

        private void UnFollowButton_Click(object sender, EventArgs e)
        {
            if (!UnfollowUserName.Text.IsNothing() && UnfollowUserName.Text != "UserName")
                RealCurrentAccount.UnFollowAccount(UnfollowUserName.Text);
            UpdateDataGridViewFollowing();
            UpdateFollowingLabel();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(PathToCurrentAccount, false, System.Text.Encoding.Default))
            {
                sw.WriteLine("");
                sw.WriteLine(JsonConvert.SerializeObject(RealCurrentAccount));
            }
            UploadImage OpenForm = new UploadImage();
            OpenForm.Show();
            Visible = false;
        }
    }
}
