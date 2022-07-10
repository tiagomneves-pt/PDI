using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CustomYou.Materiais
{
    public partial class FormMosaico : Form
    {
        public FormMosaico()
        {
            InitializeComponent();

        }
        public void SelecionaCelula(Label lblNomeSelecionada,Label lblCustoSelecionada, string idSelecionado)
        {
            var labels = new List<Label> { lblMosaico01, lblMosaico02, lblMosaico03, lblMosaico04, lblMosaico05, lblMosaico06, lblMosaico07, lblMosaico08, lblMosaico09,
            lblCustoMosaico01,lblCustoMosaico02,lblCustoMosaico03,lblCustoMosaico04,lblCustoMosaico05,lblCustoMosaico06,lblCustoMosaico07,lblCustoMosaico08,lblCustoMosaico09};
      
            foreach (var label in labels)
            {
                label.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            }
         
            lblNomeSelecionada.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblCustoSelecionada.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblCustoMaterial.Text = lblCustoSelecionada.Text;
            materialSelecionado = idSelecionado;
        }
       
        public string materialSelecionado { get; set; }
        public double valorFinal { get; set; }

        private void FormParquet_Load(object sender, EventArgs e)
        {
            double horasPorMetro, horasEstimadas, areaDivisao;
            areaDivisao = Convert.ToDouble((lblAreaDivisao.Text).Remove(lblAreaDivisao.Text.Length - 2));

            horasPorMetro = 0.25;
            horasEstimadas = areaDivisao * horasPorMetro;
            lblHorasEstimadas.Text = Convert.ToString(horasEstimadas);
        }

        private void picParquet01_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblMosaico01,lblCustoMosaico01, "Mosaico01");
        }

        private void picParquet02_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblMosaico02, lblCustoMosaico02, "Mosaico02");
        }

        private void picParquet03_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblMosaico03, lblCustoMosaico03, "Mosaico03");
        }

        private void picParquet04_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblMosaico04, lblCustoMosaico04, "Mosaico04");
        }

        private void picParquet05_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblMosaico05, lblCustoMosaico05, "Mosaico05");
        }
        private void picParquet06_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblMosaico06, lblCustoMosaico06, "Mosaico06");
        }
        private void picParquet07_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblMosaico07, lblCustoMosaico07, "Mosaico07");
        }

        private void picParquet08_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblMosaico08, lblCustoMosaico08, "Mosaico08");
        }

        private void picParquet09_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblMosaico09, lblCustoMosaico09, "Mosaico09");
        }

        private void lblCustoMaterial_TextChanged(object sender, EventArgs e)
        {
            string areaDivisao, custoMaterial, custoMOD;
            double doubleAreaDiv, doubleCustoMat, doubleCustoMOD;

            areaDivisao = lblAreaDivisao.Text;
            custoMaterial = lblCustoMaterial.Text;
            custoMOD = lblCustoMOD.Text;

            areaDivisao = areaDivisao.Remove(areaDivisao.Length - 2);
            custoMaterial = custoMaterial.Remove(custoMaterial.Length - 4);
            custoMOD = custoMOD.Remove(custoMOD.Length - 4);
            
            doubleAreaDiv = Convert.ToDouble(areaDivisao);
            doubleCustoMat = Convert.ToDouble(custoMaterial);
            doubleCustoMOD = Convert.ToDouble(custoMOD);

            lblCustoTotalDivisao.Text = Convert.ToString(doubleAreaDiv * doubleCustoMat * doubleCustoMOD);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (materialSelecionado != null)
            {
                string stringValorFinal = lblCustoTotalDivisao.Text;
                valorFinal = Convert.ToDouble(stringValorFinal);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Tem que escolher o material", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


    }
}
