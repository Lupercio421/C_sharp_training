using System
// namespace  DataType
namespace Operator

// Hello World! program

// 
// namespace HelloWorld
// {
//     class Hello{
//         static void Main(string[] args)
//         {
//             System.Console.WriteLine("Hello World!");
//         }
//     }
// }

//Alternate Hello World! Implementation

// using System;
// namespace HelloWorld
// {
//     class Hello {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello World!");
//         }
//     }
// }

// int age = 24;

// {
//     class SByteExample
//     {
//         public static void Main(string[] args)
//         {
//             sbyte level = 23;
//             Console.WriteLine(level);
//         }
//     }
// }

// public class HelloWorld
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine ("Hello Mono World");
//     }
// }

// {
//     class ShortExample
//     {
//         public static void Main(string[] args)
//         {
//             short value = -330;
//             Console.WriteLine(value);
//         }
//     }
// }

// {
//     class IntExample
//     {
//         public static void Main(string[] args)
//         {
//             int score = 51093;
//             Console.WriteLine(score);
//         }
//     }
// }

// {
//     class LongExample
//     {
//         public static void Main(string[] args)
//         {
//             long range = -7091821871L;
//             Console.WriteLine(range);
//         }
//     }
// }

// {
//     class UShortExample
//     {
//         public static void Main(string[] args)
//         {
//             ushort value = 0;
//             Console.WriteLine(value);
//         }
//     }
// }

// {
//     class FloatExample
//     {
//         public static void Main(string[] args)
//         {
//             float number = 43.113F;
//             Console.WriteLine(number);
//         }
//     }
// }

// {
//     class CharExample
//     {
//         public static void Main(string[] args)
//         {
//             char ch1 = '\u0043';
//             char ch2 = 'x';
//             Console.WriteLine(ch1);
//             Console.WriteLine(ch2);
//         }
//     }
// }

{
    class DecimalExample
    {
        public static void Main(string[] args)
        {
            decimal bankBalance = 530005.25M;
            Console.WriteLine(bankBalance);
        }
    }
}

// {
//     class AssignmentOperator
//     {
//         public static void Main(string[] args)
//         {
//             int firstNumber, secondNumber;
//             // Assigning a constant to variable
//             firstNumber = 10;
//             Console.WriteLine("First Number = {0}", firstNumber);
            
//             //Assigning a variable to another variable
//             secondNumber = firstNumber;
//             Console.WriteLine("Second Number = {0} and {1}", secondNumber, 2);
//         }
//     }
// }

// {
//     class ArithmeticOperator
//     {
//         public static void Main(string[] args)
//         {
//             double firstNumber = 14.40, secondNumber = 4.60, result;
//             int num1 = 26, num2 = 4, rem;
            
//             // Addition operator
//             result = firstNumber + secondNumber;
//             Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, result);
//             // Subtraction operator
//             result = firstNumber + secondNumber;
//             Console.WriteLine("{0} - {1} = {2}", firstNumber, secondNumber, result);
//             // Multiplication operator
//             result = firstNumber + secondNumber;
//             Console.WriteLine("{0} * {1} = {2}", firstNumber, secondNumber, result);
//             // Modulo operator
//             rem = num1 % num2;
//             Console.WriteLine("{0} % {1} = {2}", num1, num2, rem);
//         }
//     }
// }

// {
//     class RelationalOperator
//     {
//         public static void Main(string[] args)
//         {
//             bool result;
//             int firstNumber = 10, secondNumber = 20;
            
//             result = (firstNumber == secondNumber);
//             Console.WriteLine("{0} == {1} returns {2}", firstNumber, secondNumber, result);
            
//             result = (firstNumber > secondNumber);
//             Console.WriteLine("{0} > {1} returns {2}", firstNumber, secondNumber, result);
            
//             result = (firstNumber < secondNumber);
//             Console.WriteLine("{0} < {1} returns {2}", firstNumber, secondNumber, result);
            
//             result = (firstNumber >= secondNumber);
//             Console.WriteLine("{0} >= {1} returns {2}", firstNumber, secondNumber, result);
            
//             result = (firstNumber != secondNumber);
//             Console.WriteLine("{0} != {1} returns {2}", firstNumber, secondNumber, result);
//         }
//     }
// }

// {
//     class UnaryOperator
//     {
//         public static void Main(string[] args)
//         {
//             int number = 10, result;
//             bool flag = true;
            
//             result = +number;
//             Console.WriteLine("+number = " + result);
            
//             result = -number;
//             Console.WriteLine("-number = " + result);
            
//             // increment value by 1
//             result = ++number;
//             Console.WriteLine("++number = " + result);
            
//             // decrement value by 1
//             result = --number;
//             Console.WriteLine("--number = " + result);
            
//             Console.WriteLine("!flag = " + (!flag));
//         }
//     }
// }

// {
//     class UnaryOperator
//     {
//         public static void Main(string[] args)
//         {
//             int number = 10;
            
//             Console.WriteLine((number++));
//             Console.WriteLine(number);
//             Console.WriteLine((++number));
//         }
//     }
// }

{
    class TernaryOperator
    {
        public static void Main(string[] args)
        {
            int number = 10;
            string result;
            
            result = (number % 2 == 0)? "Even Number" : "Odd Number";
            Console.WriteLine("{0} is an {1}", number, result);
        }
    }
}