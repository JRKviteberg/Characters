public abstract class Weapon
{
    public string Description { get; set; }
    public int Damage { get; set; }

    public Weapon(string description, int damage)
    {
        Description = description;
        Damage = damage;
    }

    public abstract string AttackMessage();
}