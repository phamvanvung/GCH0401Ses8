using System;

namespace GenericDelegate
{
    class MainClass
    {
        public delegate void MyGenericDelegate<T>(T input);
        public static void Main(string[] args)
        {
            Console.WriteLine("********* Generic Delegate *************");
            //Declare the delegate of type string
            MyGenericDelegate<string> stringTarget 
            = new MyGenericDelegate<string>(StringTarget);
            stringTarget("Welcome to C# Programming!");

            //Declare the delegate of type int
            MyGenericDelegate<int> intTarget
            = new MyGenericDelegate<int>(IntTarget);
            //Invoke
            intTarget(9);
            Console.ReadLine();
        }
        public static void StringTarget(string str){
            str = str.ToUpper();
            Console.WriteLine($"{str}");//the same as ("{0}", str)
        }
        public static void IntTarget(int n){
            Console.WriteLine($"++n is {++n}");
        }
    }
}
