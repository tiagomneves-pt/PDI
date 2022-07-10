using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CustomYou.Materiais
{
    public partial class FormPisoLaminado : Form
    {
        public FormPisoLaminado()
        {
            InitializeComponent();

        }

        public void SelecionaCelula(Label lblNomeSelecionada, Label lblCustoSelecionada, string idSelecionado)
        {
            var labels = new List<Label> { lblMadeira01, lblMadeira02,lblMadeira03,lblMadeira04,lblMadeira05,
                lblCustoMadeira01,lblCustoMadeira02,lblCustoMadeira03,lblCustoMadeira04,lblCustoMadeira05};

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

        private void FormPisoLaminado_Load(object sender, EventArgs e)
        {
            double horasPorMetro, horasEstimadas, areaDivisao;
            areaDivisao = Convert.ToDouble((lblAreaDivisao.Text).Remove(lblAreaDivisao.Text.Length - 2));

            horasPorMetro = 0.25;
            horasEstimadas = areaDivisao * horasPorMetro;
            lblHrsEstimadas.Text = Convert.ToString(horasEstimadas);
        }
        private void picMadeira01_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblMadeira01, lblCustoMadeira01, "PisoLaminado01");
        }

        private void picMadeira02_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblMadeira02, lblCustoMadeira02, "PisoLaminado02");
        }

        private void picMadeira03_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblMadeira03, lblCustoMadeira03, "PisoLaminado03");
        }

        private void picMadeira04_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblMadeira04, lblCustoMadeira04, "PisoLaminado04");
        }

        private void picMadeira05_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblMadeira05, lblCustoMadeira05, "PisoLaminado05");
        }
        private void lblCustoMaterial_TextChanged(object sender, EventArgs e)
        {
            string areaDivisao, custoMaterial, custoMOD, hrsEstimadas;
            double doubleAreaDiv, doubleCustoMat, doubleCustoMOD, doubleHrsEstimadas;

            areaDivisao = lblAreaDivisao.Text;
            custoMaterial = lblCustoMaterial.Text;
            custoMOD = lblCustoMOD.Text;
            hrsEstimadas = lblHrsEstimadas.Text;

            areaDivisao = areaDivisao.Remove(areaDivisao.Length - 2);
            custoMaterial = custoMaterial.Remove(custoMaterial.Length - 4);
            custoMOD = custoMOD.Remove(custoMOD.Length - 4);
            hrsEstimadas = hrsEstimadas.Remove(hrsEstimadas.Length - 3);
            
            doubleAreaDiv = Convert.ToDouble(areaDivisao);
            doubleCustoMat = Convert.ToDouble(custoMaterial);
            doubleCustoMOD = Convert.ToDouble(custoMOD);
            doubleHrsEstimadas = Convert.ToDouble(hrsEstimadas);

            lblCustoTotalDivisao.Text = Convert.ToString(doubleAreaDiv * doubleCustoMat * doubleCustoMOD * doubleHrsEstimadas);
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
