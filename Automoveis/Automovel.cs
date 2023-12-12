using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automoveis
{
    public class Automovel
    {
        private String placa;
        private double preco;
        private int quilometragem;
        private bool disponivelAlugar;
        private string marca;
        private string modelo;

        public Automovel()
        {

        }

        public Automovel(string marca, string modelo, string placa, double preco, int quilometragem, bool disponivelAlugar = true)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.placa = placa;
            this.preco = preco;
            this.quilometragem = quilometragem;
            this.disponivelAlugar = disponivelAlugar;
        }
        
        // Properties:
        //public string Marca { get => marca; set => marca = value; }
        //public string Modelo { get => modelo; set => modelo = value; }
        //public string Placa { get => placa; set => placa = value; }
        //public double Preco { get => preco; set => preco = value; }
        //public int Quilometragem { get => quilometragem; set => quilometragem = value; }
        //public bool DisponivelAlugar { get => disponivelAlugar; set => disponivelAlugar = value; }

        // Getters e Setters
        public String GetMarca()
        {
            return this.marca;
        }

        public void SetMarca(String marca)
        {
            this.marca = marca;
        }

        public String GetModelo()
        {
            return this.modelo;
        }

        public void SetModelo(String modelo)
        {
            this.modelo = modelo;
        }

        public String GetPlaca()
        {
            return this.placa;
        }

        public void SetPlaca(String placa)
        {
            this.placa = placa;
        }

        public double GetPreco()
        {
            return this.preco;
        }

        public void SetPreco(double preco)
        {
            this.preco = preco;
        }

        public bool EstaDisponivel()
        {
            return this.disponivelAlugar;
        }

        public void AlterarDisponibilidade(bool disponibilidade)
        {
           this.disponivelAlugar = disponibilidade;
        }

    }
}
