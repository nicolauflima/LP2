using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCS {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) {

            double verify1, verify2;

            if (double.TryParse(TxtNum1.Text, out verify1) && double.TryParse(TxtNum2.Text, out verify2)) {
                double resultado = verify1 + verify2;
                TxtNum3.Text = resultado.ToString("N2");
            }
            else
                MessageBox.Show("Um ou mais números incorretos!");

        }

        private void button6_Click(object sender, EventArgs e) {
            Close();
        }

        private void button5_Click(object sender, EventArgs e) {
            TxtNum1.Clear();
            TxtNum2.Text = "";
            TxtNum3.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e) {
            double verify1, verify2;

            if (double.TryParse(TxtNum1.Text, out verify1) && double.TryParse(TxtNum2.Text, out verify2)) {
                double resultado = verify1 - verify2;
                TxtNum3.Text = resultado.ToString("F2");
            }
            else
                MessageBox.Show("Um ou mais números incorretos!");
        }

        private void button1_Click(object sender, EventArgs e) {
            double verify1, verify2;

            if (double.TryParse(TxtNum1.Text, out verify1) && double.TryParse(TxtNum2.Text, out verify2)) {
                double resultado = verify1 * verify2;
                TxtNum3.Text = resultado.ToString("N2");
            }
            else
                MessageBox.Show("Um ou mais números incorretos!");
        }

        private void button4_Click(object sender, EventArgs e) {
            double verify1, verify2;

            if (double.TryParse(TxtNum1.Text, out verify1) && double.TryParse(TxtNum2.Text, out verify2)) {
                if (verify2 == 0)
                    MessageBox.Show("Divisão por Zero!");
                else {
                    double resultado = verify1 / verify2;
                    TxtNum3.Text = resultado.ToString("N2");
                }
            }
            else
                MessageBox.Show("Um ou mais números incorretos!");
        }
    }
}
