using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player that throws an exception when they lose to the other player
    // Where might you catch this exception????
    public class SoreLoserPlayer : Player
    {
        public SoreLoserPlayer()
        {
            Console.WriteLine($"{Name} threw a temper tantrum. They hate ties or losing!");
        }
    }
}