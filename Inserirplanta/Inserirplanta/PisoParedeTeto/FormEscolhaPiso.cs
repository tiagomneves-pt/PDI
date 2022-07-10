using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CustomYou.Materiais;

namespace CustomYou
{
    public partial class FormEscolhaPiso : Form
    {
        public FormEscolhaPiso()
        {
            InitializeComponent();
        }

        public string materialSelecionado { get; set; }
        public double valorFinal { get; set; }

        private void btnPisoLaminado_Click(object sender, EventArgs e)
        {

            using (var formPisoLaminado = new FormPisoLaminado())
            {
                var result = formPisoLaminado.ShowDialog();
                if (result == DialogResult.OK)
                {
                    valorFinal = formPisoLaminado.valorFinal;
                    materialSelecionado = formPisoLaminado.materialSelecionado;
                }
            }

            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnParquet_Click(object sender, EventArgs e)
        {
            using (var formParquet = new FormParquet())
            {
                var result = formParquet.ShowDialog();
                if (result == DialogResult.OK)
                {
                    valorFinal = formParquet.valorFinal;
                    materialSelecionado = formParquet.materialSelecionado;
                }
            }


            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnPedra_Click(object sender, EventArgs e)
        {
            using (var formPedra = new FormPedra())
            {
                var result = formPedra.ShowDialog();
                if (result == DialogResult.OK)
                {
                    valorFinal = formPedra.valorFinal;
                    materialSelecionado = formPedra.materialSelecionado;
                }
            }
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAlcatifa_Click(object sender, EventArgs e)
        {
            using (var formAlcatifa = new FormAlcatifa())
            {
                var result = formAlcatifa.ShowDialog();
                if (result == DialogResult.OK)
                {
                    valorFinal = formAlcatifa.valorFinal;
                    materialSelecionado = formAlcatifa.materialSelecionado;
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAzulejo_Click(object sender, EventArgs e)
        {
            using (var formAzulejo = new FormAzulejo())
            {
                var result = formAzulejo.ShowDialog();
                if (result == DialogResult.OK)
                {
                    valorFinal = formAzulejo.valorFinal;
                    materialSelecionado = formAzulejo.materialSelecionado;
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
    
}
