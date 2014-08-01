using System;

namespace CustomDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Encapsulate a method with one parameter and does not return a value
            Action<string> messageTarget;
            int number = 10;
            if (number == 1)
            {
                messageTarget = doSomeThing;
            }
            else
            {
                messageTarget = doOtherThing;
            }
            messageTarget("Hello do stuff?");


            Action<int> messageMulti;
            
            if (number == 1)
            {
                messageMulti = doubleMutli;
            }
            else
            {
                messageMulti = trippleMulti;
            }

            messageMulti(10);

            Console.ReadLine();
        }

        private static void doSomeThing(string message)
        {
            Console.WriteLine("do some thing " + message);    
        }

        private static void doOtherThing(string message)
        {
            Console.WriteLine("do other thing " + message);
        }

        private  static void  doubleMutli(int num)
        {
            Console.WriteLine("num*num=" + num*num);
        }

        private static void trippleMulti(int num)
        {
            Console.WriteLine("num*num*num=" + num * num*num);
        }
    }
}
