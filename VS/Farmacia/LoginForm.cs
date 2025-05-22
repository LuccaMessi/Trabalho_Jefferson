using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Farmacia
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;
            CnxDB cnx = new CnxDB();


            string conexaoString = cnx.conn;
            MySqlConnection conexao = new MySqlConnection(conexaoString);

            try
            {
                conexao.Open();

                string query = "SELECT * FROM funcionario WHERE cpf = @cpf AND senha = @senha";

                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@cpf", usuario);
                cmd.Parameters.AddWithValue("@senha", senha);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("Login bem-sucedido!");
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos.");
                }

                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GrntLoginForm grntLoginForm = new GrntLoginForm();
            grntLoginForm.Show();
            this.Hide();
        }
    }
}
