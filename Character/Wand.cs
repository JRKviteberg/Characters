public class Wand : Weapon
{
    public Wand() : base("A small but powerful magical wand.", 6) // 6 is the damage value
    {
    }

    public override string AttackMessage()
    {
        return "waves the wand, releasing magical energy!";
    }
}