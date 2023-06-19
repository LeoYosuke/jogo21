using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula09Correcao21
{
    class Program
    {
        static void Main(string[] args)
        {
            Random sorte = new Random();
            int pontos = 0;
            Console.WriteLine("Bem-vindo ao jogo do 21!!");
            Console.WriteLine("seu objetivo é chegar proximo ou 21 pontos");

            while (true) 
            {
                Console.WriteLine($"você tem {pontos} pontos");
                Console.WriteLine("Deseja continuar ? \n1 - sim\n2 - não");
                int opcao = int.Parse(Console.ReadLine());
                if(opcao == 2) 
                {
                    Console.WriteLine("FIM!!");
                    Console.ReadKey();
                    break;
                }
                int numero = sorte.Next(1, 11);
                Console.WriteLine($"Você tirou o numero {numero}");

                pontos += numero;
                if(pontos > 21) 
                {
                    Console.WriteLine("Ah que pena você perdeu");
                    Console.ReadKey();
                    break;
                }
                
            }
            
        }
    }
}
