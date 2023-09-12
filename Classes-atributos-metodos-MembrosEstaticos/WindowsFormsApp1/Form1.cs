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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        MySqlConnection Conexao;
        public Form1()
        {
           
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                // CRIAR LIGAÇÃO COM MYSQL
                string data_source = "server=localhost;uid=root;pwd=;database=estudos;";
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();
                // USAR O COMANDO INSERT;

                var sql = "INSERT INTO estudos_csharp " +
                    "(nome_aluno,idade_aluno,email_aluno,sexo,informacoes_aluno)" +
                    $"VALUES ('{txtNome}','{txtIdade}','{txtEmail}','{txtSexo}','{txtInformacoes};')";
                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                var reader = comando.ExecuteReader();
                MessageBox.Show("Deu tudo certo, Inserido");

                /*
                while (reader.Read())
                {
                    MessageBox.Show($"{reader["id"]} => {reader["nome"]}");
                }*/

            } catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }
    }
}
