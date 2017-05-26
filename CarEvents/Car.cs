using System;
namespace CarEvents
{
    public class Car
    {
        //What kind of method you can assign to me
        public delegate void CarEngineHandler(string msg);
        //When you assign to me => I am storing in Exploded or AboutToBlow
        public event CarEngineHandler Exploded;
        public event CarEngineHandler AboutToBlow;

        public string PetName { get; set; }
        public int MaxSpeed { get; set; }
        public int CurrentSpeed { get; set; }
        public Car()
        {
        }
        public Car(string petName, int maxSpeed, int currSpeed)
        {
            PetName = petName;
            MaxSpeed = maxSpeed;
            CurrentSpeed = currSpeed;
        }
        private bool isDead = false;
        public void Accerlerate(int delta){
            if(isDead){
                //if(Exploded!=null){
                //    Exploded("Sorry, this car is dead");
                //}
                Exploded?.Invoke("Sorry, this car is dead");
            }else{
                CurrentSpeed += delta;
                if(MaxSpeed - CurrentSpeed <= 10 && MaxSpeed - CurrentSpeed >= 0){
                    AboutToBlow?.Invoke("Careful buddy! About to blow!");
                }else if (CurrentSpeed > MaxSpeed){
                    isDead = true;
                    Exploded?.Invoke("Sorry thsi car is dead");
                }else{
                    Console.WriteLine($"Current speed is {CurrentSpeed}" );
                }
            }
        }
    }
}
