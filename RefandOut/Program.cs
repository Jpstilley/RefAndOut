using System;

namespace RefandOut
{
    class Program
    {
        //TODO impliment this ref method by returning a bool and subtracting from the parameter.
        //So it will have two outputs. the bool of true if health is > 0. and also set x to decrease by 1.
        //TODO Call the method in the main and make sure the method changes the number of a initialized variable and returns a bool.
        public static bool SubtractHealth(ref int x)
        {
            x -= +5;
            return true;
        }

        //TODO create method that uses the out keyword. Call the method in the main.
        

        public static int Sum(int x, int y, out  bool even)
        {
            int sum = x + y;
            even = (sum % 2 == 0);
            return sum;
        }
            

        static void Main(string[] args)
        {
            int myValue = 25;
            bool answer = SubtractHealth(ref myValue);

            bool even;
            int mySum = Sum(3, 4, out even);



        }

    }
}
