using Estudo02.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo02.Control
{
    public class ControlaValor
    {
        public decimal MediaTotal(Aluno aluno)
        {
            decimal media = 0;
            media = (aluno.Nota1 + aluno.Nota2) / 2;
            return media;
        }

        public decimal MediaComRecuperacao(Aluno aluno)
        {
            decimal media = 0;
            decimal mediaParcial = MediaTotal(aluno);
            if (mediaParcial < 7)
            {
                media = (mediaParcial + aluno.Recuperacao) / 2;
            }
            else
            {
                media = mediaParcial;
            }
            return media;
        }

        public void ResultadoFinal(Aluno aluno)
        {
            decimal mediaFinal = MediaComRecuperacao(aluno);
            if (mediaFinal >= 7)
            {
                Console.WriteLine($"Aluno {aluno.Nome} aprovado com média {mediaFinal}");
            }
            else
            {
                Console.WriteLine($"Aluno {aluno.Nome} reprovado com média {mediaFinal}");
            }
        }
    }
}
