//Given two numbers, write a method that returns greater one.

namespace Program{
    class GreaterNumberTask{

        public static double GreaterNumber(double num1 , double num2){

            return Math.Max(num1, num2);
        }
        public static void Main (){

            Console.WriteLine(GreaterNumber(2.1, 3));// → 3
            Console.WriteLine(GreaterNumber(-5, 0));// → 0
            Console.WriteLine(GreaterNumber(-111.22,111.222));// → 111.222
        }

    }
}