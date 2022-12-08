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

namespace InstagramDesign
{
    public partial class Terminate : Form
    {
        private Account CurrentAccount;
        private Account RealCurrentAccount;
        private InstagramService instagram;
        private string PathToCurrentAccount = Directory.GetCurrentDirectory().Replace(@"\InstagramDesign\bin\Debug", @"\InstagramDesign\CurrentAccount.Json");
        public Terminate()
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
        }

        private void Terminate_Load(object sender, EventArgs e)
        {

        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            Account_Settings OpenForm = new Account_Settings();
            OpenForm.Show();
            Visible = false;
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            List<Post> PostsList;
            if (RealCurrentAccount.Following.Count != 0)
            {

                foreach (var o in RealCurrentAccount.Following.ToList())
                {
                    RealCurrentAccount.UnFollowAccount(o.Username);
                }
            }
            if (RealCurrentAccount.Followers.Count != 0)
            {
                foreach (var o in RealCurrentAccount.Followers.ToList())
                {
                    Account SearchedAccount = instagram.SearchAccount(o.Username);
                    SearchedAccount.UnFollowAccount(RealCurrentAccount.UserName);
                }
            }
            foreach (var o in InstagramData.Instance.GetAccounts())
            {
                o.RecievedMessages.RemoveAll(i => i.Sender == RealCurrentAccount.UserName || i.Reciever == RealCurrentAccount.UserName);
                o.SentMessages.RemoveAll(i => i.Sender == RealCurrentAccount.UserName || i.Reciever == RealCurrentAccount.UserName);
            }
            InstagramData.Instance.GetAccounts().Remove(RealCurrentAccount);
            PostsList = instagram.GetAllPosts();
            Post SelectedPost;
            foreach (var item in RealCurrentAccount.LikedPosts)
            {
                SelectedPost = PostsList.FirstOrDefault(o => o.ImageURL == item.ImageURL);
                SelectedPost.Likes--;
                foreach (var o in InstagramData.Instance.GetAccounts())
                {
                    o.posts.FirstOrDefault(i => i.ImageURL == item.ImageURL).Likes--;
                }
            }
            PostsList.RemoveAll(o => o.UploaderUserName == RealCurrentAccount.UserName);
            instagram.UpdateAllPosts(PostsList);
            instagram.UpdateDataBase();
            using (StreamWriter sw = new StreamWriter(PathToCurrentAccount, false, System.Text.Encoding.Default))
            {
                sw.WriteLine("");
            }
            Form1 OpenForm = new Form1();
            OpenForm.Show();
            Visible = false;
        }
    }
}
