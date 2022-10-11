namespace WinFormsApp1
{
    public class Cliente : Pessoa
    {
        public Cliente()
        {
            this.Categoria = "Cliente";
        }
        public void GerarNota()
        {
            string nota =
                string.Format("Nome: {0}" +"\n"+
                              "CPF: {1}" + "\n" +
                              "Telefone: {2}",
                              this.Nome,this.CPF,this.Telefone);
            Console.WriteLine(nota);
        }
    }
}
