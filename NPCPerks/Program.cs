using System;

namespace NPCPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variaveis 
            Perks[] perks;
            
            string numero;
            int numNPCs;

            // Solicitação do numero de npcs e conversão
            Console.WriteLine("Insira o numero de NPCs: ");
            numero = Console.ReadLine();
            numNPCs = Convert.ToInt32(numero);

            // Inicializar array de Perks
            perks = new Perks[numNPCs];


            // Pedir Perks para cada NPC
            for (int i = 0; i < numNPCs; i++)
            {
                // For Stealth
                Console.WriteLine($"NPC {i} tem Stealth (s/n)? ");
                numero = Console.ReadLine();
                if (numero.ToLower() == "s")
                {
                    perks[i] |= Perks.Stealth;
                }
                
                // For Combat
                Console.WriteLine($"NPC {i} tem Combat (s/n)? ");
                numero = Console.ReadLine();
                if (numero.ToLower() == "s")
                {
                    perks[i] |= Perks.Combat;
                }

                // For Lockpick
                Console.WriteLine($"NPC {i} tem Lockpick (s/n)? ");
                numero = Console.ReadLine();
                if (numero.ToLower() == "s")
                {
                    perks[i] |= Perks.Lockpick;
                }
                
                // For Luck
                Console.WriteLine($"NPC {i} tem Luck (s/n)? ");
                numero = Console.ReadLine();
                if (numero.ToLower() == "s")
                {
                    perks[i] |= Perks.Luck;
                }

            }
            Console.WriteLine();



            for (int i = 0; i < numNPCs;i++)
            {   
                Perks p = Perks.Combat | Perks.Luck; 
                Console.WriteLine($"Perks atributos {i}: {perks [i]}");

                if ((perks[i] & p) == p)
                {
                    Console.WriteLine("\tyou shall win all fights!");
                }
            }


            
        }
    }
}
