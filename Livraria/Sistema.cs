namespace Principal
{
    using Pessoas;
    using Automoveis;
    using Financeiro;
    using SistemaAluguel;
    internal class Sistema
    {   


        private List<Cliente> clientes;
        private List<Funcionario> funcionarios;
        private List<Automovel> automoveisDisponiveis;
        private List<Automovel> automoveisAlugados;
        private List<Aluguel> alugueis;

        public Sistema()
        {
            clientes = new List<Cliente>();
            funcionarios = new List<Funcionario>();
            automoveisDisponiveis = new List<Automovel>();
            automoveisAlugados = new List<Automovel>();
        }

        public void RegistrarCliente(Cliente cliente) 
        {
            this.clientes.Add(cliente);
        }

        public void ContratarFuncionario(Funcionario funcionario)
        {
            funcionarios.Add(funcionario);
        }

        public void RemoverCliente(String email)
        {
            foreach (Cliente cliente in clientes)
            {
                if (cliente.GetEmail() == email)
                {
                    Console.WriteLine("Cliente removido com sucesso!");
                    clientes.Remove(cliente);
                    return;
                }
            }

            Console.WriteLine("Cliente não encontrado!");

        }

        private Cliente? BuscarClientePorEmail(String email) 
        {
            foreach(Cliente cliente in clientes)
            {
                if (cliente.GetEmail().Equals(email))
                {
                    return cliente;
                }
            }
            return null;
        }

        private Funcionario? BuscarFuncionarioPorEmail(String email)
        {
            foreach (Funcionario funcionario in funcionarios)
            {
                if (funcionario.GetEmail().Equals(email))
                {
                    return funcionario;
                }
            }
            return null;
        }

        public Aluguel? ConsultarAlugueisPorCliente(Cliente cliente)
        {
            foreach (var aluguel in this.alugueis)
            {
                if (aluguel.GetCliente() == cliente)
                {
                    return aluguel;
                }
            }

            return null;
        }

        public List<Automovel> ConsultarCarros() 
        {                      
            return automoveisDisponiveis; 
        }                      
                               
        public List<Automovel> ConsultarCarrosAlugados()
        {
            return automoveisDisponiveis;
        }

        public Automovel BuscarCarroPorPlaca(String placa)
        {
            return new Automovel();
        }


        public void RealizarAluguel(String clienteEmail, String funcionarioEmail,
            String automovelPlaca)
        {
            var cliente = this.BuscarClientePorEmail(clienteEmail);
            var funcionario = this.BuscarFuncionarioPorEmail(funcionarioEmail);
            var carro = this.BuscarCarroPorPlaca(automovelPlaca);

            if (cliente != null && funcionario != null && carro != null) 
            {
                var aluguel = Aluguel.ConfigurarAluguel(cliente, funcionario, carro);
                

                this.alugueis.Add(aluguel);
                Console.WriteLine("Aluguel realizado com sucesso!");
            }
            else 
            {
                Console.WriteLine("Ocorreu algum erro!");
            }

        }

    }
}
