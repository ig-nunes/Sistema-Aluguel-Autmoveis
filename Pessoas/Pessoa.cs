using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoas
{
    public abstract class Pessoa
    {
        private String nome;
        private String cpf;
        private String email;
        private DateTime nascimento;

        public String GetNome()
        {
            return this.nome;
        }

        public void SetNome(String nome)
        {
            this.nome = nome;
        }

        public String GetCpf()
        {
            return this.cpf;
        }

        public void SetCpf(String cpf)
        {
            this.cpf = cpf;
        }

        public String GetEmail()
        {
            return this.email;
        }

        public void SetEmail(String email)
        {
            this.email = email;
        }

        public DateTime GetNascimento()
        {
            return this.nascimento;
        }

        public void SetNascimento(DateTime nascimento)
        {
            this.nascimento = nascimento;
        }

    }
}
