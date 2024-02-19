using System;
namespace LAB5
{
	public class InvalidRadiusException : Exception
	{
		public InvalidRadiusException()
		{
			Console.WriteLine("Radius must be greater than 0.");
		}

		public InvalidRadiusException(double radius)
		{
			Console.WriteLine($"The radius {radius} is not valid.");
		}

	}
}