using System;

namespace facade
{
	public class PopcornPopper
	{

		public virtual void on()
		{
			Console.WriteLine("Popcorn popper is on");
		}

		public virtual void pop()
		{
			Console.WriteLine("Popcorn popper popping popcorn");
		}

		public virtual void off()
		{
			Console.WriteLine("Popcorn popper is off");
		}

	}

}