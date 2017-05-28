using System;
using SIT321_Software_Assignment3.Users;
using SIT321_Software_Assignment3.Exceptions;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace SIT321_Software_Assignment3
{
    public partial class Form1 : Form
    {
        #region Configuration
        private const string _PASSWORDS_FILENAME = "Users.bin";
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pwFile = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\" + _PASSWORDS_FILENAME;
            bool dbExists = true;

            //try
            //{
            //    UserManager.LoadDB(pwFile);
            //    dbExists = true;
            //}
            //catch
            //{
            //    MessageBox.Show("well thats bad");
            //}
            


            if (dbExists)
            {

                User user;
                if ((user = GetLogin(textBox1.Text, textBox2.Text)) != null)
                {
                    SIT321_Software_Assignment3.Menus.MenuSystem.GetMe(user);
                }
                
                this.Visible = false;

                UserManager.SaveDB(pwFile);
            }
        }

        public static User GetLogin(string login, string pass)
        {
            User u;

            if ((u = UserManager.ValidateLogin(login, pass)) == null)
            {
                MessageBox.Show("Invalid login.");
                System.Environment.Exit(1);
            }


            return u;
        }
    }
}
