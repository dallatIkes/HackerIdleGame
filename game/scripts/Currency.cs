using System;

public class Currency
{
    private string Name { get; set; }
    public float Amount { get; private set; } = 0;
    private float Rate { get; set; } = 0;

    public Currency(string name)
    {
        Name = name;
        Rate = 1;
    }

    public void Gain(float amount)
    {
        Amount += amount;
    }

    public bool Spend(float amount)
    {
        if (Amount >= amount)
        {
            Amount -= amount;
            return true;
        }
        return false;
    }
}
