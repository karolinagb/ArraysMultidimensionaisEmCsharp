using System;

namespace JaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //família 1: Família Flintstones
            //família 2: Família Simpsons
            //família 3: Família Dona Florinda

            //JAGGED ARRAY = ARRAY DENTEADO = ARRAY SERRILHADO
            //Temos que dizer que nao sabemos qual é a segunda dimensão

            string[][] familias = new string[3][];
            //{
            //     { "Fred", "Wilma", "Pedrita" },
            //     { "Homer", "Marge", "Lisa", "Bart", "Maggie" },
            //     { "Florinda", "Kiko" }
            //};

            //Ao informar quem sao as familias eu n informo a segunda dimensão
            familias[0] = new string[] { "Fred", "Wilma", "Pedrita" };
            familias[1] = new string[] { "Homer", "Marge", "Lisa", "Bart", "Maggie" };
            familias[2] = new string[] { "Florinda", "Kiko" };

            foreach (var familia in familias)
            {
                Console.WriteLine(string.Join(",", familia));
            }
        }
    }
}
