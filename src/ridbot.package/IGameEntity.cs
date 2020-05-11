using System;

namespace ridbot
{
    public interface IGameEntity
    {
        string Name { get; }

        EntityTypeEnum Entity { get; }

        Guid Id { get; }

        Position Position { get; set; }

        bool Dead { get; }
    }
}