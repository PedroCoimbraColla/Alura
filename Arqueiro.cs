using System;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace RPG
{
    public class Arqueiro : Personagem, IEspecial
    {
        public Arqueiro(string nome) : base(nome, 5, 5, 5)
        {
            
        }

        public override void Atacar(Personagem alvo)
        {
                double dano = Ataque - alvo.Defesa;
                    if(dano < 0 ) dano = 0;
                alvo.ReceberDano(dano);
                    Console.WriteLine("Causou: " + dano + " de dano");
        }

        public void UsarEspecial(Personagem alvo)
        {
            Random rnd = new Random();
            int min = 1;
            int max = 10;
            int randomNumber = rnd.Next(min, max);
            if(randomNumber == 10)
            {
                double dano = (Ataque * 10) - alvo.Defesa;
                    if(dano < 0 ) dano = 0;
                alvo.ReceberDano(dano);
                Console.WriteLine("Realizou um ataque Devastador de: " + dano);
            }
            else
            {
                Ataque += 1;
                Console.WriteLine(Nome + "Aumentou seu Dano");
            }
        }



    }
}