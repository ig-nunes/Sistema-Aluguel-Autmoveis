using Financeiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoas
{
    public class Cliente : Pessoa
    {
        private Carteira tipoPagamento;
        private DateTime dataCadastro;
        private bool alugandoAgora = false;

        public Cliente()
        {

        }

        public Cliente(String nome, String cpf, String email, DateTime nascimento,
            DateTime dataCadastro, Carteira tipoPagamento, bool alugandoAgora = false) 
        {
            this.SetNome(nome);
            this.SetCpf(cpf);
            this.SetEmail(email);
            this.SetNascimento(nascimento);
            this.dataCadastro = dataCadastro;
            this.alugandoAgora = alugandoAgora;
            this.tipoPagamento = tipoPagamento;
        }

        public Carteira GetCarteira()
        {
            return tipoPagamento;
        }

        public void AlterarCarteira(Carteira tipo)
        {
            this.tipoPagamento = tipo;
        }
    }
}
