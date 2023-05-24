namespace banking;

public abstract class Loan
{
    private double principle;
    private float period;

    public double Principle{
        get;
        set;
    }
    public float Period
    {
        get;
        set;
    }
    protected Loan(double Principle, float Period)
    {
        this.Principle = Principle;
        this.Period = Period;
    }
    public abstract float GetRate();
    public double GetEMI()
    {
        float r= GetRate();
        return Principle * (1 + r * Period/100) / (12 * Period);
    }
}