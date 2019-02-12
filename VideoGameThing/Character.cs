using System;
using System.Collections.Generic;
using System.Text;

namespace VideoGameThing
{
    public class Character
    {
        public string Name { get; set; }
        public int HealthPoints { get; set; }
        public int AttackPower { get; set; }
        public int Movement { get; set; }

        public Character()
        {
            HealthPoints = 100;
        }
        public void Attack(Baddie target, Player attacker)
        {
            bool battle = true;
            do
            {
                Console.WriteLine("\n{0} has performed an attack against {1}!", attacker.Name, target.Name);
                target.HealthPoints -= attacker.AttackPower;
                Console.WriteLine(target.Name + "'s health is now " + target.HealthPoints);

                if (target.HealthPoints <= 0)
                {
                    target.Die();
                    battle = false;
                }
                else if (attacker.HealthPoints <= 0)
                {
                    attacker.Die();
                    battle = false;
                }
                else
                {
                    attacker.HealthPoints -= target.AttackPower;
                    Console.WriteLine("\n{0} strikes back against {1}!", target.Name, Name);
                    Console.WriteLine("{0}'s health is now {1}", attacker.Name, attacker.HealthPoints);
                    battle = false;
                }
            } while (battle);
        }

        public void Die()
        {
            Console.WriteLine(Name + " has died!");
        }

        public void Move()
        {
            Movement += Movement;
            Console.WriteLine("{0} has moved {1} spaces!", Name, Movement);
            if (Movement >= 30)
            {
                
            }
        }


    }
}
