using System;

namespace PermanentDrivingLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm kontrollib kasutaja vanust 
            //program teatab kasutajat, kas ta on piisavalt vana
            //et juhiluba saada
            Console.WriteLine("Sisesta oma sünniaastat:");

            int YearOfBirth = Int32.Parse(Console.ReadLine());
            int Age = 2021 - YearOfBirth;

            if (Age >= 18)
            {
                Console.WriteLine("Oled piisavalt vana, et juhiluba saada.");
            }
            else
            {
                Console.WriteLine("Liiga noore, juhiluba saada.");
            }






            /*if(Age > 18)
            {
                Console.WriteLine("Oled piisavalt vana, et juhiluba saada.");
            } 
            else if(Age < 18)
            {
                Console.WriteLine("Liiga noore, juhiluba saada");
            }
            else
            {
                Console.WriteLine("Oled 18, nüüd saada juhiluba saada.");
            }*/

           

        } 
    }
}
