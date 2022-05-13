using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 09 - Escopo");

        int idadeRafael = 17;
        int quantidadeDePessoas = 2;

        bool acompanhado = quantidadeDePessoas > 1;

        string textoAdicional;

        if (acompanhado == true)
        {
            textoAdicional = "Rafael está acompanhado!";
        }
        else
        {
            textoAdicional = "Rafael não está acompanhado!";
        }
        if (idadeRafael >= 18 || acompanhado)
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Não pode entrar!");
        }

        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();
    }
}
