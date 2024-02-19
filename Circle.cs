using System;
namespace LAB5 {
	public class Circle
	{
		private double radius;

		public double Radius
		{
			get { return radius; }
			set { SetRadius(value); }
		}

		public void SetRadius(double value)
		{
			if (value > 0)
			{
				radius = value;
			}
			else
			{
				throw new InvalidRadiusException(value);
			}
		}

		public override string ToString()
		{
			return $"The radius of your circle is {radius}.";
		}
	}
}