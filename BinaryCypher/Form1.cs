using System;
using System.Text;
using System.Windows.Forms;

namespace BinaryCypher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        string XorEncryptDecrypt(string s, string key)
        {
            StringBuilder encrypted = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                encrypted.Append((char)((uint)s[i] ^ (uint)key[i % key.Length]));
            }
            return encrypted.ToString();
        }

        private void EncryptAndSetText(object sender)
        {
            if(textBox1.Text!="" && textBox4.Text != "")
            textBox2.Text = XorEncryptDecrypt(textBox1.Text, textBox4.Text);
            textBox3.Text = XorEncryptDecrypt(textBox2.Text, textBox4.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            EncryptAndSetText(sender);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            EncryptAndSetText(sender);
        }
    }
}
