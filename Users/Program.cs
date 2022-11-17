using System;
using System.Runtime.Serialization;

namespace Users
{
    internal class Program
    {
        static void Main()
        {
            User user = new User();

            Console.WriteLine("Введите логин:");
            user.Login = Console.ReadLine();

            Console.WriteLine("Введите имя:");
            user.Name = Console.ReadLine();

            Console.WriteLine($"Здравствуйте, {user.Name}");

            Console.WriteLine("Оформить премиум-подписку (напишите Да или Нет)?");
            string subs = Console.ReadLine();

            if (subs == "Да")
            {
                user.IsPremium = true;
                Console.WriteLine("Премиум-подписка оформлена!");
            }    
            else
            {
                user.IsPremium = false;
                ShowAds();
            }

        }
        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }

}