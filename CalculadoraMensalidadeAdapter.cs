using System;
using System.Threading.Tasks;
using Adapter1.Domain;

namespace Adapter1
{
    public class CalculadoraMensalidadeAdapter : ICalculadoraMensalidade
    {
        private SistemaMensalidades SistemaMensalidades = new SistemaMensalidades();

        public void CalculaMensalidade(string[,] alunosArray)
        {
            var listaAlunos = GetAlunos(alunosArray);
            SistemaMensalidades.CalculaMensalidade(listaAlunos);
        }

        public List<Aluno> GetAlunos(string[,] alunosArray)
        {
            var alunos = new List<Aluno>();
            for (int i = 0; i < 5; i++)
            {
                //Obtem as propriedades
                int.TryParse(alunosArray[i, 0] ?? "0", out int id);
                string nome = alunosArray[i, 1];
                string especialidade = alunosArray[i, 2];
                decimal.TryParse(alunosArray[i, 3] ?? "0", out decimal mensalidade);

                //Lista de alunos
                alunos.Add(GetAluno(id, nome, mensalidade));
            }
            return alunos;
        }

        public Aluno GetAluno(int id, string nome, decimal mensalidade) => new Aluno(id, nome, mensalidade);
    }
}