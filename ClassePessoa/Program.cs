using System;
using System.Collections.Generic;
using System.Linq;

class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Email { get; set; }

    public Pessoa(string nome, int idade, string email)
    {
        Nome = nome;
        Idade = idade;
        Email = email;
    }
}

class Program
{
    static void Main()
    {
        List<Pessoa> listaPessoas = new List<Pessoa>();

        Console.WriteLine("Digite a quantidade de pessoas que deseja adicionar:");
        int numPessoas = int.Parse(Console.ReadLine());

        for (int i = 0; i < numPessoas; i++)
        {
            Console.WriteLine($"Adicionando pessoa {i + 1}");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Email: ");
            string email = Console.ReadLine();

            listaPessoas.Add(new Pessoa(nome, idade, email));
        }

        // Aqui filtra as pessoas com mais de 30 anos.
        var pessoasComMaisDe30 = listaPessoas.Where(p => p.Idade > 30).ToList();

        Console.WriteLine("\nPessoas com mais de 30 anos:");
        foreach (var pessoa in pessoasComMaisDe30)
        {
            Console.WriteLine($"Nome: {pessoa.Nome}");
        }

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}

