using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player that throws an exception when they lose to the other player
    // Where might you catch this exception????
    public class ILost : Exception
    {
        public ILost()
            : base($"Sore Loser threw a temper tantrum. They hate ties or losing!") { }
    }
}