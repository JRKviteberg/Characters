public class Dagger : Weapon
{
    public Dagger() : base("A quick and light dagger.", 5) // 5 is the damage value
    {
    }

    public override string AttackMessage()
    {
        return "swiftly stabs with the dagger!";
    }
}