using System;

class Program
{
    static void Main()
    {
        string linha;
        while ((linha = Console.ReadLine()) != null)
        {
            string[] partes = linha.Split(' ');
            int M = int.Parse(partes[0]);
            int N = int.Parse(partes[1]);

            ulong fatorialM = Fatorial(M);
            ulong fatorialN = Fatorial(N);

            Console.WriteLine(fatorialM + fatorialN);
        }
    }

    static ulong Fatorial(int n)
    {
        ulong resultado = 1;
        for (int i = 2; i <= n; i++)
        {
            resultado *= (ulong)i;
        }
        return resultado;
    }
}