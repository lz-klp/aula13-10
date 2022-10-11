using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Fornecedor : Pessoa
    {
        public List<Produto> Produtos;
        public List<Produto> CompraAtual;
        public int Freq_entrega;
        public DateTime Prox_entrega;

        public Fornecedor()
        {
            this.Categoria = "Fornecedor";
        }

        public void RealizarPedido(List<string> Pedido)
        {
            CompraAtual = Produtos
                .Where(x=>Pedido.Contains(x.Nome))
                .ToList();
        }
        public double VerificarValores(string Produto)
        {
            return Produtos
                .Where(x => x.Nome == Produto)
                .Select(x => x.Valor)
                .FirstOrDefault();
        }
        public void ReceberEntrega()
        {
            CompraAtual.Clear();
            var dataAdicionada = DateTime.Today.AddDays(Freq_entrega);

            Prox_entrega = dataAdicionada.DayOfWeek == DayOfWeek.Sunday 
                ? dataAdicionada.AddDays(1) 
                : dataAdicionada;
        }
    }
}
