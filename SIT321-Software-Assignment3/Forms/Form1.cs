using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIT321_Software_Assignment3.Users;
using SIT321_Software_Assignment3.Exceptions;
using System.IO;
using System.Reflection;

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

        private void label1_Click(object sender, EventArgs e)
        {

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
            bool dbExists = false;

            try
            {
                UserManager.LoadDB(pwFile);
                dbExists = true;
            }
            catch
            {
                MessageBox.Show("well thats bad");
            }
            


            if (dbExists)
            {
                UserManager.SeedDB();
                User user;
                while ((user = GetLogin(textBox1.Text, textBox2.Text)) != null)
                {
                    List<SIT321_Software_Assignment3.Menus.MenuOption> menu = SIT321_Software_Assignment3.Menus.MenuSystem.GetMenu(user);
                    SIT321_Software_Assignment3.Menus.MenuSystem.RunMenu(user, menu);
                }

                UserManager.SaveDB(pwFile);
            }
        }

        public static User GetLogin(string login, string pass)
        {
            User u;

            if ((u = UserManager.ValidateLogin(login, pass)) == null)
                MessageBox.Show("Invalid login.");


            return u;
        }

    }
}
