using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTS2023_ConventorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Pounds";
            label3.Text = "Kg";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Feet";
            label3.Text = "m";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                float weight = float.Parse(textBox1.Text);
                ConvertToKg(weight);
            }
            else if (radioButton2.Checked)
            {
                float height = float.Parse(textBox1.Text);
                ConvertToM(height);
            }
        }

        public void ConvertToKg(float pounds)
        {
            double kg = pounds * 0.4;
            textBox2.Text = kg.ToString();
        }

        public void ConvertToM(float feet)
        {
            double m = feet * 0.3;
            textBox2.Text = m.ToString();
        }

    }
}
