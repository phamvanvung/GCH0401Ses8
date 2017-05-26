using System;

namespace SimpleMath
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            SimpleMath sm = new SimpleMath();
            //Setting up the handler
            sm.SetMathHandler((msg, result) =>{
                Console.WriteLine($"{msg} : {result}");
            });
            //Call add method
            sm.Add(10, 11);
        }
    }
}
