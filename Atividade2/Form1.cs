using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace PesoIdealCSForms {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e) {

            double Altura, Peso, PesoIdeal;

            if (double.TryParse(txtAltura.Text.Replace(',','.'), out Altura) && double.TryParse(txtPeso.Text.Replace(',', '.'), out Peso)) {
                
                //Se homem:
                if (radioButton1.Checked) {
                    PesoIdeal = 72.7 * Altura - 58;
                }
                
                //Se mulher:
                else {
                    PesoIdeal = 62.1 * Altura - 44.7;
                    
                }
                MessageBox.Show("Seu peso ideal é " + PesoIdeal.ToString("F2").Replace('.',',') + "\nA diferença de peso é de " + (Peso - PesoIdeal).ToString("F2").Replace('.',','));
            }
            else
                MessageBox.Show("Insira dados válidos!");
        }
    }
}
