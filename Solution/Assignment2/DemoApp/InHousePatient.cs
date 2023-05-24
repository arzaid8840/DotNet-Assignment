class InHousePatient : Patient
{
    private double discount;
    public InHousePatient(int i, int b, int d) : base(i, b, d)
    {
        discount = 10;
    } 
    public override double GetBill()
	{
		double amount = (100-discount) * base.Days * GetPricePerDay()/100;
		return amount;
	}
}