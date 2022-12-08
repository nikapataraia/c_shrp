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
using Message = PCL.Implementation.Models.Message;

namespace InstagramDesign
{
    public partial class Direct_Messages : Form
    {
        private InstagramService instagram;
        private Account RealCurrentAccount;
        private Account CurrentAccount;
        private string PathToCurrentAccount = Directory.GetCurrentDirectory().Replace(@"\InstagramDesign\bin\Debug", @"\InstagramDesign\CurrentAccount.Json");
        public Direct_Messages()
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
            dataGridViewFollowing.DataSource = null;
            dataGridViewFollowing.DataSource = RealCurrentAccount.Following;
            using (StreamWriter sw = new StreamWriter(PathToCurrentAccount, false, System.Text.Encoding.Default))
            {
                sw.WriteLine("");
            }
        }

        private List<Message> SentMessagesfromsomeone;

        private void SendMessageButton_Click(object sender, EventArgs e)
        {
            if (!MessageText.Text.IsNothing() && something != null)
            {
                RealCurrentAccount.SendMessage(MessageText.Text, something);
                dataGridViewSentMessages.DataSource = null;
                SentMessagesfromsomeone = RealCurrentAccount.SentMessages.Where(o => o.Reciever == something).ToList();
                dataGridViewSentMessages.DataSource = SentMessagesfromsomeone;
            }
        }

        private string something;

        private void DataGridViewFollowing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewFollowing.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                something = dataGridViewFollowing.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                dataGridViewRecievedMessages.DataSource = null;
                dataGridViewRecievedMessages.DataSource = RealCurrentAccount.RecievedMessages.Where(o => o.Sender == something).ToList();
                dataGridViewSentMessages.DataSource = null;
                dataGridViewSentMessages.DataSource = RealCurrentAccount.SentMessages.Where(o => o.Reciever == something).ToList();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(PathToCurrentAccount, false, System.Text.Encoding.Default))
            {
                sw.WriteLine("");
                sw.WriteLine(JsonConvert.SerializeObject(RealCurrentAccount));
            }
            UserSide OpenForm = new UserSide();
            OpenForm.Show();
            Visible = false;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
