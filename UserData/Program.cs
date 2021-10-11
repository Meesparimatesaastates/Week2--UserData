using System;

namespace UserData
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat;
            //programm arvutab kasutaja vanuse;
            //programm kuvab kasutaja vanuse konsoolis;

            Console.WriteLine("palun, sisesta oma sünniaasta: ");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2021 - yearOfBirth;

            //Console.WriteLine("Sa oled " + userAge + " aastat vana.");
            //string interpolation;
            Console.WriteLine($"Sa ole {userAge} aastat vana");




        }
    }
}
