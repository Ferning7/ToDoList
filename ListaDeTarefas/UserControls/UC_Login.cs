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
            pbOculto.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (!txtEmailL.Text.Equals("") && !txtSenhaL.Text.Equals(""))
            //    {
            //        Tarefas tarefas = new Tarefas();
            //        tarefas.Email = txtEmailL.Text;
            //        tarefas.Senha = txtSenhaL.Text;

            //        if (Gerenciamento.ValidarEmail(txtEmailL.Text))
            //        {
            //            if (usuario.verificarLogin())
            //            {
            //                if (usuario.VerificarPerm().Equals("usuario"))
            //                {
            //                    UC_homeCliente home = new UC_homeCliente();
            //                    Conteudo c = new Conteudo();

            //                    this.Controls.Clear();
            //                    this.Controls.Add(home);
            //                }
            //                else
            //                {
            //                    UC_HomeFunc homeF = new UC_HomeFunc();


            //                    this.Controls.Clear();
            //                    this.Controls.Add(homeF);

            //                }
            //            }
            //            else
            //            {
            //                MessageBox.Show("Email ou senha inválidos");
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("formato de Email inválido");
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Preencha os campos corretamente!");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Não foi possível fazer login: {ex.Message}");

            //}
        }
    }
}
