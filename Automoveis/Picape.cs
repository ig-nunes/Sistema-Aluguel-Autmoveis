using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automoveis
{
    public class Picape : Automovel
    {
        public int capacidadeCarga;

        public Picape() : base() 
        { 

        }


        public Picape(string marca, string modelo, string placa, double preco,
            int quilometragem, int capacidadeCarga, bool disponivelAlugar = true) 
            : base(marca, modelo, placa, preco, quilometragem, disponivelAlugar = true)
        {
            this.capacidadeCarga = capacidadeCarga;
        }

        public int getCapacidadeCarga() 
        {  
            return capacidadeCarga; 
        }

    }
}
