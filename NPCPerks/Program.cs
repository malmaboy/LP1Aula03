using System;

namespace NPCPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            Perks[] perks;
            
            string numero;
            int numNPCs;


            Console.WriteLine("Insira o numero de NPCs: ");
            numero = Console.ReadLine();
            numNPCs = Convert.ToInt32(numero);
            perks = new Perks[numNPCs];

            for (int i = 0; i < numNPCs; i++)
            {
                Console.WriteLine($"NPC {i} tem Stealth (s/n)? ");
                numero = Console.ReadLine();
                if (numero.ToLower() == "s")
                {
                    perks[i] |= Perks.Stealth;
                }

                Console.WriteLine($"NPC {i} tem Combat (s/n)? ");
                numero = Console.ReadLine();
                if (numero.ToLower() == "s")
                {
                    perks[i] |= Perks.Combat;
                }

                Console.WriteLine($"NPC {i} tem Lockpick (s/n)? ");
                numero = Console.ReadLine();
                if (numero.ToLower() == "s")
                {
                    perks[i] |= Perks.Lockpick;
                }

                Console.WriteLine($"NPC {i} tem Luck (s/n)? ");
                numero = Console.ReadLine();
                if (numero.ToLower() == "s")
                {
                    perks[i] |= Perks.Luck;
                }

            }
            Console.WriteLine();



            for (int i =0;i<0;i++)
            {   
                Perks p = Perks.Combat | Perks.Luck; 
                Console.WriteLine($"Perks atributos {i}: {perks [i]}");

                if ((perks[i] & p) == p)
                {
                    Console.WriteLine("\tyou shall win all fights");
                }
            }


            
        }
    }
}
