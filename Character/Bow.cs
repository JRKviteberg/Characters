public class Bow : Weapon
{
    public Bow() : base("A long-range bow.", 8) // 8 is the damage value
    {
    }

    public override string AttackMessage()
    {
        return "shoots an arrow from the bow!";
    }
}