﻿using System;
using SIT321_Software_Assignment3.Users;
using SIT321_Software_Assignment3.Exceptions;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace SIT321_Software_Assignment3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

        }

        public void Welcome(User user)
        {

            string firstName = user.GivenName;
            string lastName = user.FamilyName;

            label2.Text = String.Format("Welcome {0} {1}", firstName, lastName);


            ListViewItem lvi = new ListViewItem("Garbage");
            foreach (User u in UserManager._UserList)
            {
                if (u is Student)
                {

                    lvi = new ListViewItem(u.unit.ToString());

                    lvi.SubItems.Add(u.Login.ToString());
                    lvi.SubItems.Add(u.GivenName.ToString());

                    listView1.Items.Add(lvi);
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SIT321_Software_Assignment3.Menus.MenuSystem.loginOpen();
        }
    }
}
