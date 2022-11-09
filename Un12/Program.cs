using System;
using System.Threading;

namespace SFUnit12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User usr1 = new User("Betman", "Иван", true);
            User usr2 = new User("Pig", "Анна", false);

            HelloUserDemo(usr1);
            HelloUserDemo(usr2);

        }
        static void HelloUserDemo(User user)
        {
            Console.WriteLine($"Приветствую, {user.Name}");
            if (user.IsPremium == false)
            {
                ShowAds();
            }
        }

        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум - подписку на наш сервис, чтобы не видеть рекламу.");
            Thread.Sleep(3000);
        }
    }
}
