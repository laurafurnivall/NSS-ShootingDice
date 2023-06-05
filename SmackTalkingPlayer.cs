using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public string Taunt { get; }

        public SmackTalkingPlayer()
        {
            Taunt = "Yo' mama could roll dice better than you!";
        }

        public override int Roll()
        {
            // Return a random number between 1 and DiceSize
            Console.WriteLine($"{Name} says {Taunt}");
            return new Random().Next(DiceSize) + 1;

        }
    }
}