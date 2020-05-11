namespace ridbot
{
    public interface IBotConfiguration
    {
        int Damage { get; }
        int HitPoints { get; }
        int MoveRate { get; }
        int WeaponRange { get; }
    }
}