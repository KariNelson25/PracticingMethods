using System;

namespace MethodsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            String username = Console.ReadLine();
            Console.WriteLine("What is you favorite color?");
            String color = Console.ReadLine();
            Console.WriteLine("What kind of pet do you have?");
            String userPet = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            String userFavoriteBand = Console.ReadLine();


            string message = MyMessage(username, color, userPet, userFavoriteBand);
            Console.WriteLine(MyMessage(username,color, userPet, userFavoriteBand));

            Console.WriteLine(message);
        }
        public static string MyMessage(string username, string color, string userpet, string userFavoriteBand)
        {
            var favColor = $"her favorite color is {color}";
            var faveUserPet = $"her pet is a {userpet}";
            var userFavoriteBand1 = $"and her favorite band is {userFavoriteBand}";
            return $"There was a girl named {username}{favColor}{faveUserPet}{userFavoriteBand1}";



        }
    }
    

}
