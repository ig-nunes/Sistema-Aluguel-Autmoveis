using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoas
{
    public class Funcionario : Pessoa
    {
        private String? cargo;
        private DateTime dataAdmissao;
        private DateTime dataDesligamento;
        private bool ativo;

        public Funcionario()
        {

        }

        public Funcionario(String nome, String cpf, String email, DateTime nascimento,
            String cargo, DateTime dataAdmissao, DateTime dataDesligamento,
            bool ativo = true) 
        {
            this.SetNome(nome);
            this.SetCpf(cpf);
            this.SetEmail(email);
            this.SetNascimento(nascimento);
            this.cargo = cargo;
            this.dataAdmissao = dataAdmissao;
            this.dataDesligamento = dataDesligamento;
            this.ativo = ativo;
        }

        public String GetCargo() 
        { 
            return cargo; 
        }

        public string GetDataAdmissao() 
        { 
            return dataAdmissao.ToString(); 
        }

        public void SetDataAdmissao(DateTime dataAdmissao)
        {
            this.dataAdmissao = dataAdmissao;
        }

        public DateTime GetDataDesligamento() 
        {
            return this.dataDesligamento;
        }

        public void SetDataDesligamento(DateTime dataDesligamento) 
        { 
            this.dataDesligamento= dataDesligamento;
        }

    }
}
