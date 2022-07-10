using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CustomYou.Materiais;
using CustomYou;
using Inserirplanta;
using System.Data.SqlClient;
using System.IO;
using System.Diagnostics;
using System.Globalization;



namespace CustomYou
{
    public partial class FormEscolhaMaterial : Form //TODO: Trocar os valores pré-definidos por valores introduzidos na BD
    {

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\ISCAC\3ANO2SEMESTRE\PDI\projeto\Inserirplanta\Inserirplanta\Database2.mdf;Integrated Security=True;Connect Timeout=30");

        public static List<double> area = new List<double>();
        public static List<int> ID = new List<int>();
        string materialSelecionado = "";
        string iddiv = "";
        string piso = "";
        string parede = "";
        string teto = "";
        double precoDiv;

        public FormEscolhaMaterial()
        {
            InitializeComponent();
            
            //ir buscar o id_div
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT id_div FROM obra_div WHERE id_obra = '"+MenuInserirPlanta.obra+"'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                iddiv = reader[0].ToString();
                int id = Convert.ToInt32(iddiv);
                ID.Add(id);
            }
            conn.Close();
            


            area = MenuInserirPlanta.areadiv;

            /*
            //colocar na cbDivisao o id_div
            int id_divIN = Convert.ToInt32(iddiv);
            conn.Open();
            SqlCommand cmd2;
            SqlDataReader dr;
            cmd2 = new SqlCommand("SELECT num_divisao FROM Divisao WHERE id_div = '"+ iddiv +"'", conn);
            dr = cmd2.ExecuteReader();
            while (dr.Read())
            {
                cbDivisao.Items.Add(dr[0].ToString());
            }
            dr.Close();
            */
            
        }

        private int AssociarNomeDiv(int numIndexSelecionado)
        {
            int i = numIndexSelecionado;
            ID.ToArray();
            return ID[i];
        }

        public void SomaCustosDivisao(string custoPiso, string custoParedes, string custoTeto) 
        {
            //Este método calcula e expõe o custo total do orçamento consoante os materiais selecionados
            double dCustoPiso, dCustoParedes, dCustoTeto;
            float orbase;
            orbase = MenuInserirPlanta.orcBase;
            custoPiso = lblCustoPiso.Text;
            custoParedes = lblCustoParedes.Text;
            custoTeto = lblCustoTeto.Text;

            dCustoPiso = Convert.ToDouble(custoPiso.Remove(custoPiso.Length-1));
            dCustoParedes = Convert.ToDouble(custoParedes.Remove(custoParedes.Length - 1));
            dCustoTeto = Convert.ToDouble(custoTeto.Remove(custoTeto.Length - 1));

            lblOrcamentoTotal.Text = Convert.ToString(dCustoPiso + dCustoParedes + dCustoTeto + orbase) + '€';

            ocamentoDiv = Convert.ToDouble(dCustoPiso + dCustoParedes + dCustoTeto);
            precoDiv = ocamentoDiv;
            orcDiv.Text = Convert.ToString(precoDiv);
            //inserir o total nd bd
        }
        

