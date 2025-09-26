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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CERRA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Opcion = 0;

            if (piedra.Checked)
            {
                Opcion = 1;
            }
            else if (papel.Checked)
            {
                Opcion = 2;
            }
            else if (tijera.Checked)
            {
                Opcion = 3;
            }
            else MessageBox.Show("ELIJI PORFAVOR POR DIEGUTIO ARMANDO MARADONA");



            if (Opcion != 0)
            {
                Random random = new Random();
               int Compu = random.Next(1, 4);
                if (Compu == 1)
                {
                    textCompu.Text = ("RACK");
                }
                else if (Compu == 2)
                {
                    textCompu.Text = ("PEIPER");
                }
                else
                {
                    textCompu.Text = ("CHAINSAW");
                }
                if (Opcion == Compu)
                {
                    lbResult.Text = ("UN EMPATE ES UNA DERROTA");
                }
                else if (Opcion == 1 && Compu == 3 || Opcion == 2 && Compu == 1 || Opcion == 3 && Compu == 2)
                {
                    lbResult.Text = ("Ganamos ganamos esoooooo!!!!");
                }
                else
                {
                    lbResult.Text = ("PERDISTESSSSSSS");
                }
                }
        }
    }
}
