using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CustomYou.Materiais
{
    public partial class FormPedra : Form
    {
        public FormPedra()
        {
            InitializeComponent();

        }
        public void SelecionaCelula(Label lblNomeSelecionada,Label lblCustoSelecionada, string idSelecionado)
        {
            var labels = new List<Label> { lblPedra01, lblPedra02, lblPedra03, lblPedra04, lblPedra05, lblPedra06, lblPedra07, lblPedra08, lblPedra09,
            lblCustoPedra01,lblCustoPedra02,lblCustoPedra03,lblCustoPedra04,lblCustoPedra05,lblCustoPedra06,lblCustoPedra07,lblCustoPedra08,lblCustoPedra09};
      
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
            SelecionaCelula(lblPedra01,lblCustoPedra01,"Pedra01");
        }

        private void picParquet02_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblPedra02, lblCustoPedra02, "Pedra02");
        }

        private void picParquet03_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblPedra03, lblCustoPedra03, "Pedra03");
        }

        private void picParquet04_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblPedra04, lblCustoPedra04, "Pedra04");
        }

        private void picParquet05_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblPedra05, lblCustoPedra05, "Pedra05");
        }
        private void picParquet06_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblPedra06, lblCustoPedra06, "Pedra06");
        }
        private void picParquet07_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblPedra07, lblCustoPedra07, "Pedra07");
        }

        private void picParquet08_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblPedra08, lblCustoPedra08, "Pedra08");
        }

        private void picParquet09_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblPedra09, lblCustoPedra09, "Pedra09");
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
