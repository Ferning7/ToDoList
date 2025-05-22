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

                    string sqlInsert = "INSERT INTO tarefas (nomeTarefa, statusTarefa, dataInicio) VALUES (@nomeTarefa, @statusTarefa, @data)";


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

                    string sqlUpdt = "UPDATE tarefas SET nomeTarefa = @nomeTarefa AND statusTarefa = @statusTarefa AND dataInicio = @data";


                    MySqlCommand comandoSql = new MySqlCommand(sqlUpdt, conexaoBanco);

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
                    string consultaSQL = "SELECT id, nomeTarefa, statusTarefa, dataInicio FROM tarefas";
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
                MessageBox.Show($"Erro ao listar tarefas-> {ex.Message}");
            }
        }

    }
}
