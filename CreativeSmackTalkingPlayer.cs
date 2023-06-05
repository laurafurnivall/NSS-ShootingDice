using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        public string Taunt { get; }

        List<string> taunts = new List<string>()
        {
            "you Suck!",
            "you couldn't win even if you used rolled with weighted dice!",
            "wow. That's all you got?",
            "a dog could throw that better than you!"
        };

        public override int Roll()
        {
            Random random = new Random();
            int index = random.Next(taunts.Count);

            Console.WriteLine($"{Name} says {taunts[index]}");
            return new Random().Next(DiceSize) + 1;

        }

    }
}