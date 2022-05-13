using System;

class Programa
{
    static void Main(string[] args)
    {
        int n1, n2, n3, n4, res;
        
        Console.WriteLine("Digite a note 1: ");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a note 2: ");
        n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a note 2: ");
        n3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a note 4: ");
        n4 = int.Parse(Console.ReadLine());

        res = n1 + n2 + n3 + n4;
        int media = res / 4;
        Console.WriteLine("A média da sua nota é: " + media);

        if (res >= 6)
        {
            Console.WriteLine("Parabéns.Você passou!");
        }
        else if (res == 5)
        {
            Console.WriteLine("Você está em recuperação!");
        }
        else
        {
            Console.WriteLine("Você está reprovado.Sinto muito!");
        }

        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();
    }
}
