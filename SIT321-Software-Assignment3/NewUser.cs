using SIT321_Software_Assignment3.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIT321_Software_Assignment3
{
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NewUser_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_NewUser_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_NewUser_create_Click(object sender, EventArgs e)
        {
            string firstname = NewUser_firstname.Text;
            string lastname = NewUser_secondname.Text;
            string username = NewUser_username.Text;
            string password = NewUser_password.Text;
            string unit = NewUser_unit.Text;
            string type = NewUser_Type.SelectedItem.ToString();

            if (type == "Student")
            {
                UserManager._UserList.Add(new Student(username, password, firstname, lastname, unit));
            }

            if (type == "Lecturer")
            {
                UserManager._UserList.Add(new Lecturer(username, password, firstname, lastname, unit));
            }

            if (type == "Admin")
            {
                UserManager._UserList.Add(new Admin(username, password, firstname, lastname, unit));
            }
            this.Hide();
            Form2 db = new Form2();
            db.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
