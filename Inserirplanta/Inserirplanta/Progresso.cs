using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Inserirplanta;
using  System.Data.SqlClient;
using System.IO;
using System.Diagnostics;

namespace CustomYou
{
    public partial class FormProgresso : Form
    {
        public static List<int> idDiv = new List<int>();
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\ISCAC\3ANO2SEMESTRE\PDI\projeto\Inserirplanta\Inserirplanta\Database2.mdf;Integrated Security=True;Connect Timeout=30");

        string iddiv = "";
        public FormProgresso()
        {
            InitializeComponent();
            string nome;
            nome = FormMain.nomeobra;
            lblNomeObra.Text = nome;
            //pictureBox1.Load(MenuInserirPlanta.image);
            string idobra = FormMain.idobra;
            int idobraaaa = Convert.ToInt32(idobra);
            string query = "SELECT d.nome_div, o.id_div FROM obra_div o, Divisao d WHERE o.id_obra = '" + idobraaaa + "' AND d.id_div = o.id_div";
            SqlCommand cmd2 = new SqlCommand(query, conn);
            SqlDataReader dbr;
            try
            {
                conn.Open();
                dbr = cmd2.ExecuteReader();
                while (dbr.Read())
                {
                    //int sname = (int)dbr["d.nome_div"]; ; //name is coming from database
                    string nome_divisao = (string)dbr[0];
                    int id_divisao = (int)dbr[1];
                    listDivisoes.Items.Add(nome_divisao);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string img = "";
            conn.Open();
            SqlCommand planta = new SqlCommand("SELECT planta FROM Obra WHERE nome_obra = '" + nome + "'", conn);
            SqlDataReader readerimg = planta.ExecuteReader();
            if (readerimg.Read())
            {
                img = readerimg[0].ToString();
                planta_progresso.Load(img);
            }
            conn.Close();
        }
        #region Métodos


        private void InfoDivisaoSelecionada(int index)
        {
            //Este método vai buscar à BD os materiais utilizados para cada zona da divisão e o seu progresso
            //TODO: Trocar os inputs teste por inputs provenientes da BD
            //TODO: Adicionar à tabela das divisões um estado de progresso
            //progressoObra.Value = 3;
        }
        #endregion Métodos

        #region Eventos
        private void FormProgresso_Load(object sender, EventArgs e)
        {
            progressoObra.Minimum = 0;
            progressoObra.Maximum = this.listDivisoes.Items.Count; //Define o máximo da barra com o num. de divisões. Este valor deverá vir da BD
        }
        private void listDivisoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index;
            index = listDivisoes.SelectedIndex;
            string progresso = "";
            string idobra = FormMain.idobra;
            int idobraaaa = Convert.ToInt32(idobra);
           /* conn.Open();
            SqlCommand prog = new SqlCommand("SELECT d.progresso FROM Divisao d, obra_div o WHERE o.id_obra = '" + idobraaaa + "' AND d.id_div = o.id_div", conn);
            SqlDataReader readerProgresso = prog.ExecuteReader();
            Debug.WriteLine(prog);
            if (readerProgresso.Read())
            {
                progresso = readerProgresso[0].ToString();
            }
            conn.Close();
           */

            //ir buscar id da divisao
            idDiv.Clear();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT id_div FROM obra_div WHERE id_obra = '" + idobraaaa + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                iddiv = reader[0].ToString();
                int id = Convert.ToInt32(iddiv);
                idDiv.Add(id);
            }
            conn.Close();

            int IDDIV = Convert.ToInt32(listDivisoes.SelectedIndex);
            int iddddivvv = idDiv[IDDIV];

            // vai buscar o progresso
            conn.Open();
            SqlCommand ad = new SqlCommand("SELECT progresso FROM Divisao WHERE id_div = '" + iddddivvv + "'", conn);
            SqlDataReader reader40 = ad.ExecuteReader();
            Debug.WriteLine(ad);
            if (reader40.Read())
            {
                progresso = reader40[0].ToString();
            }
            conn.Close();

            switch (progresso)
            {
                case "Inicio":
                    progressoDivisao.Value = 1;
                    progressoDivisao.ForeColor = Color.Orange;
                    label3.Text = progresso;
                    break;
                case "Em construção":
                    progressoDivisao.Value = 2;
                    progressoDivisao.ForeColor = Color.Orange;
                    label3.Text = progresso;
                    break;
                case "Concluida":
                    progressoDivisao.Value = 3;
                    progressoDivisao.ForeColor = Color.Orange;
                    label3.Text = progresso;
                    break;
                default:
                    progressoDivisao.Value = 0;
                    break;
            }
            

        }
        #endregion Eventos

        private void lblNomeObra_Click(object sender, EventArgs e)
        {

        }

        private void progressoObra_Click(object sender, EventArgs e)
        {

        }

        private void progressoDivisao_Click(object sender, EventArgs e)
        {

        }
    }
}
