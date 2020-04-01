using System;

namespace facade
{
    public class HomeTheaterApp
    {
        public static void Main(string[] args)
        {

            Amplifier amp = new Amplifier();
            Tuner tuner = new Tuner();
            DvdPlayer dvd = new DvdPlayer();
            CdPlayer cd = new CdPlayer();
            Projector projector = new Projector();
            TheaterLights lights = new TheaterLights();
            Screen screen = new Screen();
            PopcornPopper popper = new PopcornPopper();

            HomeTheater homeTheater = new HomeTheater(amp, tuner, dvd, cd, projector, screen, lights, popper);
            homeTheater.watchMovie("The best movie VII");
            homeTheater.endMovie();

        }
    }
}
