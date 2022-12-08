using PCL.Abstraction.Models;
using PCL.Implementation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCL.Abstraction.Services
{
    public interface IInstagramService
    {
        void AddAccount(string fullName, int age, GenderType gender, string mobileNumber, string userName, string password);
        Account SearchAccount(string userName);
        List<Account> GetAccountsFromFile();
        void UpdateDataBase();
        List<Post> GetAllPosts();
        void UpdateAllPosts(List<Post> PostList);
    }
}
