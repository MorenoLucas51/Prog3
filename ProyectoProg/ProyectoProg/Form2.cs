using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProg
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void typenum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
    
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
  
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(typenum1.Text, out double num) && double.TryParse(typenum2.Text, out double num2))
             {


                double resultado = 0;
                if (radioButton1.Checked)
                {
                    resultado = num + num2;
                }
                else if (radioButton2.Checked)
                {
                    resultado = num - num2;
                }
                else if (radioButton3.Checked)
                {
                    resultado = num * num2;
                }
                else if (radioButton4.Checked)
                {
                    if (num2 != 0)
                    {
                        resultado = num / num2;
                    }
                    else
                    {
                        MessageBox.Show("No se puede dividir entre 0.");
                    }
                }
                textResult.Text = resultado.ToString("N2");
            }
            else
            {
                MessageBox.Show("Poneme numerito nene");                
            }
        }

        private void textResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
