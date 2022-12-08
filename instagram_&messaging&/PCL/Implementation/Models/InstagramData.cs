using PCL.Abstraction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCL.Implementation.Models
{
    public class InstagramData : IInstagramData
    {
        private InstagramData() { }
        private List<Account> accounts { get; set; } = DIContainer.GetInstagramService().GetAccountsFromFile();

        public List<Account> GetAccounts()
        {
            return accounts;
        }

        private static InstagramData _instance = null;
        private static object _root = new object();
        public static InstagramData Instance
        {
            get
            {
                lock(_root)
                {
                    if (_instance == null)
                        _instance = new InstagramData();
                }
                return _instance;
            }
        }
    }
}
