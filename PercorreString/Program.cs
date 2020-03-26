using System;

namespace PercorreString
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variaveis 
            string frase, carStr;
            char carAEvitar;
            
            // Solicitação da frase
            Console.WriteLine("Insira uma frase: ");
            frase = Console.ReadLine();

            //Solicitação do carater
            Console.WriteLine("Insira um carater: ");
            carStr = Console.ReadLine();

            //Converter o carater em string

            carAEvitar = Convert.ToChar(carStr);

            //Imprimir frase,exceto o carater escolhido
            foreach (char carAtual in frase)
            {
                if (carAtual != carAEvitar)
                {
                    // Em caso afirmativo, mostrar no ecrã
                    Console.WriteLine(carAtual);
                }
            }
            Console.WriteLine();

        }
    }
}
