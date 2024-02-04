public class Staff : Weapon
{
    public Staff() : base("A mystical staff imbued with magical powers.", 7) // 7 is the damage value
    {
    }

    public override string AttackMessage()
    {
        return "casts a spell with the staff!";
    }
}