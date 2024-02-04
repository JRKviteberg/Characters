public abstract class Character
{
    public string Name { get; set; }
    public string Description { get; set; }
    protected Weapon EquippedWeapon;

    public Character(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void EquipWeapon(Weapon weapon)
    {
        EquippedWeapon = weapon;
    }

    public virtual string Attack()
    {
        if (EquippedWeapon == null)
        {
            return $"{Name} attacks with their fists!";
        }
        else
        {
            return EquippedWeapon.AttackMessage();
        }
    }
}