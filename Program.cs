namespace LAB5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Circle positiveRadius = new Circle();
				positiveRadius.SetRadius(2.0);
				Console.WriteLine(positiveRadius.ToString());

				Circle negativeRadius = new Circle();
				negativeRadius.SetRadius(-2.0);
				Console.WriteLine(negativeRadius.ToString());

				Circle zeroRadius = new Circle();
				zeroRadius.SetRadius(0.0);
				Console.WriteLine(zeroRadius.ToString());
			}
			catch (InvalidRadiusException)
			{
				
			}
			try
			{
				Circle zeroRadius = new Circle();
				zeroRadius.SetRadius(0.0);
				Console.WriteLine(zeroRadius.ToString());
			}
			catch (InvalidRadiusException)
			{

			}
		}
	}
}
