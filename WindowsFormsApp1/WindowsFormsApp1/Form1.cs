using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        private void Button1_Click_1(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (username == "admin" && password == "password")
            {
                Form2 form2 = new Form2();
                form2.Show();
                Hide();
            }
            else if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and password are empty.");
            }
            else if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username is empty.");
            }
            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password is empty.");
            }
            else if (username != "admin")
            {
                MessageBox.Show("Invalid Username.");
            }
            else if (password != "password")
            {
                MessageBox.Show("Invalid Password.");
            }
            else
            {
                MessageBox.Show("Invalid Username and Password.");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
