class Program
{   
    public static void Main(string[] args)
	{
		
		int id=int.Parse(args[0]);
		int bt=int.Parse(args[1]);
		int day=int.Parse(args[2]);

		Patient jack= new Patient(id, bt, day);
		Console.WriteLine("Bill of Patient Jack :{0}", jack.GetBill());

		InHousePatient jill= new InHousePatient(id, bt, day);
		Console.WriteLine("Bill of Patient Jill : {0}", jill.GetBill());

	}
}
