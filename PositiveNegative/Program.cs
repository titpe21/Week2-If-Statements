using System;

namespace PositiveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub sisestada numbrit
            //programm kontrollib numbrit
            //kui number on positiivne, konsool kuvab "number on positiivne";
            //kui number on negatiivne, konsool kuvab "number on negatiivne";
            //kui sisestatud number on 0, siis konsool kuvab "null";
            //NB!Int32.Parse asemel kasutame  Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("sisesta number.");
            int Number = Convert.ToInt32(Console.ReadLine());

            if (Number > 0)
            {
                Console.WriteLine("number on positiivne.");
            }
            else if (Number < 0)
            {
                Console.WriteLine("number on negatiivne.");
            }
            else
            {
                Console.WriteLine("null");
            }
        }
    }
}
