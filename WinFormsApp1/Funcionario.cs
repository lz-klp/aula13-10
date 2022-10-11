
namespace WinFormsApp1
{
    public class Funcionario : Pessoa
    {
        public string PIS;
        public DateTime DataInicio;
        public DateTime DataEncerramento;
        public double salario_hora;
        public bool Ativo;
        
        public Funcionario()
        {
            this.Categoria = "Funcionário";
        }

        public double CalcularSalario(int horas)
        {
            return salario_hora * horas;
        }
        public void ContratarFuncionario(string PIS,double salario)
        {
            this.PIS = PIS;
            salario_hora = salario;
            DataInicio = DateTime.Today;
            Ativo = true;
        }
        public void DemitirFuncionario()
        {
            Ativo=false;
            salario_hora=0;
            DataEncerramento = DateTime.Today;
        }
    }
}
