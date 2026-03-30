using System;
using System.Random;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace RPG.Personagem
{
    public class Mago : Personagem
    {
        public Mago(string nome) : base(nome, 10, 10, 10)
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