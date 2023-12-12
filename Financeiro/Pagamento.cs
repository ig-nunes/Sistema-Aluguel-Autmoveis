using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro
{
    public class Pagamento
    {
        public bool jaFoiPago;

        public Pagamento() 
        { 
            jaFoiPago = false;
        }

        public void FazerPagamentoAgora(Carteira carteira)
        {
            this.jaFoiPago = true;
        }

        public void FazerPagamentoDepois()
        {
            this.jaFoiPago = false;
        }
    }
}
