using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CustomYou.Materiais
{
    public partial class FormAzulejo : Form
    {
        public FormAzulejo()
        {
            InitializeComponent();

        }
        public void SelecionaCelula(Label lblNomeSelecionada,Label lblCustoSelecionada, string idSelecionado)
        {
            var labels = new List<Label> { lblAzulejo01, lblAzulejo02, lblAzulejo03, lblAzulejo04, lblAzulejo05, lblAzulejo06, lblAzulejo07, lblAzulejo08, lblAzulejo09,
            lblCustoParquet01,lblCustoParquet02,lblCustoParquet03,lblCustoParquet04,lblCustoParquet05,lblCustoParquet06,lblCustoParquet07,lblCustoParquet08,lblCustoParquet09};
      
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
            SelecionaCelula(lblAzulejo01,lblCustoParquet01, "Azulejo01");
        }

        private void picParquet02_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblAzulejo02, lblCustoParquet02, "Azulejo02");
        }

        private void picParquet03_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblAzulejo03, lblCustoParquet03, "Azulejo03");
        }

        private void picParquet04_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblAzulejo04, lblCustoParquet04, "Azulejo04");
        }

        private void picParquet05_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblAzulejo05, lblCustoParquet05, "Azulejo05");
        }
        private void picParquet06_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblAzulejo06, lblCustoParquet06, "Azulejo06");
        }
        private void picParquet07_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblAzulejo07, lblCustoParquet07, "Azulejo07");
        }

        private void picParquet08_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblAzulejo08, lblCustoParquet08, "Azulejo08");
        }

        private void picParquet09_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblAzulejo09, lblCustoParquet09, "Azulejo09");
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

        private void lblPiso_Click(object sender, EventArgs e)
        {

        }
    }
}
