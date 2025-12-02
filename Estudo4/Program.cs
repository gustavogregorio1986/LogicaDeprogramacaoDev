using Estudo4.Control;
using Estudo4.Entidade;

Valor valor = new Valor();
valor.Numero = 10;

Console.WriteLine("Numero: " + valor.Numero);


ControlaValor controla = new ControlaValor();
int antecessor = controla.Antecessor(valor);
int sucessor = controla.Sucessor(valor);
Console.WriteLine("Antecessor: " + antecessor);
Console.WriteLine("Sucessor: " + sucessor);