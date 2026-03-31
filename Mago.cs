using System;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace RPG
{
    public class Mago : Personagem, IEspecial
    {
        public Mago(string nome) : base(nome, 5, 10, 20)
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
                Vida += 5;
                Console.WriteLine("Regenerou vida, agora tem: " + Vida);
                
            }
            else
            {
                double dano = (Ataque * 2) - alvo.Defesa;
                    if(dano < 0 ) dano = 0;
                alvo.ReceberDano(dano);
                Console.WriteLine(Nome + "Lancou uma Bola de Fogo e causou: " + dano);
            }
        }

    }
}