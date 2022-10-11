namespace WinFormsApp1
{
    public class Estoque
    {
        public List<EstoqueDeProdutos> Produtos;

        public void AdicionarItem(Produto produto,int quant)
        {
            Produtos.Add(new EstoqueDeProdutos(produto,quant));
        }
        public void RemoverItem(Produto produto, int quant)
        {
            if(!VerificarDisponibilidade(produto,quant))
                return;

            foreach (var item in Produtos)
            {
                if(item.Produto.Nome == produto.Nome)
                    item.Quantidade -= quant;
            }
        }
        public bool VerificarDisponibilidade(Produto produto,int quant)
        {
            return Produtos.Where(x => x.Produto.Nome == produto.Nome)
                           .Any(x => x.Quantidade >= quant);
        }
    }
}
