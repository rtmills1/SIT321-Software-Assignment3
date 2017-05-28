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
            string unit = user.unit;

            label2.Text = String.Format("Welcome {0} {1}", firstName, lastName);

            label5.Text = String.Format(unit);
            label6.Text = String.Format("HD");
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SIT321_Software_Assignment3.Menus.MenuSystem.loginOpen();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
