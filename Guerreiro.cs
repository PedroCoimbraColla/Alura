using System;
using System.Random;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace RPG.Personagem
{
    public class Guerreiro : Personagem
    {
        public Guerreiro(string nome) : base(nome, 10, 10, 10)
        {
            
        }

        public override Atacar(Personagem alvo)
        {
            Random rnd = new Random();
            int min = 1;
            int max = 10;
            int randomNumber = rnd.Next(min, max);
            if(randomNumber = 10)
            {
                double dano = (Ataque + 10) - alvo.Defesa;
                    if(dano < 0 ) dano = 0;
                alvo.ReceberDano(dano);
            }
            else
            {
                double dano = Ataque - alvo.Defesa;
                    if(dano < 0 ) dano = 0;
                alvo.ReceberDano(dano);
            }
        }

        public void usarEspecial()
        {
            
        }



    }
}