        private void btnPiso_Click(object sender, EventArgs e)
        {
            using (var formEscolhaPiso = new FormEscolhaPiso())
            {
                var result = formEscolhaPiso.ShowDialog();
                if (result == DialogResult.OK)
                {
                    double valorTotalPiso = formEscolhaPiso.valorFinal;
                    string materialSelecionado = formEscolhaPiso.materialSelecionado;

                    lblCustoPiso.Text = Convert.ToString(valorTotalPiso) + '€';
                    switch (materialSelecionado) //código esparguete pouco escalável. TODO: criar um método que receba o mat. selecionado e procure a imagem correspondente
                    {
                        case "PisoLaminado01":
                            this.btnPiso.BackgroundImage = CustomYou.Properties.Resources.Madeira01;
                            break;
                        case "PisoLaminado02":
                            this.btnPiso.BackgroundImage = CustomYou.Properties.Resources.Madeira02;
                            break;
                        case "PisoLaminado03":
                            this.btnPiso.BackgroundImage = CustomYou.Properties.Resources.Madeira03;
                            break;
                        case "PisoLaminado04":
                            this.btnPiso.BackgroundImage = CustomYou.Properties.Resources.Madeira04;
                            break;
                        case "PisoLaminado05":
                            this.btnPiso.BackgroundImage = CustomYou.Properties.Resources.Madeira06;
                            break;
                        case "Parquet01":
                            this.btnPiso.BackgroundImage = CustomYou.Properties.Resources.Parquet01;
                            break;
                        case "Parquet02":
                            this.btnPiso.BackgroundImage = CustomYou.Properties.Resources.Parquet02;
                            break;
                        case "Parquet03":
                            this.btnPiso.BackgroundImage = CustomYou.Properties.Resources.Parquet03;
                            break;
                        case "Parquet04":
                            this.btnPiso.BackgroundImage = CustomYou.Properties.Resources.Parquet04;
                            break;
                        case "Parquet05":
                            this.btnPiso.BackgroundImage = CustomYou.Properties.Resources.ParquetExot01;
                            break;
                        case "Parquet06":
                            this.btnPiso.BackgroundImage = CustomYou.Properties.Resources.ParquetExot02;
                            break;
                        case "Parquet07":
                            this.btnPiso.BackgroundImage = CustomYou.Properties.Resources.ParquetExot03;
                            break;
                        case "Parquet08":
                            this.btnPiso.BackgroundImage = CustomYou.Properties.Resources.ParquetExot04;
                            break;
                        case "Parquet09":
                            this.btnPiso.BackgroundImage = CustomYou.Properties.Resources.ParquetExot05;
                            break;
                        case "Pedra01":
                            this.btnPiso.BackgroundImage = CustomYou.Properties.Resources.Marmore01;
                            break;
                        case "Pedra02":
                            this.btnPiso.BackgroundImage = CustomYou.Properties.Resources.Marmore02;
                            break;
                        case "Pedra03":
                            this.btnPiso.BackgroundImage = CustomYou.Properties.Resources.Marmore03;
                            break;
                        case "Pedra04":
                            this.btnPiso.BackgroundImage = CustomYou.Properties.Resources.Marmore04;
                            break;
                        case "Pedra05":
                            this.btnPiso.BackgroundImage = CustomYou.Properties.Resources.Marmore05;
                            break;
                        case "Pedra06":
                            this.btnPiso.BackgroundImage = CustomYou.Properties.Resources.Porcelana01;
                            break;
                        case "Pedra07":
                            this.btnPiso.BackgroundImage = CustomYou.Properties.Resources.Porcelana02;
                            break;
                        case "Pedra08":
                            this.btnPiso.BackgroundImage = CustomYou.Properties.Resources.Porcelana03;
                            break;
                        case "Pedra09":
                            this.btnPiso.BackgroundImage = CustomYou.Properties.Resources.Porcelana04;
                            break;
                        case "Alcatifa01":
                            this.btnPiso.BackgroundImage = CustomYou.Properties.Resources.Alcatifa01;
                            break;
                        case "Alcatifa02":
                            this.btnPiso.BackgroundImage = CustomYou.Properties.Resources.Alcatifa02;
                            break;
                        case "Alcatifa03":
                            this.btnPiso.BackgroundImage = CustomYou.Properties.Resources.Alcatifa03;
                            break;
                        case "Alcatifa04":
                            this.btnPiso.BackgroundImage = CustomYou.Properties.Resources.Alcatifa04;
                            break;
                        case "Alcatifa05":
                            this.btnPiso.BackgroundImage = CustomYou.Properties.Resources.Alcatifa05;
                            break;
                        case "Alcatifa06":
                            this.btnPiso.BackgroundImage = CustomYou.Properties.Resources.Alcatifa06;
                            break;
                        case "Alcatifa07":
                            this.btnPiso.BackgroundImage = CustomYou.Properties.Resources.Alcatifa07;
                            break;
                        case "Alcatifa08":
                            this.btnPiso.BackgroundImage = CustomYou.Properties.Resources.Alcatifa08;
                            break;
                        case "Alcatifa09":
                            this.btnPiso.BackgroundImage = CustomYou.Properties.Resources.AlcatifaVariada;
                            break;
                        case "Azulejo01":
                            this.btnPiso.BackgroundImage = CustomYou.Properties.Resources.Azulejo01;
                            break;
                        case "Azulejo02":
                            this.btnPiso.BackgroundImage = CustomYou.Properties.Resources.Azulejo02;
                            break;
                        case "Azulejo03":
                            this.btnPiso.BackgroundImage = CustomYou.Properties.Resources.Azulejo03;
                            break;
                        case "Azulejo04":
                            this.btnPiso.BackgroundImage = CustomYou.Properties.Resources.Azulejo04;
                            break;
                        case "Azulejo05":
                            this.btnPiso.BackgroundImage = CustomYou.Properties.Resources.Azulejo05;
                            break;
                        case "Azulejo06":
                            this.btnPiso.BackgroundImage = CustomYou.Properties.Resources.Azulejo06;
                            break;
                        case "Azulejo07":
                            this.btnPiso.BackgroundImage = CustomYou.Properties.Resources.Azulejo07;
                            break;
                        case "Azulejo08":
                            this.btnPiso.BackgroundImage = CustomYou.Properties.Resources.Azulejo08;
                            break;
                        case "Azulejo09":
                            this.btnPiso.BackgroundImage = CustomYou.Properties.Resources.Azulejo09;
                            break;
                        default:
                            break;

                    }
                    piso = materialSelecionado;
                }
            }

        }

