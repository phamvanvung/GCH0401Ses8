using System;

namespace CarEvents
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Car c1 = new Car("SlugBug", 100, 10);
            //Registering an event to call back
            c1.AboutToBlow += delegate {
                Console.WriteLine("You are going too fast");
            };
            //Event is a list => so you can add more than 1 method
            c1.AboutToBlow += delegate (string msg){
                Console.WriteLine($"=> Critical message from car: {msg}");
            };
            int x=10;
            //Another event
            c1.Exploded += delegate(string msg) {//Annonymous method
                Console.WriteLine(msg);
                Console.WriteLine($"You can accss to outer variable: {x}");
            };
            for (int i = 0; i < 6; i++)
            {
                c1.Accerlerate(20);
            }

        }
    }
}
