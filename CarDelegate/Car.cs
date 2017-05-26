using System;
namespace CarDelegate
{
    public class Car
    {
        public delegate void CarEngineHandler(string msg);
        public CarEngineHandler listOfHandlers;
        public void Accelerate(int delta){
            //Do our things here
            //Inform outsider by calling to their method
            if(listOfHandlers!=null){
                listOfHandlers("This car is dead!");
            }
        }
    }
}
