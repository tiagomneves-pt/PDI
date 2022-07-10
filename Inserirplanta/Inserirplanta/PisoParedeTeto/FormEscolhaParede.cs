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
    public partial class FormEscolhaParede : Form
    {
        public FormEscolhaParede()
        {
            InitializeComponent();
        }

        public string materialSelecionado { get; set; }
        public double valorFinal { get; set; }

        private void btnTinta_Click(object sender, EventArgs e)
        {
            using (var formTinta = new FormTinta())
            {
                var result = formTinta.ShowDialog();
                if (result == DialogResult.OK)
                {
                    valorFinal = formTinta.valorFinal;
                    materialSelecionado = formTinta.materialSelecionado;
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            valorFinal = 1500; //Valor fictício e não contabiliza a área das paredes. A aguardar compatibilidade com a BD
            materialSelecionado = "PapelParede";
            
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

        private void btnMosaico_Click(object sender, EventArgs e)
        {

            using (var formMosaico = new FormMosaico())
            {
                var result = formMosaico.ShowDialog();
                if (result == DialogResult.OK)
                {
                    valorFinal = formMosaico.valorFinal;
                    materialSelecionado = formMosaico.materialSelecionado;
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
    
}
