using System;

namespace facade
{
	public class TheaterLights
	{

		public virtual void dim(int i)
		{
			Console.WriteLine("Light is dimming to " + i + " %");
		}

		public virtual void on()
		{
			Console.WriteLine("Light is on");
		}
	}

}