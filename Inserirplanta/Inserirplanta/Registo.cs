using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Inserirplanta;
using CustomYou;
using System.Data.SqlClient;

namespace CustomYou
{
    public partial class Registo : Form
    {
        public Registo()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\ISCAC\3ANO2SEMESTRE\PDI\projeto\Inserirplanta\Inserirplanta\Database2.mdf;Integrated Security=True;Connect Timeout=30");

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Registo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtemail.Text.Length == 0 || txtnome.Text.Length == 0 || txtpassword.Text.Length == 0 || txtmorada.Text.Length == 0 || txtpassword.Text.Length == 0 || txtpasswordconfirm.Text.Length == 0)
            {
                MessageBox.Show("Todos os campos têm que estar corretamente preenchidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtpassword.Text != txtpasswordconfirm.Text)
            {
                MessageBox.Show("As passwords não coincidem", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtemail.Text.Length != 0 && txtnome.Text.Length != 0 && txtpassword.Text.Length != 0 && txtmorada.Text.Length != 0 && txtpassword.Text == txtpasswordconfirm.Text)
            {
                conn.Open();
                SqlCommand cmd1 = new SqlCommand("SELECT email FROM Cliente WHERE email = '" + txtemail.Text + "'");
                cmd1.Connection = conn;
                SqlDataReader sdr = cmd1.ExecuteReader();
                sdr.Read();
                if ((sdr.Read() == true))
                {
                    MessageBox.Show("O email utilizado já existe!");
                    conn.Close();
                }
                else
                {
                    conn.Close();
                    if (txtemail.Text.Length != 0 && txtnome.Text.Length != 0 && txtpassword.Text.Length != 0 && txtmorada.Text.Length != 0 && txtpassword.Text == txtpasswordconfirm.Text)
                    {
                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "INSERT INTO Cliente(nome_uti,email,morada_uti,password) VALUES ('" + txtnome.Text + "','" + txtemail.Text + "','" + txtmorada.Text + "','" + txtpassword.Text + "')";
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Cliente Registado!", "Registo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Entrar newForm = new Entrar();
                        newForm.Show();
                        this.Close();
                    }
                }
            }
        }
    }
}
