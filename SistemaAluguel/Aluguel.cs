namespace SistemaAluguel
{
    using Automoveis;
    using Financeiro;
    using Pessoas;
    public class Aluguel
    {
        private Automovel? carro;
        private Cliente? cliente;
        private Funcionario? funcionario;
        private Pagamento? pagamento;
        private DateTime dataInicio;
        private DateTime? dataFim;
        private bool atrasado;
        private bool devolvido;

        public Aluguel()
        {
            this.pagamento = new Pagamento();
            this.dataInicio = DateTime.Now;
            this.atrasado = false;
            this.devolvido = false;
        }

        public Aluguel (Automovel carro, Cliente cliente, Funcionario funcionario, Pagamento pagamento, DateTime dataInicio)
        {
            this.pagamento = new Pagamento();
            this.carro = carro;
            this.cliente = cliente;
            this.funcionario = funcionario;
            this.pagamento = pagamento;
            this.dataInicio = dataInicio;
            this.atrasado = false;
            this.devolvido = false;
        }

        private void RealizarPagamento(Carteira tipopagamento)
        {
            if (cliente != null)
            {
                Carteira carteira = this.cliente.GetCarteira();
                Pagamento pagamento = new Pagamento();
                pagamento.FazerPagamentoAgora(carteira);
                Console.WriteLine("Pagamento realizado com sucesso!");
            }

            Console.WriteLine("Cliente não identificado!");
        }

        public DateTime GetDataInicio() 
        {
            return this.dataInicio;
        }

        public DateTime? GetDataFim()
        {
            return this.dataFim;
        }

        public void SetDataFim(DateTime data)
        {
            this.dataFim = data;
        }

        public Cliente? GetCliente()
        {
            return this.cliente;
        }

        public void SetCliente(Cliente cliente)
        {
            this.cliente = cliente;
        }

        public Funcionario? GetFuncionario() 
        { 
            return this.funcionario; 
        }

        public void SetFuncionario(Funcionario funcionario)
        {
            this.funcionario = funcionario;
        }

        public Automovel? GetAutomovel()
        {
            return this.carro;
        }

        public void SetAutomovel(Automovel automovel)
        {
            this.carro = automovel;
        }

        public bool EstaAtrasado()
        {
            return this.atrasado;
        }

        public bool FoiDevolvido()
        {
            return this.devolvido;
        }

        public static Aluguel ConfigurarAluguel(Cliente cliente, Funcionario funcionario, Automovel carro)
        {
            Aluguel aluguel = new Aluguel();
            aluguel.SetCliente(cliente);
            aluguel.SetFuncionario(funcionario);
            aluguel.SetAutomovel(carro);


            aluguel.RealizarPagamento(cliente.GetCarteira());
            return aluguel;
        }
    }
}
