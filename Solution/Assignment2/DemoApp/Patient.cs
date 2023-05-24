class Patient
{
    private int PatientId
    {
        get;
    }
    private int BedType
    {
        get;
        set;
    }
    internal int Days
    {
        get;
        set;
    }
    public Patient(int p, int b, int d)
    {
        PatientId = p;
        BedType = b;
        Days = d;
    }
    public double GetPricePerDay()
    {
        switch(BedType)
        {
            case 1 :
                    return 500;
            case 2 :
                    return 350;
            case 3 :
                    return 200;
            default :
                    return 250;
        }
    }
    public virtual double GetBill()
    {
        return Days * GetPricePerDay();
    }
}