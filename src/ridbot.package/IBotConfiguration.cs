namespace ridbot
{
    public interface IBotConfiguration
    {
        /// <summary>
        /// Damage done if a hit is scored.
        /// </summary>
        int Damage { get; }

        /// <summary>
        /// Configured hitpoints, when it reaches 0 you are dead.
        /// </summary>
        int HitPoints { get; }

        /// <summary>
        /// Maximum distance that can be moved each turn.
        /// </summary>
        int MoveRate { get; }

        /// <summary>
        /// Range of the weapon.
        /// </summary>
        int WeaponRange { get; }
    }
}