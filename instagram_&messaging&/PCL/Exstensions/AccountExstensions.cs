using Newtonsoft.Json;
using PCL.Abstraction.Models;
using PCL.Implementation;
using PCL.Implementation.Models;
using PCL.Implementation.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCL.Exstensions
{
    public static class AccountExstensions
    {
        private static InstagramService instagram = DIContainer.GetInstagramService();
        public static void FollowAccount(this Account acc, string FollowName)
        {
            if (instagram.SearchAccount(FollowName) == null || instagram.SearchAccount(acc.UserName).Following.Any(o => o.Username == instagram.SearchAccount(FollowName).UserName))
                return;
            instagram.SearchAccount(FollowName).Followers.Add(new FollowClass() { Username = acc.UserName});
            instagram.SearchAccount(acc.UserName).Following.Add(new FollowClass() { Username = FollowName});
            instagram.UpdateDataBase();
        }
        public static void UnFollowAccount(this Account acc, string UnFollowName)
        {
            if (instagram.SearchAccount(UnFollowName) == null)
                return;
            List<FollowClass> FollowerClasses = instagram.SearchAccount(UnFollowName).Followers;
            List<FollowClass> FollowingClasses = instagram.SearchAccount(acc.UserName).Following;
            FollowerClasses.RemoveAll(o => o.Username == acc.UserName);
            FollowingClasses.RemoveAll(o => o.Username == UnFollowName);
            instagram.UpdateDataBase();
        }
        public static void SendMessage(this Account acc, string _Message, string RecieverUserName)
        {
            Message mess = new Message()
            {
                message = _Message,
                Reciever = RecieverUserName,
                Sender = acc.UserName,
                Time = DateTime.Now
            };
            instagram.SearchAccount(RecieverUserName).RecievedMessages.Add(mess);
            acc.SentMessages.Add(mess);
            instagram.UpdateDataBase();
        }
        public static void LikeImage(this Account acc, int id)
        {
            foreach (var i in InstagramData.Instance.GetAccounts())
            {
                foreach (var o in i.images)
                {
                    if (o.GetID() == id)
                    {
                        o.Likes.Add(acc.UserName);
                    }
                }
            }
            instagram.UpdateDataBase();
        }
        public static void PostPicture(this Account acc, string PostText, string Imageurl)
        {
            Post TmpPost = new Post() { ImageURL = Imageurl, ProfilePictureURL = acc.ProfilePictureUrl, Text = PostText, UploaderUserName = acc.UserName, Time = DateTime.Now };
            acc.posts.Add(TmpPost);
            string PathToPostsDataBase = Directory.GetCurrentDirectory().Replace(@"\InstagramDesign\bin\Debug", @"\PCL\PostsDataBase.Json");
            string accounts;
            using (StreamReader sr = new StreamReader(PathToPostsDataBase, System.Text.Encoding.Default))
            {
                accounts = sr.ReadToEnd();
            }
            List<Post> accs;
            if (accounts.IsNothing())
                accs = new List<Post>();
            else
                accs = JsonConvert.DeserializeObject<List<Post>>(accounts);
            accs.Add(TmpPost);
            using (StreamWriter sw = new StreamWriter(PathToPostsDataBase, false, System.Text.Encoding.Default))
            {
                string SerializedList = JsonConvert.SerializeObject(accs);
                sw.WriteLine(SerializedList);
            }
            DIContainer.GetInstagramService().UpdateDataBase();
        }

        public static void CommentOnPost(this Account account, Post post, string comment)
        {
            Comment TmpComment = new Comment()
            {
                text = comment,
                CommentatorUserName = account.UserName,
                Time = DateTime.Now
            };
            post.comments.Add(TmpComment);
        }
    }
}
