using System;

namespace ridbot
{
    public interface IGameEntity
    {
        /// <summary>
        /// Guid used to uniquely identify the object.
        /// </summary>
        Guid Id { get; }

        /// <summary>
        /// Name of the object, this should be but may not be unique.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Type of entity.
        /// </summary>
        EntityTypeEnum Entity { get; }

        /// <summary>
        /// Current position of the object.
        /// </summary>
        Position Position { get; set; }

        /// <summary>
        /// Is the player currently alive, dead players are removed from the game at the end of the turn.
        /// This will be false for non-player objects.
        /// </summary>
        bool Alive { get; }

        /// <summary>
        /// Current health percentage of the target.
        /// This will be 0 for non-player objects.
        /// </summary>
        double HealthPercentage { get; }
    }
}