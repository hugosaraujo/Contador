List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

foreach (int numero in numeros)
{
    if (numero % 2 != 0)
    {
        Console.Write($"{numero} ");
    }
}

//contagem feita com for
List<int> listaDeNumeros = new List<int>();

for (int numero = 0; numero < 11; numero++)
{
    listaDeNumeros.Add(numero);
    for (int i = numero; i < listaDeNumeros.Count; i++)
    {
        if (i % 2 != 0)
        {
            Console.WriteLine(listaDeNumeros[numero]);
        }
    }
}