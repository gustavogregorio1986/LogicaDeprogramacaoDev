using Estudo3.Control;
using Estudo3.Entidade;

Valor valor = new Valor();
Console.WriteLine("Digite um número:");
valor.Numero = Convert.ToInt32(Console.ReadLine());
ControlaValor controla = new ControlaValor();
Console.WriteLine($"O dobro do valor é: {controla.DobroDoValor(valor)}");