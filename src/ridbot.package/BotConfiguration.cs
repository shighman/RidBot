using System;

namespace ridbot
{
    public sealed class BotConfiguration : IBotConfiguration
    {
        public int MoveRate { get; }
        public int WeaponRange { get; }
        public int Damage { get; }
        public int HitPoints { get; }

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