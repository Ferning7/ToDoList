using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDeTarefas.UserControls
{
    public partial class UC_Cadastro : UserControl
    {
        public UC_Cadastro()
        {
            InitializeComponent();
            txtSenhaC.UseSystemPasswordChar = true;
            pbVisivel.Visible = false;
        }




        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UC_Login log = new UC_Login();
            this.Controls.Clear();
            this.Controls.Add(log);
        }

        private void pbVisivel_Click(object sender, EventArgs e)
        {
            txtSenhaC.UseSystemPasswordChar = true;
            pbVisivel.Visible = false;
            pbOculto.Visible = true;
        }

        private void pbOculto_Click(object sender, EventArgs e)
        {
            txtSenhaC.UseSystemPasswordChar = false;
            pbVisivel.Visible = true;
            pbOculto.Visible = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
Tarefas tarefas = new Tarefas();
            Usuarios users = new Usuarios();
            try
            {
                if (!txtNomeUsuario.Text.Equals("") && !txtEmailC.Text.Equals("") && !txtSenhaC.Text.Equals(""))
                {

                    users.Email = txtEmailC.Text;
                    users.NomeUsuario = txtNomeUsuario.Text;
                    users.Senha = txtSenhaC.Text;

                    if (Usuarios.ValidarEmail(txtEmailC.Text))
                    {
                        if (users.verificarEmailExistente())
                        {
                            if (users.CadastrarUsuario())
                            {
                                MessageBox.Show("cadastro realizado" + MessageBoxIcon.Information);
                                UC_Login log = new UC_Login();
                                this.Controls.Clear();
                                this.Controls.Add(log);
                            }
                            else
                            {
                                MessageBox.Show("Falha ao cadastrar usuário");
                                txtEmailC.Clear();
                                txtSenhaC.Clear();
                                txtNomeUsuario.Clear();
                            }
                        }
                        else
                        {
                            txtEmailC.Clear();
                            txtSenhaC.Clear();
                            txtNomeUsuario.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email inválido");
                        txtEmailC.Clear();
                        txtSenhaC.Clear();
                        txtNomeUsuario.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Preencha os campos corretamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar usuário -> {ex.Message}");

            }

        }
    }
}
