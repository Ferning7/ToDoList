using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ListaDeTarefas
{
    internal class Usuarios
    {
        private int id;
        private string nomeUsuario;
        private string email;
        private string senha;

        public string NomeUsuario
        {
            get { return nomeUsuario; }
            set { nomeUsuario = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public bool CadastrarUsuario()
        {
            try
            {
                using (MySqlConnection conexaoBanco = new ConexaoDB().Conectar())
                {
                    Tarefas tarefas = new Tarefas();
                    string senhaCripto = tarefas.CriptografarSenha(Senha);
                    string sqlInsert = "INSERT INTO usuarios (nomeUsuario, email,  senha) VALUES (@nomeUsuario, @email, @senha)";

                    MySqlCommand comandoSql = new MySqlCommand(sqlInsert, conexaoBanco);

                    comandoSql.Parameters.AddWithValue("@nomeUsuario", NomeUsuario);
                    comandoSql.Parameters.AddWithValue("@email", email);
                    comandoSql.Parameters.AddWithValue("@senha", senhaCripto);

                    int resultado = comandoSql.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar usuário -> {ex.Message}");
                return false;

            }
        }
    }
}
