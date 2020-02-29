using System;

namespace MethodsMadisonEcrement
{
    class Program
    {
        static void MyMessage(int arithmeticopt)
        {
            try
            {
                Console.WriteLine("Name: Madison Frances Ecrement");
                Random randominterger = new Random();

                int firstNumber = randominterger.Next(6);
                int secondNumber = randominterger.Next(3);

                int multiplication = firstNumber * secondNumber;
                int division = firstNumber / secondNumber;
                int addition = firstNumber + secondNumber;
                int subtraction = firstNumber - secondNumber;

                string times = "The Number " + firstNumber + " times " + secondNumber + " is equal to: " + multiplication;
                string divide = "The Number " + firstNumber + " divided by " + secondNumber + " is equal to: " + division;
                string plus = "The Number " + firstNumber + " plus " + secondNumber + " is equal to: " + addition;
                string minus = "The Number " + firstNumber + " minus " + secondNumber + " is equal to: " + subtraction;

                if (arithmeticopt == 0)
                {
                    Console.WriteLine(times);
                }
                else if (arithmeticopt == 1)
                {
                    Console.WriteLine(divide);
                }
                else if (arithmeticopt == 2)
                {
                    Console.WriteLine(plus);
                }
                else if (arithmeticopt == 3)
                {
                    Console.WriteLine(minus);
                }
                else
                {
                    Console.WriteLine("Unknown Flag: The Arithmetic Operation's Parameter Have a Range of 0 to 3 Only.");
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error Message : " + ex);
            }
        }
        static void Main(string[] args)
        {
            MyMessage(4);
        }
    }
}
