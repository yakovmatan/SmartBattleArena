public class BattleRobot : IPowerable , IAttackable, IMovable
{
    public bool IsOn { get; set; } = false;

    public int Health { get; set; }

    
    public void TurnOn()
    {
        IsOn = true;
    }

    public void TurnOff()
    {
        IsOn = false;
    }

    public void TakeDamege(int amount)
    {
        Health -= amount;
    }

    public void Heal(int amount)
    {
        Health += amount;
    }



}