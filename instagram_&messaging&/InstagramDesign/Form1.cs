using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstagramDesign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SignUp OpenForm = new SignUp();
            OpenForm.Show();
            Visible = false;
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            SignIn OpenForm = new SignIn();
            OpenForm.Show();
            Visible = false;
        }
    }
}
