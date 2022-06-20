using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Consolecode
{
    class Program
    {
        static Player player;
        static Random random;
        static void Main(string[] args)
        {
            random = new Random();
            player = new Player();

        go:
            Console.Clear();
            Console.WriteLine("1: Play\n2: Load\n3: Exit");

            ConsoleKey key = GetButton();
            Console.Clear();

            if(key == ConsoleKey.D1)
            {
                Console.WriteLine("Введите имя:");
                player.Name = Console.ReadLine();
                Console.WriteLine("Здравствуйте " + player.Name);
                Thread.Sleep(2000);
                Game();
            }
            else if (key == ConsoleKey.D2)
            {

            }
            else if (key == ConsoleKey.D3)
            {

            }
            else
            {
                Console.WriteLine("Еще раз!");
                Thread.Sleep(2000);
                goto go;
            }
        }
        public static void Game()
        {
            Console.Clear();
            Console.WriteLine("После долгой ночи вы проснулись в лесу.");
            Thread.Sleep(3500);
        go:
            Console.Clear();
            Console.WriteLine("1: Информация\n2: Инвентарь\n3: Исследовать\n4: Охота");
            ConsoleKey key = GetButton();

            if (key == ConsoleKey.D1)
            {
                Console.WriteLine($"Имя: {player.Name}");
                Console.WriteLine($"HP: {player.Health}/{player.HealthMax}");
                Console.WriteLine($"Power: {player.Power}/{player.PowerMax}");
                Console.WriteLine($"Нажмите на любую кнопку");
                Console.ReadKey();
                goto go;
            }
            else if (key == ConsoleKey.D2)
            {
                player.Inventory.GetAllItems();
            }
            else if (key == ConsoleKey.D3)
            {
                if (player.Power > 0)
                {
                    Explore();
                    player.Power--;
                    Console.WriteLine("Ваша энергия - " + player.Power);
                }
                else
                    Console.WriteLine("У вас недостаточно энергии");
            }
            else if (key == ConsoleKey.D4)
            {

            }
            else
            {
                Console.WriteLine("Еще раз!");
                Thread.Sleep(2000);
                goto go;
            }
            Console.WriteLine("Нажмите на любую кнопку");
            Console.ReadKey();
            goto go;
        }
        public static void Explore()
        {
            int ran = random.Next(0, 30);

            if (ran <= 5)
            {
                Console.WriteLine("Вы нашли пещеру");
            }
            else if (ran <= 10)
            {
                Console.WriteLine("Вы нашли сундук");
            }
            else if (ran <= 15)
            {
                Console.WriteLine("Вы нашли кристал");
            }
            else
            {
                Console.WriteLine("Вы ничего не нашли"); 
            }

        }
      
        public static ConsoleKey GetButton()
        {
            var but = Console.ReadKey(true).Key;
            return but;
        }
        
    }
}
    

