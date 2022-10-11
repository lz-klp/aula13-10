namespace WinFormsApp1
{
    public abstract class Pessoa
    {
        public int Id;
        public string Nome;
        public string CPF;
        public DateTime DataNascimento;
        public string Telefone;
        public string Categoria;

        public int GetIdade()
        {
            int idade = DateTime.Today.Year - DataNascimento.Year;
            if (DataNascimento.DayOfYear > DateTime.Today.DayOfYear)
                idade -= 1;
            return idade;
        }
    }
}
