using System;
using System.Collections.Generic;

// Classe base Animal: representa o conceito geral de um animal no zoológico
public class Animal
{
    // Atributos comuns a todos os animais
    public string Nome { get; set; } // Nome do animal
    public int Idade { get; set; } // Idade do animal
    public string Especie { get; set; } // Espécie do animal

    // Construtor da classe Animal: inicializa os atributos do animal
    public Animal(string nome, int idade, string especie)
    {
        Nome = nome;
        Idade = idade;
        Especie = especie;
    }

    // Método virtual FazerSom(): representa o som que o animal faz
    // Marcado como virtual para permitir que as classes derivadas o substituam (polimorfismo)
    public virtual void FazerSom()
    {
        Console.WriteLine($"{Nome} faz um som genérico.");
    }
}

// Classe Leao: representa um leão no zoológico, herda da classe Animal
public class Leao : Animal
{
    // Construtor da classe Leao: chama o construtor da classe base (Animal)
    public Leao(string nome, int idade) : base(nome, idade, "Leão") { }

    // Método FazerSom() substituído (override): o leão ruge
    public override void FazerSom()
    {
        Console.WriteLine($"{Nome} ruge!");
    }
}

// Classe Elefante: representa um elefante no zoológico, herda da classe Animal
public class Elefante : Animal
{
    // Construtor da classe Elefante: chama o construtor da classe base (Animal)
    public Elefante(string nome, int idade) : base(nome, idade, "Elefante") { }

    // Método FazerSom() substituído (override): o elefante tromba
    public override void FazerSom()
    {
        Console.WriteLine($"{Nome} tromba!");
    }
}

// Classe Macaco: representa um macaco no zoológico, herda da classe Animal
public class Macaco : Animal
{
    // Construtor da classe Macaco: chama o construtor da classe base (Animal)
    public Macaco(string nome, int idade) : base(nome, idade, "Macaco") { }

    // Método FazerSom() substituído (override): o macaco balança
    public override void FazerSom()
    {
        Console.WriteLine($"{Nome} balança!");
    }
}

// Classe Zoologico: gerencia a lista de animais no zoológico
public class Zoologico
{
    // Lista de animais no zoológico
    private List<Animal> animais = new List<Animal>();

    // Método AdicionarAnimal(): adiciona um animal ao zoológico
    public void AdicionarAnimal(Animal animal)
    {
        animais.Add(animal);
    }

    // Método ExibirAnimais(): exibe informações sobre todos os animais no zoológico
    public void ExibirAnimais()
    {
        foreach (var animal in animais)
        {
            Console.WriteLine($"Nome: {animal.Nome}, Idade: {animal.Idade}, Espécie: {animal.Especie}");
            animal.FazerSom(); // Chama o método FazerSom() do animal (polimorfismo)
        }
    }
}

// Classe Program: ponto de entrada do programa
public class Program
{
    public static void Main(string[] args)
    {
        // Cria um zoológico
        Zoologico zoologico = new Zoologico();

        // Cria animais
        Leao leao = new Leao("Simba", 5);
        Elefante elefante = new Elefante("Dumbo", 10);
        Macaco macaco = new Macaco("George", 3);

        // Adiciona animais ao zoológico
        zoologico.AdicionarAnimal(leao);
        zoologico.AdicionarAnimal(elefante);
        zoologico.AdicionarAnimal(macaco);

        // Exibe informações sobre os animais no zoológico
        zoologico.ExibirAnimais();
    }
}