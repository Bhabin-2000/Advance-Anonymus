using System;

namespace Anonymus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous");
            Func<int, int, int> AnonymusAdd = delegate (int firstNum, int secondNum)
               {
                   return (firstNum + secondNum);
               };
            Calculator(AnonymusAdd);


            Func<int, int, int> AnonymusSub = delegate (int firstNum, int secondNum)
            {
                return (firstNum - secondNum);
            };
            Calculator(AnonymusSub);


            Func<int, int, int> AnonymusMultiple = delegate (int firstNum, int secondNum)
            {
                return (firstNum * secondNum);
            };
            Calculator(AnonymusMultiple);


            Func<int, int, int> AnonymusDivision = delegate (int firstNum, int secondNum)
            {
                return (firstNum / secondNum);
            };
            Calculator(AnonymusDivision);
        }

        static void Calculator(Func<int,int,int> fun)
        {
            Console.WriteLine(fun(100, 120)); 
        }
        
    }
}
