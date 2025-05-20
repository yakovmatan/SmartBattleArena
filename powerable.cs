interface IPowerable
{
    bool IsOn { get; set; }

    void TurnOn();

    void TurnOff();
}