namespace Monsterduellen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Välkommen! Ange ett namn för din hjälte: ");
            string nameOfHero = Console.ReadLine();

            Fighter hero = new Fighter(nameOfHero, 30, 8);
            Fighter monster = new Fighter("Goblin", 25, 5);

            Console.WriteLine("Din hjälte: " + nameOfHero + " möter monstret: " + monster.Name + "!");
            Console.WriteLine();
            Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine(hero.Name + " hälsa: " + hero.Health);
            Console.WriteLine(monster.Name + " hälsa: " + monster.Health);
            Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");

            int round = 1;

            Console.WriteLine();
            Console.WriteLine("Tryck Enter för att starta striden...");
            Console.ReadLine();

            while (hero.Health > 0 && monster.Health > 0)
            {
               

                Console.WriteLine();
                Console.WriteLine("========== Runda " + round + " ==========");

                Console.WriteLine(monster.Name + " hälsa: " + monster.Health);
                hero.Attack(monster);
                Console.WriteLine(monster.Name + " hälsa: " + monster.Health);
                Console.WriteLine("-------------------------------------------------");

                if (monster.Health > 0)
                {
                    Console.WriteLine(hero.Name + " hälsa: " + hero.Health);
                    monster.Attack(hero);
                    Console.WriteLine(hero.Name + " hälsa: " + hero.Health);
                    Console.WriteLine("-------------------------------------------------");
                }
                if (hero.Health > 0 && monster.Health > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Tryck Enter för nästa runda...");
                    Console.ReadLine();
                }

                round++;
            }
            if (monster.Health <= 0)
            {
                Console.WriteLine(hero.Name + " vann striden!");
                Console.WriteLine(hero.Name + " hälsa: " + hero.Health);
            }
            else if (hero.Health <= 0)
            {
                Console.WriteLine(monster.Name + " vann striden!");
                Console.WriteLine(monster.Name + " hälsa: " + monster.Health);
            }
        }
    }
}
               
                


                    
