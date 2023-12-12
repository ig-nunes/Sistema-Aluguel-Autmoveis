using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automoveis
{
    public class Esportivo : Automovel
    {
        public int velocidadeMaxima;

        public Esportivo() : base() 
        { 
        
        }

        public Esportivo(string marca, string modelo, string placa, double preco,
        int quilometragem, int velocidadeMaxima, bool disponivelAlugar = true)
            : base(marca, modelo, placa, preco, quilometragem, disponivelAlugar = true) 
        {
            this.velocidadeMaxima = velocidadeMaxima;
        }

        public int GetVelocidadeMaxima() 
        { 
            return velocidadeMaxima; 
        }

    }
}
