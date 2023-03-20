using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sectionBox.Text = WishList.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WishList.Items.Add("16");
            WishList.Items.Add("17");
            WishList.Items.Add("12");
            WishList.Items.Add("13");
            WishList.Items.Add("18");
            WishList.Items.Add("15");
            WishList.Items.Add("14");
            WishList.Items.Add("11");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WishList.Sorted = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            countBox.Text = WishList.Items.Count.ToString();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            WishList.Items.Clear();
        }

        private void sectionBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
