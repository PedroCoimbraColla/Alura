using System;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace RPG
{
    public class Guerreiro : Personagem, IEspecial
    {
        public Guerreiro(string nome) : base(nome, 15, 20, 10)
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
                double dano = (Ataque * 2) - alvo.Defesa;
                    if(dano < 0 ) dano = 0;
                alvo.ReceberDano(dano);
                Console.WriteLine("Realizou um ataque poderoso de: " + dano);
            }
            else
            {
                double dano = (Ataque + 2) - alvo.Defesa;
                    if(dano < 0 ) dano = 0;
                alvo.ReceberDano(dano);
                Console.WriteLine("Ataque rapido de: " + dano);
            }
        }



    }
}