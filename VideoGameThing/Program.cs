using System;

namespace VideoGameThing
{
    class Program
    {
        static void Main(string[] args)
        {
            var hero = new Player();
            var villain = new Baddie();
            var superVillain = new Baddie();
            int currentHealth = hero.HealthPoints;
            Title();
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("An enemy approaches!");
            hero.Move();
            villain.Move();
            Console.WriteLine("Press ENTER to attack!");
            Console.ReadKey();
            Console.Clear();

            hero.Attack(villain, hero);
            hero.Attack(villain, hero);
            hero.Attack(villain, hero);
            hero.Attack(villain, hero);
            hero.Attack(villain, hero);

        }

        public static void Title()
        {
            Console.WriteLine(@" _____ _   _  _____  ______ _   _ _   _ _____  _____ _____ _   _ 
|_   _| | | ||  ___| |  _  \ | | | \ | |  __ \|  ___|  _  | \ | |
  | | | |_| || |__   | | | | | | |  \| | |  \/| |__ | | | |  \| |
  | | |  _  ||  __|  | | | | | | | . ` | | __ |  __|| | | | . ` |
  | | | | | || |___  | |/ /| |_| | |\  | |_\ \| |___\ \_/ / |\  |
  \_/ \_| |_/\____/  |___/  \___/\_| \_/\____/\____/ \___/\_| \_/
                                                                 
                                                                 ");
        }
    }
}

