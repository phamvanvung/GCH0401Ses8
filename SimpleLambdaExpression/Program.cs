using System;
using System.Collections.Generic;

namespace SimpleLambdaExpression
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //TraditionalDelegate();
            //AnnonymousMethodSyntax();
            LambdaSyntax();
            Console.ReadLine();
        }
            //public static void TraditionalDelegate(){
			////we have a list of integers
			//List<int> list = new List<int>() { 2, 20, 1, 3, 5, 6 };
			////Generic collection provides you a delegate called Predicate
			//Predicate<int> callback = new Predicate<int>(IsEvenNumber);
			//List<int> evenNumbers = list.FindAll(callback);
			//foreach (var item in evenNumbers)
			//{
			//	Console.Write($"{item}\t");
			//}
			//Console.WriteLine();
        //}
		//public static void AnnonymousMethodSyntax()
		//{
		//	//we have a list of integers
		//	List<int> list = new List<int>() { 2, 20, 1, 3, 5, 6 };
		//	//Generic collection provides you a delegate called Predica
		//	List<int> evenNumbers = list.FindAll(delegate(int i) {
  //              return i % 2 == 0;
  //          });
		//	foreach (var item in evenNumbers)
		//	{
		//		Console.Write($"{item}\t");
		//	}
		//	Console.WriteLine();
		//}
        public static void LambdaSyntax()
        {
            //we have a list of integers
            List<int> list = new List<int>() { 2, 20, 1, 3, 5, 6 };
            //Generic collection provides you a delegate called Predica
            List<int> evenNumbers = list.FindAll(i => i%2==0);
            foreach (var item in evenNumbers)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
        }
        //public static bool IsEvenNumber(int number){
        //    //return number % 2 == 0;
        //    return number > 3;
        //}
    }
}
