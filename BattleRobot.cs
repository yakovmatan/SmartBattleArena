public class BattleRobot : IPowerable , IAttackable, IMovable
{
    public bool IsOn { get; set; } = false;

    
    public void TurnOn()
    {
        IsOn = true;
    }

    public void TurnOff()
    {
        IsOn = false;
    }



}