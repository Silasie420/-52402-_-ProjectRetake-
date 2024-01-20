using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _52402___ProjectRetake_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            ValidateIntegerInput(sender);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            ValidateIntegerInput(sender);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ValidateIntegerInput(sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // First Checks if all text boxes are filled
            if (string.IsNullOrEmpty(textBox1.Text) ||
                string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text) ||
                string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Saves the data to Products.txt
            using (StreamWriter sw = new StreamWriter("Products.txt", true))
            {
                sw.WriteLine($"{textBox1.Text}: {textBox2.Text} - {textBox3.Text} - {textBox4.Text}");
            }

            // Shows notification
            MessageBox.Show("Product has been added.");

            // Clears all text boxes
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 infoForm = new Form4();
            infoForm.Show();
            Hide();
        }
        private void ValidateIntegerInput(object sender)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && !int.TryParse(textBox.Text, out _))
            {
                MessageBox.Show("Only integer values are allowed.");
                textBox.Clear();
            }
        }
    }
}
