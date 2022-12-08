using Newtonsoft.Json;
using PCL.Abstraction.Services;
using PCL.Implementation;
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

namespace InstagramDesign
{
    public partial class Comments : Form
    {
        private string PathToCurrentPost = Directory.GetCurrentDirectory().Replace(@"\InstagramDesign\bin\Debug", @"\InstagramDesign\CurrentPost.Json");
        private string PathToCurrentAccount = Directory.GetCurrentDirectory().Replace(@"\InstagramDesign\bin\Debug", @"\InstagramDesign\CurrentAccount.Json");
        private Post CurrentPost;
        private IInstagramService instagram;
        private Account CurrentAccount;
        private Account RealCurrentAccount;
        private Post CurrentRealPost;
        public Comments()
        {
            InitializeComponent();
            instagram = DIContainer.GetInstagramService();
            string CurrentPostString;
            using (StreamReader sr = new StreamReader(PathToCurrentPost, System.Text.Encoding.Default))
            {
                CurrentPostString = sr.ReadToEnd();
            }
            string account;
            using (StreamReader sr = new StreamReader(PathToCurrentAccount, System.Text.Encoding.Default))
            {
                account = sr.ReadToEnd();
            }
            CurrentAccount = JsonConvert.DeserializeObject<Account>(account);
            RealCurrentAccount = instagram.SearchAccount(CurrentAccount.UserName);
            CurrentPost = JsonConvert.DeserializeObject<Post>(CurrentPostString);
            if (CurrentPost.UploaderUserName != "Instagram")
                CurrentRealPost = instagram.SearchAccount(CurrentPost.UploaderUserName).posts.FirstOrDefault(o => o.ImageURL == CurrentPost.ImageURL);
            dataGridViewComments.DataSource = null;
            dataGridViewComments.DataSource = CurrentPost.comments;
        }

        private void CommentButton_Click(object sender, EventArgs e)
        {
            Post Poster;
            List<Post> PostsList;
            if (!CommentText.Text.IsNothing())
            {
                PostsList = instagram.GetAllPosts();
                Poster = PostsList.FirstOrDefault(o => o.ImageURL == CurrentPost.ImageURL);
                RealCurrentAccount.CommentOnPost(Poster, CommentText.Text);
                if (CurrentPost.UploaderUserName != "Instagram")
                {
                    RealCurrentAccount.CommentOnPost(CurrentRealPost, CommentText.Text);
                }
                instagram.UpdateDataBase();
                instagram.UpdateAllPosts(PostsList);
                dataGridViewComments.DataSource = null;
                dataGridViewComments.DataSource = Poster.comments;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(PathToCurrentAccount, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(JsonConvert.SerializeObject(RealCurrentAccount));
            }
            UploadImage OpenForm = new UploadImage();
            OpenForm.Show();
            Visible = false;
        }
    }
}
