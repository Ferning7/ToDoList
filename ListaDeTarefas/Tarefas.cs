using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ListaDeTarefas
{
    public class Tarefas
    {
        private int id;
        private string nomeTarefa;
        private string nomeUsuario;
        private string descTarefa;
        private string email;
        private string senha;
        private string statusTarefa;
        private DateOnly dataIni;
        private DateOnly dataFim;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string NomeUsuario
        {
            get { return nomeUsuario; }
            set { nomeUsuario = value; }
        }

        public string NomeTarefa
        {
            get { return nomeTarefa; }
            set { nomeTarefa = value; }
        }

        public string DescTarefa
        {
            get { return descTarefa; }
            set { descTarefa = value; }
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

        public string StatusTarefa
        {
            get { return statusTarefa; }
            set { statusTarefa = value; }
        }

        public DateOnly DataIni
        {
            get { return dataIni; }
            set { dataIni = value; }
        }

        public DateOnly DataFim
        {
            get { return dataFim; }
            set { dataFim = value; }
        }

        public bool CadastrarUsuario()
        {
            try
            {
                using (MySqlConnection conexaoBanco = new ConexaoDB().Conectar())
                {
                    string senhaCripto = CriptografarSenha(Senha);
                    string sqlInsert = "INSERT INTO usuarios (nomeUsuario, email, senha) VALUES (@nomeUsuario, @email, @senha)";

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

        public bool verificarLogin()
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoDB().Conectar())
                {
                    string senhaCripto = CriptografarSenha(Senha);

                    string consultaUsuarios = "SELECT COUNT(*) FROM usuarios WHERE email = @email and senha = @senha";
                    MySqlCommand comando = new MySqlCommand(consultaUsuarios, conexao);

                    comando.Parameters.AddWithValue("@email", Email);
                    comando.Parameters.AddWithValue("@senha", senhaCripto);

                    int resultado = Convert.ToInt32(comando.ExecuteScalar());

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
                MessageBox.Show("Erro ao verificar login no banco -> " + ex.Message);
                return false;
            }
        }


        public static bool ValidarEmail(string email)
        {
            string emailValido = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(emailValido);
            return regex.IsMatch(email);
        }

        public bool verificarEmailExistente()
        {
            try
            {
                using (MySqlConnection conexaoBanco = new ConexaoDB().Conectar())
                {
                    string sqlconsultaEmail = "select COUNT(*) from usuarios where email = @email ";

                    MySqlCommand comando = new MySqlCommand(sqlconsultaEmail, conexaoBanco);
                    comando.Parameters.AddWithValue("@email", Email);

                    int resultado = Convert.ToInt32(comando.ExecuteScalar());
                    if (resultado > 0)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao verificar email {ex.Message}");
                return false;
            }
        }

        public static string CriptografarSenha(string senha)
        {
            try
            {
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(senha));
                    StringBuilder builder = new StringBuilder();
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        builder.Append(bytes[i].ToString("x2"));
                    }

                    return builder.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível criptografar a senha: " + ex.Message, "Erro - Método Criptografar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

    }
}
