using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 12 - Encadeando For");

        // Com break
        for(int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
        {
            for(int contadorColuna = 0; contadorColuna <= 10; contadorColuna++)
            {
                Console.Write("*");
                if (contadorColuna >= contadorLinha)
                    break;
            }
            Console.WriteLine();  
        }

        // Sem break
        for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
        {
            for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();
    }
}
