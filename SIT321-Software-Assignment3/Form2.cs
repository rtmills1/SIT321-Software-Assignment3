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
            SIT321_Software_Assignment3.Menus.MenuSystem.newUser();
            this.Hide();
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

        public void preloadTwo()
        {

            ListViewItem lvi = new ListViewItem("Garbage");
            foreach (User u in UserManager._UserList)
            {
                if (u is Admin)
                {
                }
                else if (u is Student)
                {
                    Student s = new Student(u.Login, u.Password, u.GivenName, u.FamilyName, u.);
                }
                {
                lvi = new ListViewItem(u.Unit.ToString());
                    Student s = new Student();
                lvi.SubItems.Add(s.Unit.ToString());
                lvi.SubItems.Add(u.FamilyName.ToString());
                lvi.SubItems.Add(u.Login.ToString());
                lvi.SubItems.Add(u.Password.ToString());
                }
                

                listView1.Items.Add(lvi);
            }

        }

        public void Dump()
        {

                

                listView1.Clear();
            
        }

        private bool button1WasClicked = false;
        private void button3_Click(object sender, EventArgs e)
        {
            button1WasClicked = true;
        }

        private void listView1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (button1WasClicked)
            {
                string curItem = listView1.SelectedItems.ToString();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            button1WasClicked = true;
     
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (button1WasClicked)
            {
                
                   var item = listView1.SelectedItems;
                string x;
                    foreach (ListViewItem i in item)
                    {
                        x = i.SubItems[3].Text;
                    UserManager.Delete(x);
                    this.Hide();

                    
                }
                Form2 db = new Form2();

                db.Show();
                // string curItem = listView1.SelectedItems.ToString();
                // User u = new User(listView1.SelectedItems.GetEnumerator());

            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}