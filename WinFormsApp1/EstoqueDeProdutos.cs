using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    
    public class EstoqueDeProdutos
    {
        public Produto Produto;
        public int Quantidade;
        public EstoqueDeProdutos(Produto produto, int quant)
        {
            this.Produto = produto;
            this.Quantidade = quant;
        }
    }
}
