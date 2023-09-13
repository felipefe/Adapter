using System;

namespace Adapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculadoraMensalidade calc = new CalculadoraMensalidadeAdapter();
            var alunos = SistemaEscolar.GetListaAlunosMensalidades();
            calc.CalculaMensalidade(alunos);
        }
    }
}
