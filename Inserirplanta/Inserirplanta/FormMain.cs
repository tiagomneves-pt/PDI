using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Data.SqlClient;
using CustomYou.Materiais;
using CustomYou;
using Inserirplanta;


namespace CustomYou
{
    
    public partial class FormMain : Form
    {
        string imgSlecionada = "";
        //se true é o botao editar, se false é do inserir planta
        public bool qualImagem;
        public static string idobra;
        public static string nomeobra; 
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\ISCAC\3ANO2SEMESTRE\PDI\projeto\Inserirplanta\Inserirplanta\Database2.mdf;Integrated Security=True;Connect Timeout=30");

        public FormMain()
        {
            InitializeComponent();
            fillListBox();

        }
      
        #region Atributos

        public string nomeObra = "";
        SqlConnection sqlConnection;
        SqlCommand cmd;
        SqlDataReader dataReader;
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\ISCAC\3ANO2SEMESTRE\PDI\projeto\Inserirplanta\Inserirplanta\Database2.mdf;Integrated Security=True;Connect Timeout=30";

        #endregion Atributos

        private void FormMain_Load(object sender, EventArgs e)
        {
            string nome;
            nome = Entrar.idutilizador;
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT nome_uti FROM Cliente WHERE email = '" + nome + "' ", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                uti.Text = reader[0].ToString();
            }
            conn.Close();
            
        }

        #region Métodos
        private void CarregarLista()
        {
            //-<BD>
            /*
            
            sqlConnection = new SqlConnection(connString);
            cmd = new SqlCommand();
            sqlConnection.Open();
            cmd.Connection.Open();
            cmd.CommandText = "SELECT nome_obra FROM Obra";
            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                listObras.Items.Add(dataReader["Obras"]);
            }
            sqlConnection.Close();

            /*string sqlQuery = "SELECT nome_obra FROM Obra";

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, sqlConnection); //Preenche a tabela acima criada

            //-</BD>


            
            listObras.DisplayMember = "Obras";
            listObras.ValueMember = "IDObra";
            listObras.DataSource = table;*/
            
        }
        #endregion Métodos

        #region Botões
        private void BtnAdicionarObra_Click(object sender, EventArgs e)
        {
            MenuInserirPlanta newForm = new MenuInserirPlanta();
            newForm.Show();
            this.Hide();
        }

        private void btnProgresso_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                conn.Open();
                SqlCommand cmd12312 = new SqlCommand("SELECT id_obra FROM Obra WHERE nome_obra = '" + listBox1.SelectedItem.ToString() + "' ", conn);
                SqlDataReader reader1231231 = cmd12312.ExecuteReader();
                if (reader1231231.Read())
                {
                    idobra = reader1231231[0].ToString();
                }
                nomeobra = listBox1.SelectedItem.ToString();
                conn.Close();
                qualImagem = true;
                imgSlecionada = Convert.ToString(picPlanta.Image);
                FormProgresso newForm = new FormProgresso();
                newForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tem que selecionar uma obra!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //var formProgresso = new FormProgresso();
           // formProgresso.Show();
            
        }

        #endregion Botões

        private void listObras_Click(object sender, EventArgs e)
        {
            
        }

        private void listObras_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //string obraSelecionada;
            //obraSelecionada = listObras.SelectedItem.ToString();
        }
        void fillListBox()
        {
            //SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\ISCAC\3ANO2SEMESTRE\PDI\projeto\Inserirplanta\Inserirplanta\BDprojeto.mdf;Integrated Security=True;Connect Timeout=30");

            //SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gonçalo Fonseca\Desktop\ISCAC\3ANO2SEMESTRE\projeto\Inserirplanta\Inserirplanta\BDprojeto.mdf;Integrated Security=True;Connect Timeout=30");

            string nome, idcli="";
            nome = Entrar.idutilizador;
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT id_Cliente FROM Cliente WHERE email = '" + nome + "' ", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                idcli = reader[0].ToString();
            }
            conn.Close();

            int idd = Convert.ToInt32(idcli);
            string query = "SELECT nome_obra FROM Obra WHERE id_Cliente = '"+idd+"'";
            SqlCommand cmd2 = new SqlCommand(query, conn);
            SqlDataReader dbr;
            try
            {
                conn.Open();
                dbr = cmd2.ExecuteReader();
                while (dbr.Read())
                {
                    string sname = (string)dbr["nome_obra"]; ; //name is coming from database
                    listBox1.Items.Add(sname);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblBemvindo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string img = "";
            conn.Open();
            SqlCommand planta = new SqlCommand("SELECT planta FROM Obra WHERE nome_obra = '" + listBox1.SelectedItem.ToString() + "'", conn);
            SqlDataReader readerimg = planta.ExecuteReader();
            Debug.WriteLine(planta);
            if (readerimg.Read())
            {
                img = readerimg[0].ToString();
                picPlanta.Load(img);
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE Cliente SET esta_logado = 0 WHERE email = '" + Entrar.idutilizador + "'";
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            Entrar newForm = new Entrar();
            newForm.Show();
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
           
                qualImagem = true;
                imgSlecionada = Convert.ToString(picPlanta.Image);
                FormEscolhaMaterial newForm = new FormEscolhaMaterial();
                newForm.Show();
                this.Close();           
        }
    }
}
