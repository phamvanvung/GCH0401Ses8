using System;

namespace Ses8Delegate
{
    //Declaring a delegate to point to a function of type: int name(int x, int y)
    public delegate int BinaryOp(int x, int y);
    class SimpleMath{
        public int Add(int x, int y){
            return x + y;
        }
        public int Substract(int x, int y){
            return x - y;
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            SimpleMath sm = new SimpleMath();
            //Delegate is a type => so you can declare a variable
            //And point to it.
            BinaryOp op = new BinaryOp(sm.Add);
            Console.WriteLine("10 + 11 = {0}", op(10, 11));
            op = new BinaryOp(sm.Substract);
            Console.WriteLine("10 - 11 = {0}", op(10, 11));
            Console.ReadLine();
        }
    }
}
