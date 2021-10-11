using System;

namespace InstagramAgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust;
            //programm kontrollib, kas kasutaja on vanem kui 13 või 13 aastat vana;
            //kui kasutaja on 13 aastat vana vöi vanem, siis ta võib instagrammi kasutada;
            //kui kasutaja on noorem kui 13 siis ta ei saa instagrammi kasutada;

            Console.WriteLine("Palun sisesta oma vanus");
            int userAge = Convert.ToInt32(Console.ReadLine());
            if(userAge > 13)
            { Console.WriteLine("Oled piisavalt vana, et kasutada instagrammi"); }
            else if(userAge < 13)
            {
                Console.WriteLine("oled liiga noor et instagrammi kasutada");
            }
            else
            { Console.WriteLine("Oled piisavalt vana, et kasutada instagrammi"); }

            Console.WriteLine("kena päeva");

            


        }
    }
}
