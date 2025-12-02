
using Estudo03.Control;
using Estudo03.Entidade;

var numero = new Valor();
Console.WriteLine("Digite um número inteiro:");
numero.Numero = Convert.ToInt32(Console.ReadLine());
var controla = new ControlaValor();
var resultado = controla.VericarParImpar(numero);
Console.WriteLine(resultado);