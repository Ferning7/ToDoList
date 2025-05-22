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
    public partial class UC_Login : UserControl
    {
        public UC_Login()
        {
            InitializeComponent();
            txtSenhaL.UseSystemPasswordChar = true;
            pbVisivel.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Tarefas tarefas = new Tarefas();
                Usuarios users = new Usuarios();
                if (!txtEmailL.Text.Equals("") && !txtSenhaL.Text.Equals(""))
                {

                    users.Email = txtEmailL.Text;
                    users.Senha = txtSenhaL.Text;


                    if (Usuarios.ValidarEmail(txtEmailL.Text))
                    {
                        if (users.verificarLogin())
                        {
                            UC_Home home = new UC_Home();
                            this.Controls.Clear();
                            this.Controls.Add(home);
                        }
                        else
                        {
                            MessageBox.Show("Email ou senha inválidos");
                        }
                    }
                    else
                    {
                        MessageBox.Show("formato de Email inválido");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha os campos corretamente!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível fazer login: {ex.Message}");

            }
        }

        private void linkCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UC_Cadastro cad = new UC_Cadastro();
            this.Controls.Clear();
            this.Controls.Add(cad);
        }

        private void pbVisivel_Click(object sender, EventArgs e)
        {
            txtSenhaL.UseSystemPasswordChar = true;
            pbVisivel.Visible = false;
            pbOculto.Visible = true;
        }

        private void pbOculto_Click(object sender, EventArgs e)
        {
            txtSenhaL.UseSystemPasswordChar = false;
            pbVisivel.Visible = true;
            pbOculto.Visible = false;
        }
    }
}
