using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using Microsoft.Scripting;
using System.IO;
using System.Diagnostics;
using CustomYou;
using System.Data.SqlClient;
using System.Globalization;

namespace Inserirplanta
{

    public partial class MenuInserirPlanta : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\ISCAC\3ANO2SEMESTRE\PDI\projeto\Inserirplanta\Inserirplanta\Database2.mdf;Integrated Security=True;Connect Timeout=30");

        bool jaMeteuPlanta = false;
        
        String imageLocation = "";
        public MenuInserirPlanta()
        {

            InitializeComponent();

        }
        public static string nomeconst;
        public static String image;
        public static float orcBase;
        public static int obra;
        public static int ndiv;
        public static List<double> areadiv = new List<double>();
        public static string plantaloc = "";
        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    planta.ImageLocation = imageLocation;
                    Debug.WriteLine(imageLocation);
                    string fullPath = @"C:\Users\User\Desktop\ISCAC\3ANO2SEMESTRE\PDI\projeto\imagemselecionada.txt";
                    using (StreamWriter writer = new StreamWriter(fullPath))
                    {
                        writer.WriteLine(imageLocation);
                        image = imageLocation;
                        plantaloc = imageLocation;
                    }
                    jaMeteuPlanta = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool  analisar = false;
        private void bntAnalisar(object sender, EventArgs e)
        {          
            if (nomeconstrucao.Text.Length == 0)
            {
                MessageBox.Show("Tem que dar um nome à obra!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
                                
            if (jaMeteuPlanta)
            {
                //Debug.WriteLine("ENTROU NO IF");
                Process p = new Process();
                ProcessStartInfo start = new ProcessStartInfo();
                start.FileName = @"C:\Users\User\AppData\Local\Programs\Python\Python310\python.exe";
                start.Arguments = string.Format("{0} {1}", @"C:\Users\User\Desktop\ISCAC\3ANO2SEMESTRE\PDI\projeto\lerparedes.py", "");
                start.UseShellExecute = false;
                start.RedirectStandardOutput = true;

                p.StartInfo = new ProcessStartInfo(@"C:\Users\User\AppData\Local\Programs\Python\Python310\python.exe", @"C:\Users\User\Desktop\ISCAC\3ANO2SEMESTRE\PDI\projeto\lerparedes.py")
                {
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                p.Start();

                string output = p.StandardOutput.ReadToEnd();
                string outputError = p.StandardError.ReadToEnd();

                p.WaitForExit();
                Debug.WriteLine("Output Error: \n" + outputError);
                Debug.WriteLine("python output: \n" + output);
               
                string divisaoString = "";
                string totalString = "";
                string num_div = "";

                string[] stringSeparators = new string[] { "\r\n" };
                string[] lines = output.Split(stringSeparators, StringSplitOptions.None);

                bool ler_total = false;
                int linhas_lidas = 0;

                foreach (string line in lines)
                {
                    if (line.Contains("numero de divisoes"))
                    {
                        num_div = line.Replace("numero de divisoes: ", "");
                        continue;
                    }
                    if (line.Contains("Área Total:"))
                    {
                        ler_total = true;
                        totalString += line + "\n";
                        linhas_lidas++;
                    }
                    else
                    {
                        if (ler_total)
                        {
                            if (linhas_lidas < 3)
                            {
                                totalString += line + "\n";
                                linhas_lidas++;
                            }
                            else
                            {
                                ler_total = false;
                            }
                        }
                        else
                        {
                            divisaoString += line + "\n";
                        }
                    }
                }

                lblresAreaTotal.Text = totalString;
                lblresAreaTotal.Show();

                lblResDivisoesDetetadas.Text = num_div;
                lblResDivisoesDetetadas.Show();

                txtBoxAreaPDivisao.Text = divisaoString;
                txtBoxAreaPDivisao.Show();
                txtBoxAreaPDivisao.ReadOnly = true;

                int n_div = Convert.ToInt32(num_div);
                //Debug.WriteLine(n_div);

                string dadosPDivisao = divisaoString;
             
                var removerCarateres = new string[] { " ", "Á", "r", "e", "a", ":", "P", "i", "m", "t", "D", "ã", "v", "s", "o"};

                foreach (var c in removerCarateres)
                {
                    dadosPDivisao = dadosPDivisao.Replace(c, string.Empty);
                }

                dadosPDivisao = dadosPDivisao.Replace('.', ',');
                Debug.WriteLine(dadosPDivisao);
                string id = "", idobra = "", iddiv = "";
                string nome;
                nome = Entrar.idutilizador;

                //buscar id do cliente
                conn.Open();
                SqlCommand ab = new SqlCommand("SELECT id_Cliente FROM Cliente WHERE email = '" + nome + "' ", conn);
                SqlDataReader reader1 = ab.ExecuteReader();
                Debug.WriteLine(ab);

                if (reader1.Read())
                {
                    id = reader1[0].ToString();
                }
                conn.Close();

                // Apagar palavras do output deixando so numeros

                string totalStringFloat = totalString;
                var charsToRemove = new string[] { " ", "Á", "r", "e", "a", "T", "o", "l", "P", "i", "m", ":", "t" };

                foreach (var c in charsToRemove)
                {
                    totalStringFloat = totalStringFloat.Replace(c, string.Empty);
                }

                //Separar valores da area e perimetro em variaveis diferentes

                var splittedString = totalStringFloat.Split('\n');
                string areaTotal = splittedString[0];
                string perimetroTotal = splittedString[1];

                areaTotal = areaTotal.Replace('.', ',');
                perimetroTotal = perimetroTotal.Replace('.', ',');

                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT nome_uti FROM Cliente WHERE email = '" + nome + "' ", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblUtilizador.Text = reader[0].ToString();

                }
                conn.Close();

                //float orcBase = 0;
                float areaTotall = float.Parse(areaTotal);
                orcBase = n_div * 3000 + areaTotall * 50;
                txtOrcBase.Text = Convert.ToString(orcBase);
                

                SqlCommand cmd4 = conn.CreateCommand();
                cmd4.CommandText = "INSERT INTO Obra (area_total, nome_obra, morada, id_Cliente, orcamento_base, orcamento_final, planta, altura) VALUES ('" + areaTotal + "', '" + nomeconstrucao.Text + "', '" + txtMorada.Text + "', '" + id + "', '" + orcBase + "','" + orcBase + "', '"+ plantaloc+ "', '"+ numAltura.Value + "')";
                Debug.WriteLine(cmd4.CommandText);
                conn.Open();
                cmd4.ExecuteNonQuery();
                conn.Close();

                //buscar o id da obra
                conn.Open();
                SqlCommand abc = new SqlCommand("SELECT id_obra FROM Obra WHERE id_cliente = '" + id + "' AND nome_obra = '"+ nomeconstrucao.Text + "' AND morada = '"+ txtMorada.Text + "'", conn);
                SqlDataReader reader5 = abc.ExecuteReader();
                Debug.WriteLine(abc);

                if (reader5.Read())
                {
                    idobra = reader5[0].ToString();
                    obra = Convert.ToInt32(idobra);
                }
                conn.Close();

                ndiv = n_div;

                for (int j = 0; j < n_div; j++) { 
               
                    var divisao = dadosPDivisao.Split('\n');

                    int i = j * 3;
                    string div = divisao[i];
                    string area = divisao[i+1];
                    string perimetro = divisao[i+2];
                    double areaaa = Convert.ToDouble(area);
                    areadiv.Add(areaaa);

                    SqlCommand cmd1 = conn.CreateCommand();
                    cmd1.CommandText = "INSERT INTO Divisao (area_div, num_divisao, perimetro_div, nome_div) VALUES ('"+ area + "', '" + (j + 1) + "', '" + perimetro + "', 'Divisão " + (j + 1) + "') ";
                    Debug.WriteLine(cmd1.CommandText);
                    conn.Open();
                    cmd1.ExecuteNonQuery();
                    conn.Close();    

                    //ir buscar o id_div
                    conn.Open();
                    SqlCommand abcd = new SqlCommand("SELECT id_div FROM Divisao ORDER BY id_div DESC ", conn);
                    SqlDataReader reader6 = abcd.ExecuteReader();
                    Debug.WriteLine(abcd);
                    if (reader6.Read())
                    {
                        iddiv = reader6[0].ToString();
                    }
                    conn.Close();

                    //colocar na obra_div
                    SqlCommand cmd5 = conn.CreateCommand();
                    cmd5.CommandText = "INSERT INTO obra_div (id_obra, id_div) VALUES ('" + idobra + "','"+iddiv+"')";
                    Debug.WriteLine(cmd5.CommandText);
                    conn.Open();
                    cmd5.ExecuteNonQuery();
                    conn.Close();
                }
                                              
                analisar = true;
                
            }
            else
            {
                MessageBox.Show("Tem que submeter a planta!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string nome;
            nome = Entrar.idutilizador;
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT nome_uti FROM Cliente WHERE email = '" + nome + "' ", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lblUtilizador.Text = reader[0].ToString();

            }
            conn.Close();
        }

        
        private void btncustomizacao_Click(object sender, EventArgs e)
        {

            if (nomeconstrucao.Text.Length == 0 && analisar == true && txtMorada.Text.Length == 0 )
            {
                MessageBox.Show("Tem que dar um nome e uma morada à obra!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (nomeconstrucao.Text.Length != 0 && analisar == false && txtMorada.Text.Length == 0 )
            {
                MessageBox.Show("Tem que analisar a planta e dar uma morada à obra!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (nomeconstrucao.Text.Length == 0 && analisar == false && txtMorada.Text.Length == 0 )
            {
                MessageBox.Show("Tem que analisar a planta, dar o nome e morada à sua obra!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (nomeconstrucao.Text.Length != 0 && analisar == true && txtMorada.Text.Length == 0 )
            {
                MessageBox.Show("Tem que dar a morada à sua obra!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (nomeconstrucao.Text.Length == 0 && analisar == true && txtMorada.Text.Length != 0 )
            {
                MessageBox.Show("Tem que dar o nome à sua obra!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (nomeconstrucao.Text.Length == 0 && analisar == false && txtMorada.Text.Length != 0)
            {
                MessageBox.Show("Tem que analisar a planta!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                nomeconst = nomeconstrucao.Text;
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE Obra SET nome_obra = '" + nomeconstrucao.Text + "'  WHERE id_obra = 1";
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                FormEscolhaMaterial newForm = new FormEscolhaMaterial();
                newForm.Show();
                this.Hide();
            }

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            FormMain newForm = new FormMain();
            newForm.Show();
            this.Close();
        }
        private void labelUtilizador_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxAreaPDivisao_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtOrcBase_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void planta_Click(object sender, EventArgs e)
        {

        }
    }
}

