using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Dicionário para armazenar a quantidade de LEDs por dígito
        Dictionary<char, int> ledsPorDigito = new Dictionary<char, int>()
        {
            {'0', 6},
            {'1', 2},
            {'2', 5},
            {'3', 5},
            {'4', 4},
            {'5', 5},
            {'6', 6},
            {'7', 3},
            {'8', 7},
            {'9', 6}
        };

        // Leitura da quantidade de casos de teste
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            string valor = Console.ReadLine();
            int totalLeds = 0;

            // Soma os LEDs necessários para cada dígito do número
            foreach (char digito in valor)
            {
                totalLeds += ledsPorDigito[digito];
            }

            Console.WriteLine($"{totalLeds} leds");
        }
    }
}
