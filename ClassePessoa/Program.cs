using System;

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
        Pessoa pessoal1 = new Pessoa("Daniel", 30, "danielfernandomo23@gmail.com");

        Console.WriteLine("Nome: " + pessoal1.Nome);
        Console.WriteLine("Idade: " + pessoal1.Idade);
        Console.WriteLine("Email: " + pessoal1.Email);
        Console.WriteLine();

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
        
}

