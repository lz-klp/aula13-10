using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public static class BD
    {
        public static List<Pessoa> pessoas = new();
        public static DateTime UltimaAtualizacao;
        public static void AddPessoa(Pessoa p)
        {
            pessoas.Add(p);
            UltimaAtualizacao = DateTime.Now;
        }
    }
}
