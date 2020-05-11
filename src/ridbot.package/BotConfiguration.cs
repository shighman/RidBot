using System;

namespace ridbot
{
    public sealed class BotConfiguration : IBotConfiguration
    {
        public int MoveRate { get; }
        public int WeaponRange { get; }
        public int Damage { get; }
        public int HitPoints { get; }

        /// <summary>
        /// Ctor for bot configuration a total of 100 points may be spent on the 4 attributes
        /// </summary>
        /// <param name="moveRate">0-100 amount of distance that can be moved each turn (1 is added to this value)</param>
        /// <param name="range">0-100 weapon range, anything outside this range cannot be hit (1 is added to this value)</param>
        /// <param name="damage">0-100 amount of damage if hit is scored(1 is added to this value)</param>
        /// <param name="hitPoints">0-100 amount of damage which can be sustained(1 is added to this value and then multiplied by 5)</param>
        public BotConfiguration(ushort moveRate, ushort range, ushort damage, ushort hitPoints)
        {
            if (moveRate + range + damage + hitPoints > 100)
                throw new ArgumentException("You only get 100 points to spend!");
            MoveRate = moveRate + 1;
            WeaponRange = range + 1;
            Damage = damage + 1;
            HitPoints = (hitPoints + 1) * 5;
        }
    }
}