using System;

namespace AulaPOOConstrutor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jogadores de basquete\n");
            Jogador jordan = new Jogador("Michael Jordan", 1.98f, "Ala-armador", 95, 98, 95, 99, 88, 82, 98, 77);
            Console.WriteLine("Nome: "+jordan.Nome);
            Console.WriteLine("Altura: "+jordan.Altura);
            Console.WriteLine("Posição: "+jordan.Posicao);
            Console.WriteLine("Velocidade: "+jordan.Velocidade);
            Console.WriteLine("Pulo vertical: "+jordan.PuloVertical);
            Console.WriteLine("Arremesso: "+jordan.Arremesso);
            Console.WriteLine("Finalização: "+jordan.Finalizacao);
            Console.WriteLine("Controle de bola: "+jordan.Controle);
            Console.WriteLine("Passe: "+jordan.Passe);
            Console.WriteLine("Defesa: "+jordan.Defesa);
            Console.WriteLine("Rebote: "+jordan.Rebote);

            Console.WriteLine("");

            Jogador bird = new Jogador("Larry Bird", 2.06f, "Ala", 72, 65, 99, 85, 75, 98, 88, 90);
            Console.WriteLine("Nome: "+bird.Nome);
            Console.WriteLine("Altura: "+bird.Altura);
            Console.WriteLine("Posição: "+bird.Posicao);
            Console.WriteLine("Velocidade: "+bird.Velocidade);
            Console.WriteLine("Pulo vertical: "+bird.PuloVertical);
            Console.WriteLine("Arremesso: "+bird.Arremesso);
            Console.WriteLine("Finalização: "+bird.Finalizacao);
            Console.WriteLine("Controle de bola: "+bird.Controle);
            Console.WriteLine("Passe: "+bird.Passe);
            Console.WriteLine("Defesa: "+bird.Defesa);
            Console.WriteLine("Rebote: "+bird.Rebote);
        }
    }
}
