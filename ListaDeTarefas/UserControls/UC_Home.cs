using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using MySql.Data.MySqlClient;

namespace ListaDeTarefas.UserControls
{
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();

        }

        private void btnCriarT_Click(object sender, EventArgs e)
        {
            try
            {
                Tarefas tarefas = new Tarefas();
                tarefas.Data = DateTime.Today;

                if (!txtCriarT.Text.Equals(""))
                {

                    tarefas.NomeTarefa = txtCriarT.Text;
                    tarefas.StatusTarefa = "Pendente";
                    tarefas.CriarTarefa();
                    dgvTarefas.Columns["editar"].Width = 10;

                    MessageBox.Show("Tarefa criada");

                }
                else
                {
                    MessageBox.Show("Preencha o campo!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao criar tarefa ->{ex.Message}");
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {

            Tarefas tarefas = new Tarefas();
            tarefas.listarTarefas(dgvTarefas);


            if (!dgvTarefas.Columns.Contains("editar"))
            {
                DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
                btnEditar.Name = "editar";
                btnEditar.HeaderText = "Ação";
                btnEditar.Text = "Editar";
                btnEditar.UseColumnTextForButtonValue = true;
                dgvTarefas.Columns.Add(btnEditar);
            }

            if (!dgvTarefas.Columns.Contains("excluir"))
            {
                DataGridViewButtonColumn btnExcluir = new DataGridViewButtonColumn();
                btnExcluir.Name = "excluir";
                btnExcluir.HeaderText = "Ação";
                btnExcluir.Text = "Excluir";
                btnExcluir.UseColumnTextForButtonValue = true;
                dgvTarefas.Columns.Add(btnExcluir);
            }

        }

        private void dgvTarefas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvTarefas.Columns.Contains("editar") || dgvTarefas.Columns.Contains("excluir"))
            {
                dgvTarefas.Rows[e.RowIndex].Cells["editar"].ToolTipText = "Clique para editar";

                dgvTarefas.Rows[e.RowIndex].Cells["Excluir"].ToolTipText = "Clique para excluir";

            }

        }



        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Tarefas tarefas = new Tarefas();
            tarefas.ExcluirTarefa();

        }

        private void dgvTarefas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvTarefas.BeginEdit(true);
            }
        }

        private void dgvTarefas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;

            Usuarios user = new Usuarios();
            Tarefas tarefas = new Tarefas();

            if (rowIndex >= 0 && columnIndex >= 0)
            {

                var cell = dgvTarefas.Rows[rowIndex].Cells[columnIndex];

                tarefas.StatusTarefa = cell.Value.ToString();
               
                var idTarefaObj = dgvTarefas.Rows[rowIndex].Cells["id"].Value.ToString();
                if (idTarefaObj == null) return;

                tarefas.EditarTarefa(user.Id, tarefas.Id, tarefas.StatusTarefa);


            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
