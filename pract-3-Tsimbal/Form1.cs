using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pract_3_Tsimbal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "-";
textBox3.Enabled = false;
            textBox4.Enabled = true;


        }

        private void button1_Click(object sender, EventArgs e)
        {

            double kurs1, kurs2, suma, sum_out;
            kurs1 = double.Parse(textBox1.Text);
            kurs2 = double.Parse(textBox2.Text);
            if (radioButton1.Checked==true)
}

        textBox4.Enabled = true;
suma= double.Parse(textBox3.Text);
        sum_out = suma* kurs1;
        textBox4.Text = sum_out.ToString();
private void button2_Click(object sender, EventArgs e)
        {
            string S = textBox1.Text;
            Int a = int.Parse(S);
            Int b = a * a;
            Label1.Text - b.ToString();

        }
    }
else
}
}
        }
    }
}
