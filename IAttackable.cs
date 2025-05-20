interface IAttackable
{
    int Health { get; set; }

    void TakeDamege(int amount);

    void Heal(int amount);
}