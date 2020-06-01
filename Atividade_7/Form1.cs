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
using System.Collections;

namespace Atividade_7 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
           
                int[] Vetor = new int[20];
                string auxiliar = "";
                string valor = "";

                for (var x = 0; x < 20; x++) {
                    valor = Interaction.InputBox("Digite um valor na posição: " + (x + 1),
                        "Entrada de Dados");

                    if (valor == "") {
                        break;
                    }

                    if (int.TryParse(valor, out Vetor[x])) {
                        //auxiliar = auxiliar + "\n" + Vetor[x].ToString();
                        auxiliar = Vetor[x].ToString() + "\n" + auxiliar;
                    }
                    else {
                        MessageBox.Show("Número inválido!");
                        x--;
                    }
                }
                MessageBox.Show(auxiliar);
            
        }

        private void button2_Click(object sender, EventArgs e) {
            
            int[] Vetor = new int[20];
            string auxiliar = "";
            string valor = "";

            for (var x = 0; x < 20; x++) {
                valor = Interaction.InputBox("Entre com dado da posição: " + (x + 1), "Entrada de Dados");
                if (valor == "")
                    break;
                if (!int.TryParse(valor, out Vetor[x])) {
                    MessageBox.Show("Digite número válido!");
                    x--;
                }
            }
            Array.Reverse(Vetor);
            for (var x = 0; x < 20; x++) {
                auxiliar = auxiliar + "\n" + Vetor[x];
            }

            MessageBox.Show(auxiliar);

        }

        private void button3_Click(object sender, EventArgs e) {
            int[] quantidade = new int[10];
            double[] precos = new double[10];

            string preco, quant;
            double faturamento = 0.0;

            for (int i = 0; i < 10; i++) {
                preco = Interaction.InputBox("Entre com o preço do produto " + (i + 1) + ": (R$)", "Entrada de Dados");
                if (preco == "")
                    break;
                quant = Interaction.InputBox("Entre com a quantidade ventida do produto " + (i + 1) + ": (valor inteiro)", "Entrada de Dados");

                double.TryParse(preco, out precos[i]);
                int.TryParse(quant, out quantidade[i]);

                faturamento += quantidade[i] * precos[i];

            }
            MessageBox.Show("Faturamento total da empresa foi de: " + faturamento.ToString("C"));
        }
        private void button4_Click(object sender, EventArgs e) {
            MessageBox.Show("A resposta do exercício 4 é:\n\nC (46)");
        }
        private void button5_Click(object sender, EventArgs e) {
            List<string> lista1 = new List<string>() { "Ana", "André", "Débora", "Fátima", "João", "Janete", "Otávio", "Marcelo", "Pedro", "Thais" };

            //lista1.Add(new string() );
            string auxiliar = "";
            foreach (string nome in lista1) {
                if (nome != "Otávio") {
                    auxiliar = auxiliar + "\n" + nome;
                }
            }

            MessageBox.Show(auxiliar);
        }

        private void button6_Click(object sender, EventArgs e) {
            double[,] alunos = new double[20, 3];
            string nota, auxiliar = "";
            bool key = false;

            for (int i = 0; i < 20; i++) {
                for (int j = 0; j < 3; j++) {
                    nota = Interaction.InputBox("Entre com a Nota " + (j + 1) + " do Aluno " + (i + 1) + ":", "Entrada de Notas");
                    if (nota == "" && j == 0)
                        break;
                    double.TryParse(nota, out alunos[i, j]);
                    if (j == 2)
                        key = true;
                }

                if (key == true)
                    key = false;
                else
                    break;

                auxiliar += "Aluno " + (i + 1) + ": média :" + ((alunos[i, 0] + alunos[i, 1] + alunos[i, 2]) / 3).ToString("N1") + "\n";
            }
            MessageBox.Show(auxiliar);
        }

        private void button7_Click(object sender, EventArgs e) {
            Exercicio7 form1 = new Exercicio7();
            form1.Show();
        }
    }
}