        private void btnParedes_Click(object sender, EventArgs e)
        {
            using (var formEscolhaParede = new FormEscolhaParede())
            {
                var result = formEscolhaParede.ShowDialog();
                if (result == DialogResult.OK)
                {
                    double valorTotalParedes = formEscolhaParede.valorFinal;
                    string materialSelecionado = formEscolhaParede.materialSelecionado;

                    lblCustoParedes.Text = Convert.ToString(valorTotalParedes) + '€';
                    switch (materialSelecionado) //código esparguete pouco escalável. TODO: criar um método que receba o mat. selecionado e procure a imagem correspondente
                    {
                        case "Tinta01":
                            this.btnParedes.BackgroundImage = null;
                            this.btnParedes.BackColor = Color.White;
                            this.btnParedes.ForeColor = Color.Black;
                            break;
                        case "Tinta02":
                            this.btnParedes.BackgroundImage = null;
                            this.btnParedes.BackColor = Color.Black;
                            this.btnParedes.ForeColor = Color.White;
                            break;
                        case "Tinta03":
                            this.btnParedes.BackgroundImage = null;
                            this.btnParedes.BackColor = Color.Silver;
                            this.btnParedes.ForeColor = Color.Black;
                            break;
                        case "Tinta04":
                            this.btnParedes.BackgroundImage = null;
                            this.btnParedes.BackColor = Color.Bisque;
                            this.btnParedes.ForeColor = Color.Black;
                            break;
                        case "Tinta05":
                            this.btnParedes.BackgroundImage = null;
                            this.btnParedes.BackColor = Color.Azure;
                            this.btnParedes.ForeColor = Color.Black;
                            break;
                        case "Tinta06":
                            this.btnParedes.BackgroundImage = null;
                            this.btnParedes.BackColor = Color.DarkRed;
                            this.btnParedes.ForeColor = Color.White;
                            break;
                        case "Tinta07":
                            this.btnParedes.BackgroundImage = null;
                            this.btnParedes.BackColor = Color.Chocolate;
                            this.btnParedes.ForeColor = Color.Black;
                            break;
                        case "Tinta08":
                            this.btnParedes.BackgroundImage = null;
                            this.btnParedes.BackColor = Color.PaleGreen;
                            this.btnParedes.ForeColor = Color.Black;
                            break;
                        case "Tinta09":
                            this.btnParedes.BackgroundImage = null;
                            this.btnParedes.BackgroundImage = CustomYou.Properties.Resources.TintaOutro;
                            this.btnParedes.ForeColor = Color.Black;
                            break;
                        case "PapelParede":
                            this.btnParedes.BackgroundImage = CustomYou.Properties.Resources.PapelParede;
                            break;
                        case "Azulejo01":
                            this.btnParedes.BackgroundImage = CustomYou.Properties.Resources.Azulejo01;
                            break;
                        case "Azulejo02":
                            this.btnParedes.BackgroundImage = CustomYou.Properties.Resources.Azulejo02;
                            break;
                        case "Azulejo03":
                            this.btnParedes.BackgroundImage = CustomYou.Properties.Resources.Azulejo03;
                            break;
                        case "Azulejo04":
                            this.btnParedes.BackgroundImage = CustomYou.Properties.Resources.Azulejo04;
                            break;
                        case "Azulejo05":
                            this.btnParedes.BackgroundImage = CustomYou.Properties.Resources.Azulejo05;
                            break;
                        case "Azulejo06":
                            this.btnParedes.BackgroundImage = CustomYou.Properties.Resources.Azulejo06;
                            break;
                        case "Azulejo07":
                            this.btnParedes.BackgroundImage = CustomYou.Properties.Resources.Azulejo07;
                            break;
                        case "Azulejo08":
                            this.btnParedes.BackgroundImage = CustomYou.Properties.Resources.Azulejo08;
                            break;
                        case "Azulejo09":
                            this.btnParedes.BackgroundImage = CustomYou.Properties.Resources.Azulejo09;
                            break;
                        case "Mosaico01":
                            this.btnParedes.BackgroundImage = CustomYou.Properties.Resources.Mosaico01;
                            break;
                        case "Mosaico02":
                            this.btnParedes.BackgroundImage = CustomYou.Properties.Resources.Mosaico02;
                            break;
                        case "Mosaico03":
                            this.btnParedes.BackgroundImage = CustomYou.Properties.Resources.Mosaico03;
                            break;
                        case "Mosaico04":
                            this.btnParedes.BackgroundImage = CustomYou.Properties.Resources.Mosaico04_;
                            break;
                        case "Mosaico05":
                            this.btnParedes.BackgroundImage = CustomYou.Properties.Resources.Mosaico05;
                            break;
                        case "Mosaico06":
                            this.btnParedes.BackgroundImage = CustomYou.Properties.Resources.Mosaico06;
                            break;
                        case "Mosaico07":
                            this.btnParedes.BackgroundImage = CustomYou.Properties.Resources.MosaicoPremium01;
                            break;
                        case "Mosaico08":
                            this.btnParedes.BackgroundImage = CustomYou.Properties.Resources.MosaicoPremium04;
                            break;
                        case "Mosaico09":
                            this.btnParedes.BackgroundImage = CustomYou.Properties.Resources.MosaicoPremium05;
                            break;
                        default:
                            break;

                    }
                    parede = materialSelecionado;
                }
        }
    }

