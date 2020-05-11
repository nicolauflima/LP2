using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio3_Triangulos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double A, B, C = 0.0;
            if (double.TryParse(txtBoxA.Text, out A) && double.TryParse(txtBoxB.Text, out B) && double.TryParse(txtBoxC.Text, out C) && A != 0.0 && B != 0.0 && C != 0.0)
            {
                PictureBox pb1 = new PictureBox();
                if (A == B && B == C)
                {
                    MessageBox.Show("Triângulo Equilátero!","Informação",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                      
                }
                else if (A == B || B == C || C == A)
                {
                    MessageBox.Show("Triângulo Isósceles!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else
                {
                    MessageBox.Show("Triângulo Escaleno!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("Entradas não são válidas!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txtBoxA_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
                button1.PerformClick();
        }

        private void txtBoxB_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
                button1.PerformClick();
        }

        private void txtBoxC_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
                button1.PerformClick();
        }
    }
}
