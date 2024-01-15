using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Food/Burger");
            listBox2.Items.Add("₱50");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Food/Chease Burger");
            listBox2.Items.Add("₱50");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Food/Burger Steak");
            listBox2.Items.Add("₱60");
        }
        private void button4_Click(object sender, EventArgs e)
        { 
            listBox1.Items.Add("Food/Nuggets");
            listBox2.Items.Add("₱60");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Milk Tea/Cookies and Cream");
            listBox2.Items.Add("₱15");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Milk Tea/Vanilla");
            listBox2.Items.Add("₱15");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Milk Tea/Mango");
            listBox2.Items.Add("₱15");
        }
        private void button8_Click(object sender, EventArgs e)
        { 
            listBox1.Items.Add("Drinks/BlueLemonade");
            listBox2.Items.Add("₱20");
        }
        private void button9_Click(object sender, EventArgs e)
        { 
            listBox1.Items.Add("Drinks/Iced Tea");
            listBox2.Items.Add("₱20");
        }
        private void button10_Click(object sender, EventArgs e)
        { 
            listBox1.Items.Add("Drinks/Lemonade");
            listBox2.Items.Add("₱20");
        }
        private void CALCULATE_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (var item in listBox2.Items)
            {
                string price = item.ToString().Replace("₱", "");
                sum += Convert.ToInt32(price);
                textBox1.Text = "₱" + sum.ToString();

                int count = listBox2.Items.Count;
                textBox2.Text = count.ToString();
            }   
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void UNDO_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0 && listBox2.Items.Count > 0)
            {
                listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
                listBox2.Items.RemoveAt(listBox2.Items.Count - 1);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Check111_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox4.Text);

            int num2 = Convert.ToInt32(textBox1.Text.Replace("₱", ""));
            int result = num1 - num2;
            textBox3.Text = "₱" + result.ToString();
        }


   
        private void CONFRIM_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(GetListBoxItems(), GetTextBoxText());
            form3.Show();

        }
        public string GetTextBoxText()
        {
            return textBox1.Text;
        }

        public List<string> GetListBoxItems()
        {
            List<string> items = new List<string>();
            foreach (var item in listBox1.Items)
            {
                items.Add(item.ToString());
            }
            return items;
        }

        private void lol(object sender, PaintEventArgs e)
        {

        }
    }
}
