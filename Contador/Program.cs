List<int> listaDeInteiros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//for  (int i = 0; i < listaDeInteiros.Count; i++)
//{
//    if(i % 2 == 0)
//    {
//        Console.WriteLine(listaDeInteiros[i]);
//    }
//}

foreach (int numeros in listaDeInteiros)
{
    if (numeros % 2 == 0)
    {
        Console.Write(numeros);
    }
}