using System;
using SIT321_Software_Assignment3.Users;
using SIT321_Software_Assignment3.Exceptions;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace SIT321_Software_Assignment3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();


            
        }

        public void Welcome(User user)
        {

            string firstName = user.GivenName;
            string lastName = user.FamilyName;

            label2.Text = String.Format("Welcome {0} {1}", firstName, lastName);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SIT321_Software_Assignment3.Menus.MenuSystem.loginOpen();
        }
    }
}
