using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Automoveis
{
    public class Suv : Automovel
    {
        private int numeroAssentos;

        public Suv() : base()
        { 
        
        }

        public Suv(string marca, string modelo, string placa, double preco,
        int quilometragem, int numeroAssentos, bool disponivelAlugar = true)
        : base(marca, modelo, placa, preco, quilometragem, disponivelAlugar = true)
        {
            this.numeroAssentos = numeroAssentos;
        }

        public int getNumeroAssentos() 
        {  
            return numeroAssentos; 
        }


    }
}
