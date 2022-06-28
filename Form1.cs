using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC12___Aula_I___Calculadora_simples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblTITULO_Click(object sender, EventArgs e)
        {

        }

        private void btnCALC_Click(object sender, EventArgs e)
        {
            // Varíaveis para armazenar os valores nos campos:
            double n1 = 0;
            double n2 = 0;
            double resultado = 0;

            if (txtN1.Text != "" && txtN2.Text != "")
            {
                n1 = double.Parse(txtN1.Text);
                n2 = double.Parse(txtN2.Text);
            }

            resultado = ((n1 / n2) * n2);




            // Mostrar o valor no lbl "resultado"

            lblRESULTADO.Text = resultado.ToString();

            // O programa dará a situação da pessoa segundo o resultado de seu IMC.
            if (resultado <= 18.5)
            {
                lblClassificacao.Text = "Abaixo do peso";
            }
            else if (resultado >= 18.6 && resultado <= 24.9)
            {
                lblClassificacao.Text = "Peso Ideal";
            }
            else if (resultado >= 25.0 && resultado <= 29.9)
            {
                lblClassificacao.Text = "Levemente acima do peso";
            }
            else if (resultado >= 30.0 && resultado >= 34.9)
            {
                lblClassificacao.Text = "Obesidade grau I";

            }
            else if (resultado >= 35.0 && resultado <= 39.9)
            {
                lblClassificacao.Text = "Obesidade grau II";
            }
            else if (resultado >= 40.0)
            {
                lblClassificacao.Text = "Obesidade grau III";
            }


        }


    }
}
    

