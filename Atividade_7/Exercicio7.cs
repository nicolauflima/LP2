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


namespace Atividade_7 {
    public partial class Exercicio7 : Form {
        public Exercicio7() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            string auxiliar = "";
            string[] nomes = new string[8];
            int[] letras = new int[8];

            listBox1.Items.Clear();

            for(int i = 0; i < 8; i++) {
                auxiliar = Interaction.InputBox("Entre com o nome de número " + (i + 1) + ":", "Entrada de Nomes");
                if (auxiliar == "")
                    break;

                nomes[i] = auxiliar;
                letras[i] = 0;
                foreach(char letra in auxiliar) {
                    if (letra != 0x20)
                        letras[i]++;
                }
                listBox1.Items.Add("O nome: " + auxiliar + " tem " + letras[i] + " caracteres.");
            }
            
        }
    }
}
