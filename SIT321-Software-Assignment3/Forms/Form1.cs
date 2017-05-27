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

namespace SIT321_Software_Assignment3
{
    public partial class Form1 : Form
    {
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
            string login = textBox1.Text;
            string pass = textBox2.Text;

            GetLogin(textBox1.Text, textBox2.Text);


        }

        public static User GetLogin(string login, string pass)
        {
            ConsoleKeyInfo cki;
            User ret = null;
            do
            {
                try
                {
                    while ((cki = Console.ReadKey(true)) != null)
                    {
                        if (cki.Key == ConsoleKey.Enter)
                        {
                            Console.WriteLine();
                            break;
                        }
                        else
                            pass += cki.KeyChar;
                    }
                    if ((ret = UserManager.ValidateLogin(login, pass)) == null)
                        Console.Error.WriteLine("Invalid login.");
                }
                catch (SIT321_Software_Assignment3.Exceptions.EasyLibraryException ex)
                {
                    Console.Error.WriteLine("Error: {0}", ex.Message);
                }
            } while (ret == null);

            return ret;
        }
       

        }
}
