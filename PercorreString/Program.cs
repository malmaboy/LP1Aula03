using System;

namespace PercorreString
{
    class Program
    {
        static void Main(string[] args)
        {
            string yo, mee;
            

            Console.WriteLine("Insira uma frase: ");
            yo = Console.ReadLine();
            
            Console.WriteLine("Insira um carater: ");
            mee = Console.ReadLine();

            foreach (char me in yo)
            {
                if (me != mee)
                {
                    Console.WriteLine(me);
                }
            }
            Console.WriteLine();

        }
    }
}
