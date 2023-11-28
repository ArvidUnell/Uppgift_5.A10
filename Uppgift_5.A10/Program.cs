using System;
namespace Uppgift_5.A10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] talArr = { 24, 2, 4, 8, 24};

            List<int> kolladeTal = new List<int>();
            List<int> anTal = new List<int>();

            for (int i = 0; i < talArr.Length; i++)
            {
                if (kolladeTal.Contains(talArr[i]))
                {
                    continue;
                }
                kolladeTal.Add(talArr[i]);

                int antal = 1;
                foreach (int tal in talArr[(i+1)..])
                {
                    if (tal == talArr[i])
                    {
                        antal++;
                    }
                }
                anTal.Add(antal);
            }

            bool första = true;
            for (int i = 0; i < anTal.Count; i++)
            {
                if (anTal[i] == anTal.Max())
                {
                    if (första)
                    {
                        Console.Write($"Följande tal är vanligast: {kolladeTal[i]}");
                        första = false;
                    }
                    else
                    {
                        Console.Write($" och {kolladeTal[i]}");
                    }
                }
            }

            Console.WriteLine("\n\nTryck på valfri knapp för att avsluta");
            Console.ReadKey();
        }
    }
}