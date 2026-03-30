using System;
using System.Random;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace RPG.Personagem
{
    public class Arqueiro : Personagem
    {
        public Arqueiro(string nome) : base(nome, 5, 5, 5)
        {
            
        }

        public override Atacar(Personagem alvo)
        {
                double dano = Ataque - alvo.Defesa;
                    if(dano < 0 ) dano = 0;
                alvo.ReceberDano(dano);
        }

        public void usarEspecial()
        {
            
        }



    }
}