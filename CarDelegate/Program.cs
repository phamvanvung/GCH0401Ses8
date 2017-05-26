using System;

namespace CarDelegate
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Car c = new Car();
            //assign a method for the car to call me back
            c.listOfHandlers = new Car.CarEngineHandler(CallWhenExploded);
            c.Accelerate(10);
            Console.ReadLine();

        }
        public static void CallWhenExploded(string str){
            Console.WriteLine($"{str}");
        }
    }
}
