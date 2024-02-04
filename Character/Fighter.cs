public class Fighter : Character
{
    public Fighter(string name, string description) : base(name, description)
    {
    }

    public override string Attack()
    {
        string attackMethod = EquippedWeapon == null ? "fists" : EquippedWeapon.Name;
        return $"{Name} swings their {attackMethod} fiercely!";
    }
}   