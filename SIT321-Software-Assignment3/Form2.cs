using System;
using SIT321_Software_Assignment3.Users;
using SIT321_Software_Assignment3.Exceptions;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace SIT321_Software_Assignment3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            preload();
        }

        public void dataGridView1()
        {

        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SIT321_Software_Assignment3.Menus.MenuSystem.loginOpen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        public void preload()
        {

            ListViewItem lvi = new ListViewItem("Garbage");
            foreach (User u in UserManager._UserList)
            {

                lvi = new ListViewItem(u.Title.ToString());

                lvi.SubItems.Add(u.GivenName.ToString());
                lvi.SubItems.Add(u.FamilyName.ToString());
                lvi.SubItems.Add(u.Login.ToString());
                lvi.SubItems.Add(u.Password.ToString());

                listView1.Items.Add(lvi);
            }

        }
    }
}
