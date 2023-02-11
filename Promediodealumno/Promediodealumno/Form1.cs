using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Promediodealumno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            decimal num1=Convert.ToDecimal(textBox1.Text);
            decimal num2=Convert.ToDecimal(textBox2.Text);
            decimal num3=Convert.ToDecimal(textBox3.Text);
            decimal num4=Convert.ToDecimal(textBox4.Text);

            decimal resultado = await PromedioAsync(num1, num2, num3, num4);

            MessageBox.Show($" El promedio es:{resultado}");

            if  (resultado >= 100) 
                {
                textBox5.Text = "Aprobo";
            }
              else 
            {
                textBox5.Text = "Reprobo";
            }


        }

        private async Task< decimal> PromedioAsync(decimal n1,decimal n2,decimal n3, decimal n4)
        {
            decimal promedio = await Task.Run(() =>

            {
                return (n1 + n2 + n3 + n4) / 4;

            });
            return promedio;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

           textBox1.Focus();
        }
    }
}
