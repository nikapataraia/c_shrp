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
using PCL.Abstraction.Services;

namespace InstagramDesign
{
    public partial class UploadImage : Form
    {
        public string Locationer;
        private Account CurrentAccount;
        private Account RealCurrentAccount;
        private IInstagramService instagram;
        private string PathToCurrentAccount = Directory.GetCurrentDirectory().Replace(@"\InstagramDesign\bin\Debug", @"\InstagramDesign\CurrentAccount.Json");
        private string PathToCurrentPost = Directory.GetCurrentDirectory().Replace(@"\InstagramDesign\bin\Debug", @"\InstagramDesign\CurrentPost.Json");
        public List<Post> PostsList;
        private Random rand;
        private int FirstIndex;
        private int SecondIndex;
        private Post FirstPost;
        private Post SecondPost;
        public UploadImage()
        {
            InitializeComponent();
            UploadText.MaxLength = 25;
            rand = new Random();
            instagram = DIContainer.GetInstagramService();
            string account;
            using (StreamReader sr = new StreamReader(PathToCurrentAccount, System.Text.Encoding.Default))
            {
                account = sr.ReadToEnd();
            }
            CurrentAccount = JsonConvert.DeserializeObject<Account>(account);
            RealCurrentAccount = instagram.SearchAccount(CurrentAccount.UserName);
            PostsList = instagram.GetAllPosts();
            if (PostsList.Count < 2)
            {
                PostsList.Add(new Post() { UploaderUserName = "Instagram", ImageURL = "https://piximus.net/media2/56804/facebook-instagram-shutdown-memes-9.jpg", Time = DateTime.Now, Text = "That True Tho :D", ProfilePictureURL = "http://pluspng.com/img-png/instagram-png-instagram-png-logo-1455.png" });
                PostsList.Add(new Post() { UploaderUserName = "Instagram", ImageURL = "https://webcdn-adespressoinc.netdna-ssl.com/wp-content/uploads/2019/01/top-ig-updates-jan-2019-2.jpg", Time = DateTime.Now, Text = "Check this video out!", ProfilePictureURL = "http://pluspng.com/img-png/instagram-png-instagram-png-logo-1455.png" });
            }
            FirstIndex = rand.Next(0, PostsList.Count);
            SecondIndex = rand.Next(0, PostsList.Count);
            if (SecondIndex == FirstIndex && SecondIndex != 0)
            {
                SecondIndex--;
            }
            else if (SecondIndex == FirstIndex && SecondIndex != PostsList.Count-1)
            {
                SecondIndex++;
            }
            FirstPost = PostsList.ElementAt(FirstIndex);
            SecondPost = PostsList.ElementAt(SecondIndex);
            UserName1.Text = FirstPost.UploaderUserName;
            UserNamePicture1.ImageLocation = FirstPost.ProfilePictureURL;
            Text1.Text = FirstPost.Text;
            Imager1.ImageLocation = FirstPost.ImageURL;
            Locationer = FirstPost.ImageURL;
            UserName2.Text = SecondPost.UploaderUserName;
            UserNamePicture2.ImageLocation = SecondPost.ProfilePictureURL;
            Text2.Text = SecondPost.Text;
            Imager2.ImageLocation = SecondPost.ImageURL;
            time1.Text = FirstPost.Time.ToString();
            time2.Text = SecondPost.Time.ToString();
            instagram.UpdateAllPosts(PostsList);
        }
        private void UploadButton_Click(object sender, EventArgs e)
        {
            if (!UploadText.Text.IsNothing() && UploadText.Text != "Text" && !UploadImageUrl.Text.IsNothing() && UploadImageUrl.Text != "ImageUrl" && UploadImageUrl.Text.Contains(".") && UploadImageUrl.Text.Contains("/"))
            {
                RealCurrentAccount.PostPicture(UploadText.Text, UploadImageUrl.Text);
                StatusLabel.Text = "Successfully Uploaded :)";
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

        private void Like1Button_Click(object sender, EventArgs e)
        {
            Post CurrentPostFromPostList;
            string location;
            location = Imager1.ImageLocation;
            CurrentPostFromPostList = PostsList.FirstOrDefault(o => o.ImageURL == location);
            if (RealCurrentAccount.LikedPosts.FirstOrDefault(o => o.ImageURL == location) == null)
            {
                CurrentPostFromPostList.Likes++;
                if (CurrentPostFromPostList.UploaderUserName != "Instagram")
                {
                    instagram.SearchAccount(CurrentPostFromPostList.UploaderUserName).posts.FirstOrDefault(o => o.ImageURL == location).Likes++;
                }
                instagram.UpdateAllPosts(PostsList);
                LikeLabel.Text = $"Liked image from {CurrentPostFromPostList.UploaderUserName}";
                RealCurrentAccount.LikedPosts.Add(CurrentPostFromPostList);
                instagram.UpdateDataBase();
            }
            else
            {
                LikeLabel.Text = "This post is already liked by you.";
            }
        }

        private void Unlike1Button_Click(object sender, EventArgs e)
        {
            Post CurrentPostFromPostList;
            string location;
            location = Imager1.ImageLocation;
            CurrentPostFromPostList = PostsList.FirstOrDefault(o => o.ImageURL == location);
            if (RealCurrentAccount.LikedPosts.FirstOrDefault(o => o.ImageURL == location) != null)
            {
                CurrentPostFromPostList.Likes--;
                if (CurrentPostFromPostList.UploaderUserName != "Instagram")
                {
                    instagram.SearchAccount(CurrentPostFromPostList.UploaderUserName).posts.FirstOrDefault(o => o.ImageURL == location).Likes--;
                }
                instagram.UpdateAllPosts(PostsList);
                LikeLabel.Text = $"Unliked image from {CurrentPostFromPostList.UploaderUserName}";
                RealCurrentAccount.LikedPosts.Remove(RealCurrentAccount.LikedPosts.FirstOrDefault(o => o.ImageURL == CurrentPostFromPostList.ImageURL));
                instagram.UpdateDataBase();
            }
            else
            {
                LikeLabel.Text = "You can't unlike a post that you don't even have liked.";
            }
        }

        private void Like2Button_Click(object sender, EventArgs e)
        {
            Post CurrentPostFromPostList;
            string location;
            location = Imager2.ImageLocation;
            CurrentPostFromPostList = PostsList.FirstOrDefault(o => o.ImageURL == location);
            if (RealCurrentAccount.LikedPosts.FirstOrDefault(o => o.ImageURL == location) == null)
            {
                CurrentPostFromPostList.Likes++;
                if (CurrentPostFromPostList.UploaderUserName != "Instagram")
                {
                    instagram.SearchAccount(CurrentPostFromPostList.UploaderUserName).posts.FirstOrDefault(o => o.ImageURL == location).Likes++;
                }
                instagram.UpdateDataBase();
                instagram.UpdateAllPosts(PostsList);
                LikeLabel.Text = $"Liked image from {CurrentPostFromPostList.UploaderUserName}";
                RealCurrentAccount.LikedPosts.Add(CurrentPostFromPostList);
                instagram.UpdateDataBase();
            }
            else
            {
                LikeLabel.Text = "This post is already liked by you.";
            }
        }
        private void Unlike2Button_Click_1(object sender, EventArgs e)
        {
            Post CurrentPostFromPostList;
            string location;
            location = Imager2.ImageLocation;
            CurrentPostFromPostList = PostsList.FirstOrDefault(o => o.ImageURL == location);
            if (RealCurrentAccount.LikedPosts.FirstOrDefault(o => o.ImageURL == location) != null)
            {
                CurrentPostFromPostList.Likes--;
                if (CurrentPostFromPostList.UploaderUserName != "Instagram")
                {
                    instagram.SearchAccount(CurrentPostFromPostList.UploaderUserName).posts.FirstOrDefault(o => o.ImageURL == location).Likes--;
                }
                instagram.UpdateDataBase();
                instagram.UpdateAllPosts(PostsList);
                LikeLabel.Text = $"Unliked image from {CurrentPostFromPostList.UploaderUserName}";
                RealCurrentAccount.LikedPosts.Remove(RealCurrentAccount.LikedPosts.FirstOrDefault(o => o.ImageURL == CurrentPostFromPostList.ImageURL));
                instagram.UpdateDataBase();
            }
            else
            {
                LikeLabel.Text = "You can't unlike a post that you don't even have liked.";
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            FirstIndex = rand.Next(0, PostsList.Count);
            SecondIndex = rand.Next(0, PostsList.Count);
            if (SecondIndex == FirstIndex && SecondIndex != 0)
            {
                SecondIndex--;
            }
            else if (SecondIndex == FirstIndex && SecondIndex != PostsList.Count - 1)
            {
                SecondIndex++;
            }
            FirstPost = PostsList.ElementAt(FirstIndex);
            SecondPost = PostsList.ElementAt(SecondIndex);
            UserName1.Text = FirstPost.UploaderUserName;
            if (FirstPost.ProfilePictureURL == null)
                FirstPost.ProfilePictureURL = "";
            UserNamePicture1.ImageLocation = FirstPost.ProfilePictureURL;
            Text1.Text = FirstPost.Text;
            Imager1.ImageLocation = FirstPost.ImageURL;
            Locationer = FirstPost.ImageURL;
            UserName2.Text = SecondPost.UploaderUserName;
            if (SecondPost.ProfilePictureURL == null)
                SecondPost.ProfilePictureURL = "";
            UserNamePicture2.ImageLocation = SecondPost.ProfilePictureURL;
            Text2.Text = SecondPost.Text;
            Imager2.ImageLocation = SecondPost.ImageURL;
        }

        private void Comments1_Click(object sender, EventArgs e)
        {
            string location;
            location = Imager1.ImageLocation;
            using (StreamWriter sw = new StreamWriter(PathToCurrentPost, false, System.Text.Encoding.Default))
            {
                string SerializedObject = JsonConvert.SerializeObject(PostsList.FirstOrDefault(o => o.ImageURL == location));
                sw.WriteLine(SerializedObject);
            }
            using (StreamWriter sw = new StreamWriter(PathToCurrentAccount, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(JsonConvert.SerializeObject(RealCurrentAccount));
            }
            Comments OpenForm = new Comments();
            OpenForm.Show();
            Visible = false;
        }

        private void Comments2_Click(object sender, EventArgs e)
        {
            string location;
            location = Imager2.ImageLocation;
            using (StreamWriter sw = new StreamWriter(PathToCurrentPost, false, System.Text.Encoding.Default))
            {
                string SerializedObject = JsonConvert.SerializeObject(PostsList.FirstOrDefault(o => o.ImageURL == location));
                sw.WriteLine(SerializedObject);
            }
            using (StreamWriter sw = new StreamWriter(PathToCurrentAccount, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(JsonConvert.SerializeObject(RealCurrentAccount));
            }
            Comments OpenForm = new Comments();
            OpenForm.Show();
            Visible = false;
        }
    }
}
