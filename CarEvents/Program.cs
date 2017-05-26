using System;

namespace CarEvents
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Car c1 = new Car("SlugBug", 100, 10);
            //Registering an event to call back
            c1.AboutToBlow += CarAboutToBlow;
            //Event is a list => so you can add more than 1 method
            c1.AboutToBlow += CarIsAlmostDoomed;
            //Another event
            c1.Exploded += CarExploded;
            for (int i = 0; i < 6; i++)
            {
                c1.Accerlerate(20);
            }
            //Remove the method out of the list
            c1.Exploded -= CarExploded;
            //Accerlerate again and if it is exploded => nothing show.
			for (int i = 0; i < 6; i++)
			{
				c1.Accerlerate(20);
			}

        }
        public static void CarAboutToBlow(string msg){
            Console.WriteLine(msg);
        }
        public static void CarIsAlmostDoomed(string msg){
            Console.WriteLine($"=> Critical message from car: {msg}");
        }
        public static void CarExploded(string msg){
            Console.WriteLine(msg);
        }
    }
}
