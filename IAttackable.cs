interface IAttackable
{
    int Health { get; set; }

    void TakeDamage(int amount);

    void Heal(int amount);
}