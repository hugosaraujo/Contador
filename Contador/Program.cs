//List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
List<int> numeros = new();
for (int i = 0; i <= 10; i++)
{
    numeros.Add(i);
}

List<int> numerosPares = numeros.FindAll(numero => numero % 2 == 0);
numerosPares.ForEach(numero => Console.Write($"{numero} "));


//contagem feita com for
List<int> listaDeNumeros = new List<int>();

for (int numero = 0; numero < 11; numero++)
{
    listaDeNumeros.Add(numero);
    for (int i = numero; i < listaDeNumeros.Count; i++)
    {
        if (i % 2 != 0)
        {
            Console.WriteLine();
            Console.Write(listaDeNumeros[numero]);
        }
    }
}