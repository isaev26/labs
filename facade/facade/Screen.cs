using System;

namespace facade
{
	public class Screen
	{

		public virtual void down()
		{
			Console.WriteLine("Screen is down");
		}

		public virtual void up()
		{
			Console.WriteLine("Screen is up");
		}
	}

}