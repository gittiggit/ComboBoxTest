using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboboxTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            comboBox1.Items.Add("Earth");
            comboBox1.Items.Add("Mercary");
            comboBox1.Items.Add("Mars");
            comboBox1.Items.Add("Jupiter");
            comboBox1.Items.Add("Uranus");
            comboBox1.Items.Add("Neptune");
            comboBox1.Items.Add("Saturn");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have selected : "+comboBox1.SelectedItem);
        }
    }
}
