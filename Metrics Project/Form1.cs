using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metrics_Project
{
    public partial class Form1 : Form
    {
        public static int EI=0;
        public static int EO=0;
        public static int EQ = 0;
        public static int ILF = 0;
        public static int EIF = 0;
        public static int DI = 0;
        public static int UFP = 0;
        public static double TCF = 0;
        public static double FP = 0
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(EI_Box.Text!="")
            EI = Convert.ToInt32(EI_Box.Text);
        }

        private void EO_Box_TextChanged(object sender, EventArgs e)
        {
            if (EO_Box.Text != "")
                EO = Convert.ToInt32(EO_Box.Text);
        }

        private void EIF_Box_TextChanged(object sender, EventArgs e)
        {
            if (EIF_Box.Text != "")
                EIF = Convert.ToInt32(EIF_Box.Text);
        }

        private void ELF_Box_TextChanged(object sender, EventArgs e)
        {
            if (ILF_Box.Text != "")
                ILF = Convert.ToInt32(ILF_Box.Text);
        }

        private void EQ_Box_TextChanged(object sender, EventArgs e)
        {
            if (EQ_Box.Text != "")
                EQ = Convert.ToInt32(EQ_Box.Text);
        }

        private void DI_Box_TextChanged(object sender, EventArgs e)
        {
            DI = Convert.ToInt32(DI_Box.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Simple")
                EI *= 3;
            else if (comboBox1.SelectedItem.ToString() == "Average")
                EI *= 4;
            else if (comboBox1.SelectedItem.ToString() == "Complex")
                EI *= 6;

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem.ToString() == "Simple")
                EO *= 4;
            else if (comboBox2.SelectedItem.ToString() == "Average")
                EO *= 5;
            else if (comboBox2.SelectedItem.ToString() == "Complex")
                EO *= 7;


        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox3.SelectedItem.ToString() == "Simple")
                EQ *= 3;
            else if (comboBox3.SelectedItem.ToString() == "Average")
                EQ*= 4;
           else if (comboBox3.SelectedItem.ToString() == "Complex")
                EQ *= 6;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedItem.ToString() == "Simple")
                ILF *= 7;
            if (comboBox4.SelectedItem.ToString() == "Average")
                ILF *=10;
            if (comboBox4.SelectedItem.ToString() == "Complex")
                ILF *= 15;


        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedItem.ToString() == "Simple")
                EIF *= 5; 
                if (comboBox5.SelectedItem.ToString() == "Average")
                EIF *= 7;
            if (comboBox5.SelectedItem.ToString() == "Complex")
                EIF *= 10;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Add("Simple");
            comboBox1.Items.Add("Average");
            comboBox1.Items.Add("Complex");
            this.Controls.Add(comboBox1);

            comboBox2.Items.Add("Simple");
            comboBox2.Items.Add("Average");
            comboBox2.Items.Add("Complex");
            this.Controls.Add(comboBox2);

            comboBox3.Items.Add("Simple");
            comboBox3.Items.Add("Average");
            comboBox3.Items.Add("Complex");
            this.Controls.Add(comboBox3);

            comboBox4.Items.Add("Simple");
            comboBox4.Items.Add("Average");
            comboBox4.Items.Add("Complex");
            this.Controls.Add(comboBox4);

            comboBox5.Items.Add("Simple");
            comboBox5.Items.Add("Average");
            comboBox5.Items.Add("Complex");
            this.Controls.Add(comboBox5);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UFP = EI + EO + EQ + ILF + EIF;
            textBox8.Text = UFP.ToString();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TCF = 0.65 + 0.01 * DI;
            textBox7.Text = TCF.ToString();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FP = TCF * UFP;
            textBox9.Text = FP.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
