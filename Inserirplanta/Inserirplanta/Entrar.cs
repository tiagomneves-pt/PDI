using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Inserirplanta;
using System.Data.SqlClient;
using System.Diagnostics;

namespace CustomYou
{
    public partial class Entrar : Form
    {
        public Entrar()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\ISCAC\3ANO2SEMESTRE\PDI\projeto\Inserirplanta\Inserirplanta\Database2.mdf;Integrated Security=True;Connect Timeout=30");
        

        public static string idutilizador;

        private void button1_Click(object sender, EventArgs e)
        {
            String username, user_password;

            username = email.Text;
            user_password = password.Text;
            idutilizador = username;

            try
            {
                String querry = "SELECT * FROM Cliente WHERE email = '" + email.Text + "' AND password = '" + password.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                String querry2 = "SELECT * FROM Admin WHERE email = '" + email.Text + "' AND password = '" + password.Text + "'";
                SqlDataAdapter sda1 = new SqlDataAdapter(querry2, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                DataTable dtable2 = new DataTable();
                sda1.Fill(dtable2);

                if (dtable.Rows.Count > 0)
                {
                    username = email.Text;
                    user_password = password.Text;
                    idutilizador = username;

                    FormMain newForm = new FormMain();
                    newForm.Show();
                    this.Hide();
                    try
                    {

                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "UPDATE Cliente SET esta_logado = 1 WHERE email = '" + email.Text + "'";
                        conn.Open();
                        cmd.ExecuteNonQuery();

                    }

                    catch (Exception ex)
                    {

                        Debug.WriteLine(ex.Message);
                        throw ex;
                    }
                }
                else if (dtable2.Rows.Count > 0 )
                {
                    username = email.Text;
                    user_password = password.Text;
                    idutilizador = username;

                    InicioAdmin newForm = new InicioAdmin();
                    newForm.Show();
                    this.Hide();

                    try
                    {

                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "UPDATE Admin SET estalogado = 1 WHERE email = '" + email.Text + "'";
                        conn.Open();
                        cmd.ExecuteNonQuery();

                    }

                    catch (Exception ex)
                    {

                        Debug.WriteLine(ex.Message);
                        throw ex;
                    }
                }
                
                else
                {
                    MessageBox.Show("Dados de Login inválidos", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    email.Clear();
                    password.Clear();

                    email.Focus();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Erro");
            }
            finally
            {

            }
        }

        private void email_MouseClick(object sender, MouseEventArgs e)
        {
            if (email.ForeColor == Color.Silver)
            {
                email.Text = "";
                email.ForeColor = Color.Black;
            }
        }

        private void password_MouseClick(object sender, MouseEventArgs e)
        {
            if (password.ForeColor == Color.Silver)
            {
                password.Text = "";
                password.ForeColor = Color.Black;
            }
        }

        private void Entrar_Load(object sender, EventArgs e)
        {

        }

        private void registo_Click(object sender, EventArgs e)
        {
            Registo newForm = new Registo();
            newForm.Show();
            this.Hide();
        }
    }
}
