using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Mysqlx.Crud;
using System.Windows.Forms;

namespace ListaDeTarefas
{
    public class Tarefas
    {
        private int id;
        private string nomeTarefa;
        private string statusTarefa;
        private DateTime data;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public string NomeTarefa
        {
            get { return nomeTarefa; }
            set { nomeTarefa = value; }
        }


        public string StatusTarefa
        {
            get { return statusTarefa; }
            set { statusTarefa = value; }
        }

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }


        public bool CriarTarefa()
        {
            try
            {
                using (MySqlConnection conexaoBanco = new ConexaoDB().Conectar())
                {

                    string sqlInsert = "INSERT INTO tarefa (nomeTarefa, statusTarefa, dataInicio) VALUES (@nomeTarefa, @statusTarefa, @data)";


                    MySqlCommand comandoSql = new MySqlCommand(sqlInsert, conexaoBanco);



                    comandoSql.Parameters.AddWithValue("@nomeTarefa", NomeTarefa);
                    comandoSql.Parameters.AddWithValue("@statusTarefa", StatusTarefa);
                    comandoSql.Parameters.AddWithValue("@data", Data);


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
                MessageBox.Show($"Erro ao cadastrar tarefa -> {ex.Message}");
                return false;

            }
        }

        // FALTA MEXER AQUI, COLOCAR DELETE
        public bool ExcluirTarefa()
        {
            try
            {
                using (MySqlConnection conexaoBanco = new ConexaoDB().Conectar())
                {

                    string sqlDelete = "DELETE FROM tarefas WHERE nomeTarefa = @nomeTarefa AND statusTarefa = @statusTarefa AND dataInicio = @data";



                    MySqlCommand comandoSql = new MySqlCommand(sqlDelete, conexaoBanco);



                    comandoSql.Parameters.AddWithValue("@nomeTarefa", NomeTarefa);
                    comandoSql.Parameters.AddWithValue("@statusTarefa", StatusTarefa);
                    comandoSql.Parameters.AddWithValue("@data", Data);


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
                MessageBox.Show($"Erro ao cadastrar tarefa -> {ex.Message}");
                return false;

            }
        }

        // FALTA MEXER AQUI, EDITAR TAREFAS
        public bool EditarTarefa(int userID, int idTarefa, string novoStatus)
        {
            try
            {
                using (MySqlConnection conexaoBanco = new ConexaoDB().Conectar())
                {

                    string sqlalter = "update as (nomeTarefa, statusTarefa, dataInicio) VALUES (@nomeTarefa, @statusTarefa, @data)";


                    MySqlCommand comandoSql = new MySqlCommand(sqlInsert, conexaoBanco);



                    comandoSql.Parameters.AddWithValue("@nomeTarefa", NomeTarefa);
                    comandoSql.Parameters.AddWithValue("@statusTarefa", StatusTarefa);
                    comandoSql.Parameters.AddWithValue("@data", Data);


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
                MessageBox.Show($"Erro ao cadastrar tarefa -> {ex.Message}");
                return false;

            }
        }

        public void listarTarefas(DataGridView dgv)
        {
            try
            {

                using (MySqlConnection conexaobanco = new ConexaoDB().Conectar())
                {
                    DataTable dataTable = new DataTable();
                    string consultaSQL = "SELECT * FROM tarefas";
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(consultaSQL, conexaobanco);

                    dataAdapter.Fill(dataTable);

                    dgv.AllowUserToAddRows = false;
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgv.AllowUserToDeleteRows = true;
                    dgv.DataSource = dataTable;
                    dgv.AutoResizeColumns();
                    dgv.ClearSelection();

                }
            }
            catch (Exception ex)
            {

                throw;
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
