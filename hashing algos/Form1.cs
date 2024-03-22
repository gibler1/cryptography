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
            string temp = input.Text;
            string tempresult = "";
            if (saltCheck.Checked)
            {
                temp = saltValue.Text + temp;
            }

            if (labelboxfun.Text == "Hash")
            {
                if (labelboxalg.Text == "MD5")
                {
                    tempresult = Hashfunctions.MD5(temp);
                }
                else if (labelboxalg.Text == "MD4")
                {
                    tempresult = Hashfunctions.MD4(temp);
                }
                else if (labelboxalg.Text == "SHA-1")
                {
                    tempresult = Hashfunctions.SHA1(temp);
                }
                else if (labelboxalg.Text == "SHA-256")
                {
                    tempresult = Hashfunctions.SHA256(temp);
                }
            }
            else if (labelboxfun.Text == "Decrypt")
            {
                Decrypt Decrypt = new Decrypt();
                if (labelboxalg.Text == "MD5")
                {
                    tempresult = Decrypt.MD5(temp);
                }
                else if (labelboxalg.Text == "MD4")
                {
                    tempresult = Decrypt.MD4(temp);
                }
                else if (labelboxalg.Text == "SHA-1")
                {
                    tempresult = Decrypt.SHA1(temp);
                }
                else if (labelboxalg.Text == "SHA-256")
                {
                    tempresult = Decrypt.SHA256(temp);
                }
            }

            if (saltCheck.Checked && labelboxfun.Text != "Decrypt")
            {
                result.Text = saltValue.Text + "$" + tempresult;
            }
            else
            {
                result.Text = tempresult;
            }
        }

        private void labelboxalg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            saltValue.Visible = !saltValue.Visible;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void saltValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(result.Text);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
