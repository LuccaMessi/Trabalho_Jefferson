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
    public partial class GrntLoginForm : Form
    {
        public GrntLoginForm()
        {
            InitializeComponent();
        }

        private void vltGrt_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void btnLoginGrt_Click(object sender, EventArgs e)
        {
            string usuario = txtGrt.Text;
            string senha = txtSenhaGrt.Text;
            string cod = txtCodLojaGrt.Text;
            CnxDB cnx = new CnxDB();

            string conexaoString = cnx.conn;
            MySqlConnection conexao = new MySqlConnection(conexaoString);

            try
            {
                conexao.Open();

                string query = "SELECT * FROM adm_filial WHERE cpf = @cpf AND senha = @senha AND id_loja = @cod ";

                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@cpf", usuario);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@cod", cod);

                //nao testei se o cod loja esta funcionando

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
    }
}
