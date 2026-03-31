using System;
namespace RPG
{
class Program
{
    static void Main()
    {
        Console.WriteLine("=== MINI RPG ===");

        Personagem jogador1 = EscolherPersonagem("Jogador 1");
        Personagem jogador2 = EscolherPersonagem("Jogador 2");

        while (jogador1.Vida > 0 && jogador2.Vida > 0)
        {
            Console.WriteLine("\n--- STATUS ---");
            jogador1.ExibirStatus();
            jogador2.ExibirStatus();

            // Turno jogador 1
            Console.WriteLine("\nTurno de " + jogador1.Nome);
            Console.WriteLine("1 - Ataque");
            Console.WriteLine("2 - Especial");

            int escolha1 = int.Parse(Console.ReadLine());

            if (escolha1 == 1)
                jogador1.Atacar(jogador2);
            else
                ((IEspecial)jogador1).UsarEspecial(jogador2);

            if (jogador2.Vida <= 0)
                break;

            // Turno jogador 2
            Console.WriteLine("\nTurno de " + jogador2.Nome);
            Console.WriteLine("1 - Ataque");
            Console.WriteLine("2 - Especial");

            int escolha2 = int.Parse(Console.ReadLine());

            if (escolha2 == 1)
                jogador2.Atacar(jogador1);
            else
                ((IEspecial)jogador2).UsarEspecial(jogador1);
        }

        Console.WriteLine("\n=== FIM DE JOGO ===");

        if (jogador1.Vida > 0)
            Console.WriteLine(jogador1.Nome + " venceu!");
        else
            Console.WriteLine(jogador2.Nome + " venceu!");
    }

    static Personagem EscolherPersonagem(string jogador)
    {
        Console.WriteLine("\n" + jogador + ", escolha seu personagem:");
        Console.WriteLine("1 - Guerreiro");
        Console.WriteLine("2 - Mago");
        Console.WriteLine("3 - Arqueiro");

        int escolha = int.Parse(Console.ReadLine());

        if (escolha == 1)
            return new Guerreiro("Guerreiro");
        else if (escolha == 2)
            return new Mago("Mago");
        else
            return new Arqueiro("Arqueiro");
    }
}
}