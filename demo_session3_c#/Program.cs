using System;

namespace demo_session3_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FractionsAndDiscard
            // by default fractions are declared as double
            //double x = 2.3;
            //float y = 7.8f;
            //decimal z = 345.678m;
            //long a = 100_000_000_000; // discard
            //Console.WriteLine($"{x} {y} {z} {a}");
            #endregion

            #region ImplicitAndExplicitCastingForValueType
            ////int x = 10;
            ////long y = x; //Implicit Casting [Safe Casting]
            ////Console.WriteLine($"{x} {y}");
            //long x = 15;
            //int y = (int)x; //Explicit Casting
            //Console.WriteLine($"{x} {y}");

            //long x = 1000_000_000_0000;
            //int y = (int)x;
            //Console.WriteLine(y); // garbage value
            //checked
            //{
            //    long x = 1000_000_000_0000;
            //    int y = (int)x;

            //    unchecked
            //    {
            //        Console.WriteLine(y);
            //    }
            //}



            #endregion

            #region UnaryOperators
            //int x = 10;
            //// Prefix => [Increment or Decrement then Print]
            //Console.WriteLine(++x); // 11
            //Console.WriteLine(--x); // 10
            //// Postfix => [Print then Increment or Decrement]
            //Console.WriteLine(x++); //10
            ////then it wil add 1 to x
            //Console.WriteLine(x--); // 11
            #endregion

            #region BinaryOrArithmeticOperators
            //// +,-,*,/,%
            //int x = 49;
            //int y = 7;
            //Console.WriteLine(x + y); // 56
            //Console.WriteLine(x - y); // 42
            //Console.WriteLine(x * y); // 343
            //Console.WriteLine(x / y); // 7
            //Console.WriteLine(x % y); // 0

            #endregion

            #region AssignmentOperators
            //int x = 2;
            //x += 2; // 4
            //x -= 2; // 2
            //x *= 2; // 4
            //x /= 2; // 2
            //x %= 2; // 0
            #endregion

            #region RelationalOperators
            //int x = 6, y = 7;
            //Console.WriteLine(x == y); // false
            //Console.WriteLine(y != x); // true
            //Console.WriteLine(x <= y); // true
            //Console.WriteLine(y < x); // false
            //Console.WriteLine(x >= y); // false
            //Console.WriteLine(y > x); // true
            #endregion

            #region LogicalOperators
            //Console.WriteLine(!false); // true
            //Console.WriteLine(!true); // false
            //Console.WriteLine(false && true); // false
            //Console.WriteLine(false || true); // true
            //Console.WriteLine(49>7 && 16>4); // true

            #endregion

            #region BitwiseOperators
            //AND
            //int num1 = 10; //(binary: 1010);
            //int num2 = 6;  //(binary: 0110);
            //int result = num1 & num2; // result will be 2 (binary: 0010)
            //Console.WriteLine(result);

            //OR
            //int num1 = 10; // (binary: 1010);
            //int num2 = 6; // (binary: 0110);
            //int result = num1 | num2; // result will be 14 (binary: 1110)
            //Console.WriteLine(result);

            //XOR
            //int num1 = 10; // (binary: 1010);
            //int num2 = 6; // (binary: 0110);
            //int result = num1 ^ num2; // result will be 12 (binary: 1100)
            //Console.WriteLine(result);






            #endregion

            #region TernaryOperator

            //int number = 10;
            //bool isEven = (number % 2 == 0) ? true : false;
            //Console.WriteLine(isEven); // Output: true

            //int age = 20;
            //string message = (age >= 18) ? "You are an adult." : "You are underage.";
            //Console.WriteLine(message); // Output: You are an adult.

            //Nested TRernary Operator

            //int grade = 85;
            //string letterGrade = (grade >= 90) ? "A" : (grade >= 80) ? "B" : "C";
            //Console.WriteLine(letterGrade); // Output: B





            #endregion

            #region OperatorsPriority
            // Unary Prefix Operator
            // Round Praces ()
            // */%
            // +-
            //int equation = 4 * 3 + 6; // 18
            //Console.WriteLine(equation); // 18
            #endregion

            #region StringFormatting
            int x = 7, y = 7;
            int prod = x * y;
            string m1 = "Operation is : " + x + " * " + y + " = " + prod;
            string m2 = string.Format("Operation is : {0} * {1} = {2}", x, y, prod);
            string m3 = $"Operation is : {x} * {y} = {x * y}";
            Console.WriteLine(m1);
            Console.WriteLine(m2);
            Console.WriteLine(m3);


            #endregion

            #region ControlStatementsIfAndSwitch
            //int number = 15;

            //if (number > 10)
            //{
            //    Console.WriteLine("The number is greater than 10.");
            //}



            //int grade = 88;
            //if (grade >= 90)
            //{
            //    Console.WriteLine("Excellent! You got an A.");
            //}
            //else
            //{
            //    Console.WriteLine("Good job. You got a B.");
            //}


            //string letter = "C";

            //if (letter == "A")
            //{
            //    Console.WriteLine("The letter is A.");
            //}
            //else if (letter == "B")
            //{
            //    Console.WriteLine("The letter is B.");
            //}
            //else
            //{
            //    Console.WriteLine("The letter is neither A nor B.");
            //}


            //char initial = 'D';

            //switch (initial)
            //{
            //    case 'A':
            //        Console.WriteLine("You chose A.");
            //        break;
            //    case 'B':
            //        Console.WriteLine("You chose B.");
            //        break;
            //    default:
            //        Console.WriteLine("You chose something else.");
            //        break;
            //}






            #endregion




        }
    }
}