        private void btnTeto_Click(object sender, EventArgs e)
        {
            using (var formEscolhaTeto = new FormTinta())
            {
                var result = formEscolhaTeto.ShowDialog();
                if (result == DialogResult.OK)
                {
                    double valorTotalTeto = formEscolhaTeto.valorFinal;
                    string materialSelecionado = formEscolhaTeto.materialSelecionado;

                    lblCustoTeto.Text = Convert.ToString(valorTotalTeto) + '€';
                    switch (materialSelecionado) //código esparguete pouco escalável. TODO: criar um método que receba o mat. selecionado e procure a imagem correspondente
                    {
                        case "Tinta01":
                            this.btnTeto.BackgroundImage = null;
                            this.btnTeto.BackColor = Color.White;
                            this.btnTeto.ForeColor = Color.Black;
                            break;
                        case "Tinta02":
                            this.btnTeto.BackgroundImage = null;
                            this.btnTeto.BackColor = Color.Black;
                            this.btnTeto.ForeColor = Color.White;
                            break;
                        case "Tinta03":
                            this.btnTeto.BackgroundImage = null;
                            this.btnTeto.BackColor = Color.Silver;
                            this.btnTeto.ForeColor = Color.Black;
                            break;
                        case "Tinta04":
                            this.btnTeto.BackgroundImage = null;
                            this.btnTeto.BackColor = Color.Bisque;
                            this.btnTeto.ForeColor = Color.Black;
                            break;
                        case "Tinta05":
                            this.btnTeto.BackgroundImage = null;
                            this.btnTeto.BackColor = Color.Azure;
                            this.btnTeto.ForeColor = Color.Black;
                            break;
                        case "Tinta06":
                            this.btnTeto.BackgroundImage = null;
                            this.btnTeto.BackColor = Color.DarkRed;
                            this.btnTeto.ForeColor = Color.White;
                            break;
                        case "Tinta07":
                            this.btnTeto.BackgroundImage = null;
                            this.btnTeto.BackColor = Color.Chocolate;
                            this.btnTeto.ForeColor = Color.Black;
                            break;
                        case "Tinta08":
                            this.btnTeto.BackgroundImage = null;
                            this.btnTeto.BackColor = Color.PaleGreen;
                            this.btnTeto.ForeColor = Color.Black;
                            break;
                        case "Tinta09":
                            this.btnTeto.BackgroundImage = null;
                            this.btnTeto.BackgroundImage = CustomYou.Properties.Resources.TintaOutro;
                            this.btnTeto.ForeColor = Color.Black;
                            break;
                    }
                    teto = materialSelecionado;

                }
            }
        }
        private void tbNomeDivisao_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void cbDivisao_SelectedIndexChanged(object sender, EventArgs e)
        {

            btnPiso.BackgroundImage = null;
            btnParedes.BackgroundImage = null;
            btnTeto.BackgroundImage = null;
            btnTeto.BackColor = default(Color);
            lblCustoPiso.Text = "0,00€";
            lblCustoParedes.Text = "0,00€";
            lblCustoTeto.Text = "0,00€";


            cbDivisao.ForeColor = Color.Black;
            for (int i = 0; i <= Convert.ToInt32(cbDivisao.SelectedIndex); i++)
            {
                lblMetrosQuadrados.Text  = area[i].ToString();
            }

            conn.Open();
            SqlCommand cmddd = new SqlCommand("SELECT nome_div FROM Divisao WHERE id_div = '" + AssociarNomeDiv(cbDivisao.SelectedIndex) + "'", conn);
            SqlDataReader readerNomeDiv = cmddd.ExecuteReader();
            if (readerNomeDiv.Read())
            {
                textBox1.Text = readerNomeDiv[0].ToString();
            }
            conn.Close();

            conn.Open();
            SqlCommand cmddde = new SqlCommand("SELECT valor_div FROM Divisao WHERE id_div = '" + AssociarNomeDiv(cbDivisao.SelectedIndex) + "'" , conn);
            SqlDataReader readerPrecoDiv = cmddde.ExecuteReader();
            if (readerPrecoDiv.Read())
            {
                orcDiv.Text = readerPrecoDiv[0].ToString();
            }
            conn.Close();



        }

