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
            int i = 0;

            User u;
            string Firstname = u.FamilyName.ToString();

            
            //ListViewItem lvi = new ListViewItem("adsfafds");
            //foreach (User u in UserManager.getusers())
            //{
            //    if (i == 0)
            //    {
            //        lvi = new ListViewItem(u.ToString());
            //        i++;
            //    }
            //    else
            //    lvi.SubItems.Add(u.ToString());


                
            //}

            
            listView1.Items.Add(lvi);

        }
    }
}
