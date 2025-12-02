int[] numeros = { 78, 32, 45, 32, 12, 76, 98 };

IEnumerable<int> query = from numero in numeros
                             where numero > 50
                             orderby numero descending
                             select numero;

foreach (var i in query)
{
    Console.Write(i + " ");
}
