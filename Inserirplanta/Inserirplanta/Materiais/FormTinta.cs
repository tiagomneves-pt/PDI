using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CustomYou.Materiais
{
    public partial class FormTinta : Form
    {
        public FormTinta()
        {
            InitializeComponent();

        }
        public void SelecionaCelula(Label lblNomeSelecionada,Label lblCustoSelecionada, string idSelecionado)
        {
            var labels = new List<Label> { lblTinta01, lblTinta02, lblTinta03, lblTinta04, lblTinta05, lblTinta06, lblTinta07, lblTinta08, lblTinta09,
            lblCustoTinta01,lblCustoTinta02,lblCustoTinta03,lblCustoTinta04,lblCustoTinta05,lblCustoTinta06,lblCustoTinta07,lblCustoTinta08,lblCustoTinta09};
      
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

        private void picTinta01_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblTinta01,lblCustoTinta01, "Tinta01");
        }

        private void picTinta02_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblTinta02, lblCustoTinta02, "Tinta02");
        }

        private void picTinta03_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblTinta03, lblCustoTinta03, "Tinta03");
        }

        private void picTinta04_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblTinta04, lblCustoTinta04, "Tinta04");
        }

        private void picTinta05_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblTinta05, lblCustoTinta05, "Tinta05");
        }
        private void picTinta06_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblTinta06, lblCustoTinta06, "Tinta06");
        }
        private void picTinta07_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblTinta07, lblCustoTinta07, "Tinta07");
        }

        private void picTinta08_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblTinta08, lblCustoTinta08, "Tinta08");
        }

        private void picTinta09_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblTinta09, lblCustoTinta09, "Tinta09");
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
