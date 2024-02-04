public class Sword : Weapon
{
    public Sword() : base("A sharp and sturdy sword.", 10) // 10 is the damage value
    {
    }

    public override string AttackMessage()
    {
        return "slashes with the sword!";
    }
}