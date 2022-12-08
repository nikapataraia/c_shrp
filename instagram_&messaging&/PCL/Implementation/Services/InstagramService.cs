using Newtonsoft.Json;
using PCL.Abstraction.Models;
using PCL.Abstraction.Services;
using PCL.Implementation.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PCL.Exstensions;

namespace PCL.Implementation.Services
{
    public class InstagramService : IInstagramService
    {
        private string PathToPostsDataBase = Directory.GetCurrentDirectory().Replace(@"\InstagramDesign\bin\Debug", @"\PCL\PostsDataBase.Json");
        private string PathToDataBase = Directory.GetCurrentDirectory().Replace(@"\InstagramDesign\bin\Debug", @"\PCL\AccountDataBase.Json");
        public void AddAccount(string fullName, int age, GenderType gender, string mobileNumber, string userName, string password)
        {
            Account account = new Account()
            {
                UserName = userName,
                person = new Person()
                {
                    FullName = fullName,
                    Age = age,
                    Gender = gender,
                    MobileNumber = mobileNumber
                },
                Password = password
            };
            InstagramData.Instance.GetAccounts().Add(account);
            UpdateDataBase();
        }

        public List<Account> GetAccountsFromFile()
        {
            string accounts;
            using (StreamReader sr = new StreamReader(PathToDataBase, System.Text.Encoding.Default))
            {
                accounts = sr.ReadToEnd();
            }
            List<Account> accountsList = JsonConvert.DeserializeObject<List<Account>>(accounts);
            return accountsList == null ? new List<Account>() : accountsList;
        }

        public Account SearchAccount(string userName)
        {
            return InstagramData.Instance.GetAccounts().FirstOrDefault(o => o.UserName == userName);
        }
        public void UpdateDataBase()
        {
            using (StreamWriter sw = new StreamWriter(PathToDataBase, false, System.Text.Encoding.Default))
            {
                string SerializedObject = JsonConvert.SerializeObject(InstagramData.Instance.GetAccounts());
                sw.WriteLine(SerializedObject);
            }
        }

        public List<Post> GetAllPosts()
        {
            List<Post> Posts;
            string Poststring;
            using (StreamReader sr = new StreamReader(PathToPostsDataBase, System.Text.Encoding.Default))
            {
                Poststring = sr.ReadToEnd();
            }
            if (Poststring.IsNothing())
                Posts = new List<Post>();
            else
                Posts = JsonConvert.DeserializeObject<List<Post>>(Poststring);
            return Posts;
        }
        public void UpdateAllPosts(List<Post> PostList)
        {
            using (StreamWriter sw = new StreamWriter(PathToPostsDataBase, false, System.Text.Encoding.Default))
            {
                string SerializedObject = JsonConvert.SerializeObject(PostList);
                sw.WriteLine(SerializedObject);
            }
        }
    }
}
