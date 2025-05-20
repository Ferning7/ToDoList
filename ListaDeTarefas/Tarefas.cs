using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeTarefas
{
    public class Tarefas
    {
        private int id;
        private string nomeTarefa;
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
    }
}
