using System;

namespace CustomDelegate
{
    class Program
    {
        private delegate void TestDelegate(string str);

        static void Target(string str)
        {
            Console.WriteLine(str);
        }

        static void Main(string[] args)
        {

            //Delegation
            TestDelegate testDelegateA = new TestDelegate(Target);
            testDelegateA("Original .Net Delegation");

            //Better Delegation
            TestDelegate testDelegateB = delegate(string str) { Console.WriteLine("Better delegation = {0}", str); };
            testDelegateB("Nice Delegation");

            //Lambda Expression
            TestDelegate testDelegateC = (str) => Console.WriteLine("Lambda Expression is cool = {0}", str);
            testDelegateC("MY Lambda Baby");

            //Encapsulate a method with one parameter and does not return a value
            Multiplication multi = Multiplication.DOUBLE;

            //Anonymous Function  Func<returnType, FirstParam>
            Func<String, String> action = (inputStr) =>
            {
                string str = "Anonymous Function is cool=" + inputStr;
                return str;
            };

            ExecuteFunc(action("Yep it is cool"));

            Action<int> messageMulti;
            if (multi == Multiplication.DOUBLE)
            {
                messageMulti = DoubleMutli;
            }
            else
            {
                messageMulti = TrippleMulti;
            }

            messageMulti(10);
            Console.ReadLine();
        }

        static void ExecuteFunc(string action)
        {
            Console.WriteLine(action);
        }

        private  static void  DoubleMutli(int num)
        {
            Console.WriteLine("num*num=" + num*num);
        }

        private static void TrippleMulti(int num)
        {
            Console.WriteLine("num*num*num=" + num * num*num);
        }
    }

    enum Multiplication 
    { 
        DOUBLE, 
        TRIPPLE
    };
}
