using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace P0030481923008 {
    public partial class Janela1 : Form {
        public Janela1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            listBox.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e) {
            int N = 8;
            double[,] matriz = new double[N, 4]; // matriz[mês][semana]

            listBox.Items.Clear();
            bool BREAK = false;
            string entrada;
            double Total = 0.0;
            for (int i = 0; i < N; i++) {
                listBox.Items.Add("------------- Mês " + (i + 1));
                listBox.SelectedIndex = listBox.Items.Count - 1;

                for (int j = 0; j < 4; j++) {

                    entrada = Interaction.InputBox("Entre com o valor da Semana " + (j + 1), "Entrada de valores.").Replace(".", ",");
                    if (entrada != "") {
                        if (double.TryParse(entrada, out matriz[i,j])) {
                            listBox.Items.Add("Semana " + (j + 1) + ": " + matriz[i,j].ToString("C"));
                            listBox.SelectedIndex = listBox.Items.Count - 1;
                            Total += matriz[i,j];
                        }
                        else {
                            MessageBox.Show("Valor inválido!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            j--;
                        }
                    }
                    else {
                        BREAK = true;
                        if(j == 0)
                            listBox.Items.RemoveAt(listBox.Items.Count - 1);
                        else
                            listBox.Items.Add("");
                        break;
                    }
                }

                if (BREAK == true)
                    break;

                listBox.Items.Add(">> TOTAL Mês: " + (matriz[i,0] + matriz[i,1] + matriz[i, 2] + matriz[i, 3]).ToString("C"));
                listBox.Items.Add("");
                listBox.SelectedIndex = listBox.Items.Count - 1;
                

            }

            
            listBox.Items.Add("--------------------------------------");
            listBox.Items.Add("Total Geral: " + Total.ToString("C"));
            listBox.SelectedIndex = listBox.Items.Count - 1;



        }
    }
}
