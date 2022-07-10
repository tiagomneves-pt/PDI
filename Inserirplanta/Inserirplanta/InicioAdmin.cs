using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace CustomYou
{
    public partial class InicioAdmin : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\ISCAC\3ANO2SEMESTRE\PDI\projeto\Inserirplanta\Inserirplanta\Database2.mdf;Integrated Security=True;Connect Timeout=30");
        public static List<int> ID = new List<int>();
        string iddiv = "";
        public InicioAdmin()
        {
            InitializeComponent();

            //ir buscar o id do admin
            string idadmin = "";
            conn.Open();
            SqlCommand ad = new SqlCommand("SELECT id_Admin FROM Admin WHERE email = '"+Entrar.idutilizador+"'", conn);
            SqlDataReader reader40 = ad.ExecuteReader();
            Debug.WriteLine(ad);
            if (reader40.Read())
            {
                idadmin = reader40[0].ToString();
            }
            conn.Close();
            //conn.Open();
            string query = "SELECT nome_obra FROM Obra WHERE id_Admin = '" + idadmin + "' ";
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
        private void InicioAdmin_Load(object sender, EventArgs e)
        {          
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();          
            cmd.CommandText ="UPDATE Admin SET estalogado = '0' WHERE estalogado = 1";           
            cmd.ExecuteNonQuery();
            conn.Close();

            this.Close();
            Entrar newForm = new Entrar();
            newForm.Show();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void addCliente_Click(object sender, EventArgs e)
        {
            String username, id = "", idAd = "";

            username = txtEmail.Text;
            conn.Open();
            String querry = "SELECT * FROM Cliente WHERE email = '" + txtEmail.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            conn.Close();

            conn.Open();
            SqlCommand ab = new SqlCommand("SELECT id_Cliente FROM Cliente WHERE email = '" + txtEmail.Text + "' ", conn);
            SqlDataReader reader1 = ab.ExecuteReader();
            Debug.WriteLine(ab);

            if (reader1.Read())
            {
                id = reader1[0].ToString();
            }
            conn.Close();

            conn.Open();
            SqlCommand abc = new SqlCommand("SELECT id_Admin FROM Admin WHERE estalogado = 1", conn);
            SqlDataReader reader6 = abc.ExecuteReader();
            if (reader6.Read())
            {
                idAd = reader6[0].ToString();
            }
            conn.Close();

            if (dtable.Rows.Count > 0)
            {
                username = txtEmail.Text;

                conn.Open();
                SqlCommand abcd = new SqlCommand("SELECT id_Admin FROM Obra WHERE id_Cliente = '"+id+"'", conn);
                SqlDataReader reader7 = abcd.ExecuteReader();
                
                int numeroDeAdmin = -1;
                string id_admin = "";
                

                if (reader7.Read())
                {
                    id_admin = reader7[0].ToString();
                    conn.Close();
                    if (string.IsNullOrEmpty(id_admin))
                    {
                        SqlCommand cmd123 = conn.CreateCommand();
                        cmd123.CommandText = "UPDATE Obra SET id_Admin ='" + idAd + "' WHERE id_Cliente = '" + id + "'  ";
                        Debug.WriteLine(cmd123.CommandText);
                        conn.Open();
                        cmd123.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Acossiação válida!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }
                conn.Close();
                conn.Open();
                SqlCommand abcde = new SqlCommand("SELECT id_Admin FROM Obra WHERE id_Cliente = '" + id + "'", conn);
                SqlDataReader reader8 = abcd.ExecuteReader();

                if (reader8.Read())
                {                       
                    id_admin = reader8[0].ToString();
                    numeroDeAdmin = Convert.ToInt32(id_admin);
                }

                conn.Close();

                if (numeroDeAdmin != Convert.ToInt32(idAd) && numeroDeAdmin != -1)
                {
                    MessageBox.Show("Este utilizador já está associado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
               

                SqlCommand cmd1 = conn.CreateCommand();
                cmd1.CommandText = "UPDATE Obra SET id_Admin ='" + idAd + "' WHERE id_Cliente = '"+id+"'  ";
                Debug.WriteLine(cmd1.CommandText);
                conn.Open();
                cmd1.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Acossiação válida!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string idadmin = "";
                conn.Open();
                SqlCommand ad = new SqlCommand("SELECT id_Admin FROM Admin WHERE email = '" + Entrar.idutilizador + "'", conn);
                SqlDataReader reader40 = ad.ExecuteReader();
                Debug.WriteLine(ad);
                if (reader40.Read())
                {
                    idadmin = reader40[0].ToString();
                }
                conn.Close();
                //conn.Open();
                listBox1.Items.Clear();
                string query = "SELECT nome_obra FROM Obra WHERE id_Admin = '" + idadmin + "' ";
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
            else if(txtEmail.Text.Length == 0)
            {
                MessageBox.Show("Insira um email!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Email inválido", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ir a imagem
            string img = "";
            conn.Open();
            SqlCommand planta = new SqlCommand("SELECT planta FROM Obra WHERE nome_obra = '" + listBox1.SelectedItem.ToString() + "'", conn);
            SqlDataReader readerimg = planta.ExecuteReader();
            Debug.WriteLine(planta);
            if (readerimg.Read())
            {
                img = readerimg[0].ToString();
                pictureBox1.Load(img);
            }
            conn.Close();
            //ir buscar o id_cliente na obra
            string idCLI = "";
            conn.Open();
            SqlCommand cli = new SqlCommand("SELECT id_Cliente FROM Obra WHERE nome_obra = '" + listBox1.SelectedItem.ToString() + "'", conn);
            SqlDataReader readerCLI = cli.ExecuteReader();
            Debug.WriteLine(cli);
            if (readerCLI.Read())
            {
                idCLI = readerCLI[0].ToString();
            }
            conn.Close();

            //morada da obra
            string morada = "";
            conn.Open();
            SqlCommand adc = new SqlCommand("SELECT morada FROM Obra WHERE nome_obra = '" + listBox1.SelectedItem.ToString() + "'", conn);
            SqlDataReader reader40 = adc.ExecuteReader();
            Debug.WriteLine(adc);
            if (reader40.Read())
            {
                morada = reader40[0].ToString();
            }
            label4.Text =Convert.ToString(morada);
            conn.Close();

            //ir buscar o nome
            string nomecliente = "";
            conn.Open();
            SqlCommand asdsadsa = new SqlCommand("SELECT nome_uti FROM Cliente WHERE id_Cliente ='"+ idCLI + "'", conn);
            SqlDataReader reader50 = asdsadsa.ExecuteReader();
            Debug.WriteLine(asdsadsa);
            if (reader50.Read())
            {
                nomecliente = reader50[0].ToString();
            }
            label2.Text = Convert.ToString(nomecliente);
            conn.Close();

        
            //morada do cliente
            string moradaClie = "";
            conn.Open();
            SqlCommand moradaCLII = new SqlCommand("SELECT morada_uti FROM Cliente WHERE id_Cliente ='" + idCLI + "'", conn);
            SqlDataReader readermorada = moradaCLII.ExecuteReader();
            Debug.WriteLine(moradaCLII);
            if (readermorada.Read())
            {
                moradaClie = readermorada[0].ToString();
            }
            label3.Text = Convert.ToString(moradaClie);
            conn.Close();

            //email do cliente
            string email = "";
            conn.Open();
            SqlCommand cmdemail = new SqlCommand("SELECT email FROM Cliente WHERE id_Cliente ='" + idCLI + "'", conn);
            SqlDataReader readeremail = cmdemail.ExecuteReader();
            Debug.WriteLine(cmdemail);
            if (readeremail.Read())
            {
                email = readeremail[0].ToString();
            }
            label9.Text = Convert.ToString(email);
            conn.Close();

            //orçametno do cliente
            string orc = "";
            conn.Open();
            SqlCommand cmdorc = new SqlCommand("SELECT orcamento_final FROM Obra WHERE nome_obra = '" + listBox1.SelectedItem.ToString() + "'", conn);
            SqlDataReader readerorc = cmdorc.ExecuteReader();
            Debug.WriteLine(cmdorc);
            if (readerorc.Read())
            {
                orc = readerorc[0].ToString();
            }
            label12.Text = Convert.ToString(orc);
            conn.Close();

            //ir buscar o id_obra 
            string id_obra = "";
            conn.Open();
            SqlCommand sqlobra = new SqlCommand("SELECT id_obra FROM Obra WHERE nome_obra = '" + listBox1.SelectedItem.ToString() + "'", conn);
            SqlDataReader readerobra = sqlobra.ExecuteReader();
            Debug.WriteLine(sqlobra);
            if (readerobra.Read())
            {
                id_obra = readerobra[0].ToString();
            }
            conn.Close();

            //ir buscar a altura
            string alturaObra = "";
            conn.Open();
            SqlCommand alturaCMD = new SqlCommand("SELECT altura FROM Obra WHERE nome_obra ='" + listBox1.SelectedItem.ToString() + "'", conn);
            SqlDataReader readerAltura = alturaCMD.ExecuteReader();
            Debug.WriteLine(alturaCMD);
            if (readerAltura.Read())
            {
                alturaObra = readerAltura[0].ToString();
            }
            label15.Text = Convert.ToString(alturaObra);
            conn.Close();

            //ir buscar id div
            ID.Clear();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT id_div FROM obra_div WHERE id_obra = '" + id_obra + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                iddiv = reader[0].ToString();
                int id = Convert.ToInt32(iddiv);
                ID.Add(id);               
            }
            conn.Close();

            comboBox2.Items.Clear();
            // string nome_divisao = "";
            //int div = ID.Count;
            for (int i = 1; i < ID.Count + 1; i++)
            {               
                comboBox2.Items.Add(i);               
            }

            

            // div = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null && comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma obra e uma divisao", "Ok!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string IDAD = "";
                conn.Open();
                SqlCommand ad = new SqlCommand("SELECT id_Admin FROM Admin WHERE email = '" + Entrar.idutilizador + "'", conn);
                SqlDataReader reader40 = ad.ExecuteReader();
                Debug.WriteLine(ad);
                if (reader40.Read())
                {
                    IDAD = reader40[0].ToString();
                }
                conn.Close();             
                if (comboBox1.SelectedItem.ToString() == "Inicio")
                {
                    int IDDIV = Convert.ToInt32(comboBox2.Text);
                    int iddddivvv = ID[IDDIV-1];
                    string progresso = "Inicio";
                    SqlCommand cmd23 = conn.CreateCommand();
                    cmd23.CommandText = "UPDATE Divisao SET progresso = '" + progresso + "' WHERE id_div ='"+ iddddivvv+ "'";
                    Debug.WriteLine(cmd23.CommandText);
                    conn.Open();
                    cmd23.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Progresso registado", "Ok!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                if (comboBox1.SelectedItem.ToString() == "Em construção")
                {
                    int IDDIV = Convert.ToInt32(comboBox2.Text);
                    int iddddivvv = ID[IDDIV - 1];
                    string progresso = "Em construção";
                    SqlCommand cmd23 = conn.CreateCommand();
                    cmd23.CommandText = "UPDATE Divisao SET progresso = '" + progresso + "' WHERE id_div ='" + iddddivvv + "'";
                    Debug.WriteLine(cmd23.CommandText);
                    conn.Open();
                    cmd23.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Progresso registado", "Ok!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                if (comboBox1.SelectedItem.ToString() == "Concluida")
                {
                    int IDDIV = Convert.ToInt32(comboBox2.Text);
                    int iddddivvv = ID[IDDIV - 1];
                    string progresso = "Concluida";
                    SqlCommand cmd23 = conn.CreateCommand();
                    cmd23.CommandText = "UPDATE Divisao SET progresso = '" + progresso + "' WHERE id_div ='" + iddddivvv + "'";
                    Debug.WriteLine(cmd23.CommandText);
                    conn.Open();
                    cmd23.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Progresso registado", "Ok!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            comboBox1.ResetText();
            comboBox2.ResetText();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IDDIV = Convert.ToInt32(comboBox2.Text);
            int iddddivvv = ID[IDDIV - 1];            
            conn.Open();
            SqlCommand processsoo = new SqlCommand("SELECT progresso FROM Divisao WHERE id_div = '" + iddddivvv + "' ", conn);
            SqlDataReader readerpro = processsoo.ExecuteReader();
            Debug.WriteLine(processsoo);
            if (readerpro.Read())
            {
                comboBox1.Text = readerpro[0].ToString();
            }
            conn.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
