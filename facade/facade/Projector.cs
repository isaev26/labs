using System;

namespace facade
{
	public class Projector
	{

		public virtual void on()
		{
			Console.WriteLine("Projector is on");
		}

		public virtual void wideScreenMode()
		{
			Console.WriteLine("Projector is in wideScreenMode");
		}

		public virtual void off()
		{
			Console.WriteLine("Projector is off");
		}
	}

}