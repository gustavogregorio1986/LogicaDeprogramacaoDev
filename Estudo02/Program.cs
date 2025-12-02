
using Estudo02.Control;
using Estudo02.Entidade;

Aluno aluno = new Aluno();
Console.WriteLine("Digite o nome do aluno:");
aluno.Nome = Console.ReadLine();
Console.WriteLine("Digite a primeira nota:");
aluno.Nota1 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Digite a segunda nota:");
aluno.Nota2 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Digite a nota de recuperação:");
aluno.Recuperacao = Convert.ToDecimal(Console.ReadLine());
ControlaValor controla = new ControlaValor();
controla.ResultadoFinal(aluno);
Console.WriteLine(controla.MediaComRecuperacao(aluno));
