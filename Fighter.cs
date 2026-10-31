using System;
using System.Collections.Generic;
using System.Text;

namespace Monsterduellen
{
    internal class Fighter
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }

        public Fighter(string name, int health, int strength)
        {
            Name = name;
            Health = health;
            Strength = strength;
        }

        public void Attack(Fighter target)
        {
            int damage = Random.Shared.Next(1, this.Strength + 1);
            target.Health = Math.Max(0, target.Health - damage);
            Console.WriteLine(this.Name + " attackerar " + target.Name + " och gör " + damage + " skada!");
        }
    }
}
            
