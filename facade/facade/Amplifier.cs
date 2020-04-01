using System;

namespace facade
{
	public class Amplifier
	{

		public virtual void setSurroundSound()
		{
			Console.WriteLine("Amplifier surround sound");
		}

		public virtual DvdPlayer Dvd
		{
			set
			{
				Console.WriteLine("Amplifier setting DVD");
			}
		}

		public virtual void on()
		{
			Console.WriteLine("Amplifier is on");
		}

		public virtual int Volume
		{
			set
			{
				Console.WriteLine("Amplifier is setting volume to " + value + "%");
			}
		}

		public virtual void off()
		{
			Console.WriteLine("Amplifier is off");
		}

	}

}