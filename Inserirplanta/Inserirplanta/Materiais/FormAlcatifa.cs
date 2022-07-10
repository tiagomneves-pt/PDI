using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CustomYou.Materiais
{
    public partial class FormAlcatifa : Form
    {
        public FormAlcatifa()
        {
            InitializeComponent();

        }
        public void SelecionaCelula(Label lblNomeSelecionada,Label lblCustoSelecionada, string idSelecionado)
        {
            //Este método recebe as labels do material selecionado e põe-nas a negrito. Atribui também o id do material selecionado
            var labels = new List<Label> { lblAlcatifa01, lblAlcatifa02, lblAlcatifa03, lblAlcatifa04, lblAlcatifa05, lblAlcatifa06, lblAlcatifa07, lblAlcatifa08, lblAlcatifa09,
            lblCustoAlcatifa01,lblCustoAlcatifa02,lblCustoAlcatifa03,lblCustoAlcatifa04,lblCustoAlcatifa05,lblCustoAlcatifa06,lblCustoAlcatifa07,lblCustoAlcatifa08,lblCustoAlcatifa09};
      
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
            //Cálculo das horas estimadas para a aplicação da alcatifa
            double horasPorMetro, horasEstimadas, areaDivisao;
            areaDivisao = Convert.ToDouble((lblAreaDivisao.Text).Remove(lblAreaDivisao.Text.Length - 2));

            horasPorMetro = 0.1;
            horasEstimadas = areaDivisao * horasPorMetro;
            lblHorasEstimadas.Text = Convert.ToString(horasEstimadas);
        }

        private void picParquet01_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblAlcatifa01,lblCustoAlcatifa01, "Alcatifa01");
        }

        private void picParquet02_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblAlcatifa02, lblCustoAlcatifa02, "Alcatifa02");
        }

        private void picParquet03_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblAlcatifa03, lblCustoAlcatifa03, "Alcatifa03");
        }

        private void picParquet04_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblAlcatifa04, lblCustoAlcatifa04, "Alcatifa04");
        }

        private void picParquet05_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblAlcatifa05, lblCustoAlcatifa05, "Alcatifa05");
        }
        private void picParquet06_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblAlcatifa06, lblCustoAlcatifa06, "Alcatifa06");
        }
        private void picParquet07_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblAlcatifa07, lblCustoAlcatifa07, "Alcatifa07");
        }

        private void picParquet08_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblAlcatifa08, lblCustoAlcatifa08, "Alcatifa08");
        }

        private void picParquet09_Click(object sender, EventArgs e)
        {
            SelecionaCelula(lblAlcatifa09, lblCustoAlcatifa09, "Alcatifa09");
        }

        private void lblCustoMaterial_TextChanged(object sender, EventArgs e)
        {
            //Cálculo do custo total consoante o material selecionado
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
            if(materialSelecionado != null)
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
