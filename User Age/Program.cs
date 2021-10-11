using System;

namespace User_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust;
            //programm arvutab kasutaja sünniaasta;
            //programm kirjutab consoolis kasutaja sünniaasta;
            Console.WriteLine("palun, sisesta oma vanus: ");
            int userAge = Convert.ToInt32(Console.ReadLine());

            int dateOfBirth = 2021 - userAge;

            //Console.WriteLine("Sa oled sündinud " + dateOfBirth + " aastal.");
            //string interpolation;
            Console.WriteLine($"Sa oled sündinud {dateOfBirth} aastal");
        }
    }
}
