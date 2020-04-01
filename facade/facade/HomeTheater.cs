using System;

namespace facade
{
	public class HomeTheater
	{
		internal Amplifier amp;
		internal Tuner tuner;
		internal DvdPlayer dvd;
		internal CdPlayer cd;
		internal Projector projector;
		internal TheaterLights lights;
		internal Screen screen;
		internal PopcornPopper popper;

//JAVA TO C# CONVERTER WARNING: 'final' parameters are ignored unless the option to convert to C# 7.2 'in' parameters is selected:
//ORIGINAL LINE: public HomeTheater(final Amplifier amp, final Tuner tuner, final DvdPlayer dvd, final CdPlayer cd, final Projector projector, final Screen screen, final TheaterLights lights, final PopcornPopper popper)
		public HomeTheater(Amplifier amp, Tuner tuner, DvdPlayer dvd, CdPlayer cd, Projector projector, Screen screen, TheaterLights lights, PopcornPopper popper)
		{
			this.amp = amp;
			this.tuner = tuner;
			this.dvd = dvd;
			this.cd = cd;
			this.projector = projector;
			this.screen = screen;
			this.lights = lights;
			this.popper = popper;
		}

//JAVA TO C# CONVERTER WARNING: 'final' parameters are ignored unless the option to convert to C# 7.2 'in' parameters is selected:
//ORIGINAL LINE: public void watchMovie(final String movie)
		public virtual void watchMovie(string movie)
		{
			Console.WriteLine("Get ready to watch a movie...");
			popper.on();
			popper.pop();
			lights.dim(10);
			screen.down();
			projector.on();
			projector.wideScreenMode();
			amp.on();
			amp.Dvd = dvd;
			amp.setSurroundSound();
			amp.Volume = 5;
			dvd.on();
			dvd.play(movie);
		}

		public virtual void endMovie()
		{
			Console.WriteLine("Shutting movie theater down...");
			popper.off();
			lights.on();
			screen.up();
			projector.off();
			amp.off();
			dvd.stop();
			dvd.eject();
			dvd.off();
		}
	}
}