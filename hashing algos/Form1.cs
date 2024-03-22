using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hashfunction;


namespace hashing_algos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelboxfun_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (labelboxfun.Text == "Hash")
            {
                if (labelboxalg.Text == "MD5")
                {
                    result.Text = Hashfunctions.MD5(input.Text);
                }
                else if (labelboxalg.Text == "MD4")
                {
                    result.Text = Hashfunctions.MD4(input.Text);
                }
                else if (labelboxalg.Text == "SHA-1")
                {
                    result.Text = Hashfunctions.SHA1(input.Text);
                }
                else if (labelboxalg.Text == "SHA-256")
                {
                    result.Text = Hashfunctions.SHA256(input.Text);
                }
            }
            else if (labelboxfun.Text == "Decrypt")
            {
                Decrypt Decrypt = new Decrypt();
                if (labelboxalg.Text == "MD5")
                {
                    result.Text = Decrypt.MD5(input.Text);
                }
                else if (labelboxalg.Text == "MD4")
                {
                    result.Text = Decrypt.MD4(input.Text);
                }
                else if (labelboxalg.Text == "SHA-1")
                {
                    result.Text = Decrypt.SHA1(input.Text);
                }
                else if (labelboxalg.Text == "SHA-256")
                {
                    result.Text = Decrypt.SHA256(input.Text);
                }
            }
        }

        private void labelboxalg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
