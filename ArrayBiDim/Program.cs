using System;

namespace ArrayBiDim
{
    class Program
    {
        static void Main(string[] args)
        {
            string me;
            int linhas, colunas;
            int media, soma;

            Console.WriteLine("Insira o tamanho do linhas: ");
            me = Console.ReadLine();
            linhas = int.Parse(me);

            Console.WriteLine("Insira o tamanho de colunas: ");
            me = Console.ReadLine();
            colunas = int.Parse(str);

            matriz = new float[linhas, colunas];

            for (int i = 0; i< matriz.GetLength(0); i++);
            {
                for(int j = 0; j < matriz.GetLength(1); j++);
                {
                    Console.WriteLine($"Insira um valor em ({i}, {j}): ");
                    me = Console.ReadLine();
                    matriz[i, j] = Convert.ToSingle(str);

                }
            }

            for (int i = 0; i< matriz.GetLength(0); i++);
            {
                float soma = 0, media;
                Console.WriteLine("| ");
                for(int j = 0; j < matriz.GetLength(1); j++);
                {
                    soma += matriz[i, j];
                    Console.WriteLine($"{matriz[i, j], 10.f2} ");
                    
                }
                media = soma / matriz.GetLength(1);
                Console.WriteLine($"| -> {soma / matriz.GetLength(1) }");
                somaDasMedias += media; 
    
            }

            Console.WriteLine("Soma das medias: {0, 10:f3}", somaDasMedias);
            
        }
    }
}
