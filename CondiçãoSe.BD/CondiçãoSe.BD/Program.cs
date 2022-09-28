using System;
using System.Security.Cryptography;

public class Condiçãose
{
    public static void Main(string[] args)
    {
        string nome;
        int senha = 1234;
        string cpf;
        int idade;

        Console.WriteLine("Digite o seu nome");
        nome = Console.ReadLine();

        Console.WriteLine("Digite a senha");
        senha = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o seu cpf");
        cpf = Console.ReadLine();

        Console.WriteLine("Digite a sua idade");
        idade = int.Parse(Console.ReadLine());

        if (senha == 1234 && idade >= 18)
        {
            Console.WriteLine("Entre!");

        }
        else {
            Console.WriteLine("Tente novamente ;(");
       
        }




    }



}
