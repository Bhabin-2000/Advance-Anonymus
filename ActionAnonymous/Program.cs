using System;

namespace ActionAnonymous
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Action Delegate Calculator ");

            Action<int, int> Adding_Anonymous = delegate (int firstnum, int secondnum)
               {
                   Console.WriteLine("\n Adding a two values is : "+(firstnum+secondnum));
               };



            Action<int, int> Subract_Anonymous = delegate (int firstnum, int secondnum)
            {
                Console.WriteLine("\n Subracting a two values is : " + (firstnum - secondnum));
            };


            Action<int, int> Multiple_Anonymous = delegate (int firstnum, int secondnum)
            {
                Console.WriteLine("\n Multiplaying a two values is : " + (firstnum * secondnum));
            };



            Action<int, int> Division_Anonymous = delegate (int firstnum, int secondnum)
            {
                Console.WriteLine("\n Dividing a two values is : " + (firstnum / secondnum));
            };


            calculator(Adding_Anonymous+= Subract_Anonymous+= Multiple_Anonymous+= Division_Anonymous, 20, 4);

            Console.ReadKey();

        }
        static void calculator(Action<int,int> cal, int First,int Second)
        {
            cal(First, Second);
        }
    }
}
