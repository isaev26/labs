using System;

namespace facade
{
	public class DvdPlayer
	{

		public virtual void on()
		{
			Console.WriteLine("DVD player is on");
		}

		public virtual void play(string movie)
		{
			Console.WriteLine("DVD player is playing movie :" + movie);
		}

		public virtual void stop()
		{
			Console.WriteLine("DVD player is stopped");
		}

		public virtual void eject()
		{
			Console.WriteLine("DVD player is ejected");
		}

		public virtual void off()
		{
			Console.WriteLine("DVD player is off");
		}
	}

}