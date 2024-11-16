using System.Reflection.Metadata;

namespace Assignment3C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Assignment3.1
            //Console.WriteLine("Enter a Number!");
            //int num = Convert.ToInt32(Console.ReadLine());
            //if(num % 3 == 0 && num % 4 == 0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //  Console.WriteLine("No");
            //}
            #endregion

            #region Assignment3.2
            //Console.WriteLine("Enter a Number!");
            //int num = Convert.ToInt32(Console.ReadLine());
            //if(num > 0)
            //{
            //    Console.WriteLine("Positive");
            //}
            //else if(num < 0){
            //    Console.WriteLine("Negative");
            //}
            //else
            //{
            //    Console.WriteLine("Zero");
            //}
            #endregion

            #region Assignment3.3
            //Example 1
            //Console.WriteLine("Enter three integers, separate them by comma!");
            //string str1 = Console.ReadLine();
            //var arr1 = str1.Split(',');
            //int x = int.Parse(arr1[0]);
            //int y = int.Parse(arr1[1]);
            //int z = int.Parse(arr1[2]);
            //Console.WriteLine($"max element = {Math.Max(x, Math.Max(y, z))}");
            //Console.WriteLine($"min element = {Math.Min(x, Math.Min(y, z))}");


            //Example 2
            //Console.WriteLine("Enter three integers, separate them by space!");
            //string str1 = Console.ReadLine();
            //var arr1 = str1.Split(' ');
            //int x = int.Parse(arr1[0]);
            //int y = int.Parse(arr1[1]);
            //int z = int.Parse(arr1[2]);
            //Console.WriteLine($"max element = {Math.Max(x, Math.Max(y, z))}");
            //Console.WriteLine($"min element = {Math.Min(x, Math.Min(y, z))}");
            #endregion

            #region Assignment3.4
            //Console.WriteLine("Enter a Number!");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine((num % 2 == 0) ? "even" : "odd");
            #endregion

            #region Assignment3.5
            //Console.WriteLine("Enter a Character!");
            //char ch = Console.ReadLine()[0];
            //switch (char.ToLower(ch))
            //{
            //    case 'a':
            //    case 'e':
            //    case 'i':
            //    case 'o':
            //    case 'u':
            //        Console.WriteLine("Vowel");
            //        break;
            //    default:
            //        Console.WriteLine("Consonant");
            //        break;
            //}
            #endregion

            #region Assignment3.6
            //Console.WriteLine("Enter a Number!");
            //int num = Convert.ToInt32(Console.ReadLine());
            //for(int i = 1; i <= num; i++)
            //{
            //    if(i == num)
            //    {
            //        Console.Write($"{i}\n");
            //    }
            //    else
            //    {
            //        Console.Write($"{i}, ");
            //    }
            //}
            #endregion

            #region Assignment3.7
            //Console.WriteLine("Enter a Number!");
            //int num = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.Write($"{i * num} ");
            //}
            //Console.WriteLine();
            #endregion

            #region Assignment3.8
            //Console.WriteLine("Enter a Number!");
            //int num = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= num; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.Write($"{i} ");
            //    }

            //}
            //Console.WriteLine();
            #endregion

            #region Assignment3.9
            //Console.WriteLine("Enter a Number then its power!");
            //string str = Console.ReadLine();
            //var arr = str.Split(" ");
            //int num = int.Parse(arr[0]);
            //int power = int.Parse(arr[1]);
            //Console.WriteLine(Math.Pow(num, power));
            #endregion

            #region Assignment3.10
            //Console.WriteLine("Enter marks of 5 subjects!");
            //string str = Console.ReadLine();
            //var arr = str.Split(" ");
            //int[] arr2 = new int[5];
            //for(int i = 0; i < 5; i++)
            //{
            //    arr2[i] = Convert.ToInt32(arr[i]);
            //}
            //Console.WriteLine($"total marks = {arr2.Sum()}");
            //Console.WriteLine($"average mark = {arr2.Average()}");
            //// by calculation we find out that average is the same as percentage so,
            //Console.WriteLine($"percentage = {arr2.Average()} %");

            #endregion

            #region Assignment3.11
            //Console.WriteLine("Enter the number of your month!");
            //int num = int.Parse(Console.ReadLine());
            //switch (num)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.WriteLine("31");
            //        break;
            //    case 2:
            //        Console.WriteLine("28 or 29");
            //        break;
            //    case 4:
            //    case 6:
            //    case 7:
            //    case 9:
            //    case 11:
            //        Console.WriteLine("30");
            //        break;
            //    default:
            //        Console.WriteLine("This month is unknown or doesn't exist!");
            //        break;

            //}
            #endregion

            #region Assignment3.12
            //Console.WriteLine("inserted your equation separated by spaces!");
            //string str = Console.ReadLine();
            //var arr = str.Split(" ");
            //double fNum = Convert.ToDouble(arr[0]);
            //char sign = arr[1][0];
            //double sNum = Convert.ToDouble(arr[2]);
            //switch (sign)
            //{
            //    case '+':
            //        Console.WriteLine(fNum+sNum);
            //        break;
            //    case '-':
            //        Console.WriteLine(fNum - sNum);
            //        break;
            //    case '*':
            //        Console.WriteLine(fNum * sNum);
            //        break;
            //    case '/':
            //        Console.WriteLine(fNum / sNum);
            //        break;
            //    case '%':
            //        Console.WriteLine(fNum % sNum);
            //        break;
            //    default:
            //        Console.WriteLine("wrong equation !");
            //        break;
            //}    

            #endregion

            #region Assignment3.13
            //string originalString = "Hello World!";
            //Console.WriteLine("Enter the string you want to reverse!");
            //string str = Console.ReadLine();
            //char[] charArray = str.ToCharArray();
            //Array.Reverse(charArray);
            //string reversedString = new string(charArray);
            //Console.WriteLine("Original string: " + str);
            //Console.WriteLine("Reversed string: " + reversedString);
            #endregion

            #region Assignment3.14
            //Console.WriteLine("Enter the Number you want to reverse!");
            //string str = Console.ReadLine();
            //char[] charArray = str.ToCharArray();
            //Array.Reverse(charArray);
            //string reversedString = new string(charArray);
            //Console.WriteLine("Original number: " + str);
            //Console.WriteLine("Reversed number: " + reversedString);
            #endregion

            #region Assignment3.15
            //      // Get start and end numbers from the user
            //      int startNum, endNum;

            //      Console.WriteLine("Enter the starting number: ");
            //      startNum = Convert.ToInt32(Console.ReadLine());

            //      Console.WriteLine("Enter the ending number: ");
            //      endNum = Convert.ToInt32(Console.ReadLine());

            //      // Ensure starting number is at least 2
            //      startNum = Math.Max(startNum, 2);

            //      Console.WriteLine("Prime numbers between {0} and {1} are:", startNum, endNum);

            //      // Find and display prime numbers
            //      for (int num = startNum; num <= endNum; num++)
            //      {
            //          if (IsPrime(num))
            //          {
            //              Console.Write("{0} ", num);
            //          }
            //      }

            //      Console.WriteLine(); // Add a newline character after output
            //  }
            //static bool IsPrime(int number)
            //      {
            //      bool test = false;
            //          if (number <= 1) return false;
            //          if (number <= 3) return true;

            //          // Only check divisibility by odd numbers from 3 to square root of number
            //          for (int i = 2; i <= number/2; i ++)
            //          {
            //          if (number % i == 0) {
            //              test = false;
            //              break;
            //          }
            //          else
            //          {
            //              test = true;
            //          }
            //          }

            //      return test;
            //      }
            #endregion

            #region Assignment3.16
            //Console.WriteLine("Enter your Number!");
            //int num = Convert.ToInt32(Console.ReadLine());
            //string binaryString = "";

            //if (num == 0)
            //{
            //    binaryString = "0";                
            //}

            //while (num > 0)
            //{
            //    binaryString = (num % 2) + binaryString; // Prepend remainder (0 or 1)
            //    num /= 2; // Divide by 2 for next iteration
            //}

            //Console.WriteLine(binaryString);
            #endregion
        }
    }
}

