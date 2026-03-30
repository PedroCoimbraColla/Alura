using System;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace RPG
{
    public class Personagem
    {
        public string Nome { get; set; }
        public double Vida { get; set; }  
        public double Ataque { get; set; }
        public double Defesa {get; set;}

        public Personagem (string nome, double vida, double ataque, double defesa)
        {
            Nome = nome;
            Vida = vida;
            Ataque = ataque;
            Defesa = defesa;
        }
        public virtual void Atacar(Personagem alvo)
        {
            double dano = Ataque - Defesa;
            if(dano < 0 ) dano = 0;

            alvo.ReceberDano(dano);
        }
        public void ReceberDano(int dano)
        {
            Vida -= dano;
        }

        public void exiberStatus()
        {
            Console.WriteLine("Nome: " + Nome + "\n" + 
                              "Vida: " + Vida + "\n" + 
                              "Ataque: " + Ataque + "\n" + 
                              "Defesa: " + Defesa + "\n");
        }

    }
}