        private void lblCustoPiso_TextChanged(object sender, EventArgs e)
        {
            SomaCustosDivisao(lblCustoPiso.Text, lblCustoParedes.Text, lblCustoTeto.Text);
        }

        private void lblCustoParedes_TextChanged(object sender, EventArgs e)
        {
            SomaCustosDivisao(lblCustoPiso.Text, lblCustoParedes.Text, lblCustoTeto.Text);
        }

        private void lblCustoTeto_TextChanged(object sender, EventArgs e)
        {
            SomaCustosDivisao(lblCustoPiso.Text, lblCustoParedes.Text, lblCustoTeto.Text);
        }


        private void FormEscolhaMaterial_Load(object sender, EventArgs e)
        {
            string nome;
            nome = MenuInserirPlanta.nomeconst;
            lblNomeObra.Text = nome;
            pictureBox1.Load(MenuInserirPlanta.image);
            lblOrcamentoTotal.Text = Convert.ToString(MenuInserirPlanta.orcBase);
            //inserir orcamento final na bd
            SqlCommand cmd4 = conn.CreateCommand();
            cmd4.CommandText = "UPDATE Obra SET orcamento_final = '"+ lblOrcamentoTotal.Text +"' WHERE nome_obra = '"+nome+"'";
            Debug.WriteLine(cmd4.CommandText);
            conn.Open();
            cmd4.ExecuteNonQuery();
            conn.Close();
            int n_div = MenuInserirPlanta.ndiv;
            for (int i = 1; i < n_div + 1; i++)
            {
                cbDivisao.Items.Add(i);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMain newForm = new FormMain();
            newForm.Show();
            this.Close();
        }

        
        double ocamentoDiv;
        private void guardar_Click(object sender, EventArgs e)
        {
            
            //inserir o nome mas podemos meter td junto depois
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Tem que dar a nome à sua Divisão!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int iddadiv = AssociarNomeDiv(cbDivisao.SelectedIndex);
                Debug.WriteLine(iddadiv);
                SqlCommand cmd233 = conn.CreateCommand();
                cmd233.CommandText = "UPDATE Divisao SET nome_div = '" + textBox1.Text + "' WHERE  id_div ='"+ iddadiv+ "'";
                conn.Open();
                cmd233.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Nome da divisão guardado", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                orcDiv.Text = Convert.ToString(ocamentoDiv);

                SqlCommand cmd2333 = conn.CreateCommand();
                cmd2333.CommandText = "UPDATE Divisao SET valor_div = '" + orcDiv.Text + "' WHERE  id_div ='" + iddadiv + "'";
                conn.Open();
                cmd2333.ExecuteNonQuery();
                conn.Close();

            }
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

 
        }

        private void lblOrcamentoTotal_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
