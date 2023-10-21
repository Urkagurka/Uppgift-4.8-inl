using System;

namespace Uppgift_4._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in en lång sträng");
            string Lång = Console.ReadLine();
            Console.WriteLine("Skriv in en kort sträng på 2 bokstäver");
            string Kort = Console.ReadLine();

            string hittade = "";

            for (int i = 0; i < Kort.Length; i++)
            {
                char hitta = Kort[i];

                for (int j = 0; j < Lång.Length; j++)
                {
                    char leta = Lång[j];
                    if (hitta == leta)
                    {
                        hittade = hittade + hitta;
                        break;
                    }
                }
            }
            if (hittade == Kort)
            {
                Console.WriteLine("Bokstäverna finns");
            }
            else
            {
                Console.WriteLine("Alla fanns inte");
            }
        }
    }
}