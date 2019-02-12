using System;
using System.Collections.Generic;
using System.Text;

namespace VideoGameThing
{
    public class Baddie : Character
    {
        public bool Alive = true;
        public Baddie()
        {
            Name = "Villian";
            HealthPoints = 100;
            AttackPower = 5;
            Movement = 2;

        }

        
    }
}
