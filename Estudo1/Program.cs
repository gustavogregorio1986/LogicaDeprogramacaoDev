int[] numeros = { 0, 1, 2, 3, 4, 5, 6 };

var query = from numero in numeros
            where numero % 2 == 0
            select numero;

foreach(int num in query)
{
       Console.Write("{0,1} ", num);

}