using System;
using System.Collections.Generic;
using System.Linq;

namespace Assigmment_ADV_C__2
{
    internal class Program
    {
        #region q1
        /* class CountGreater
         {
             public static void Run()
             {
                 string[] firstLine = Console.ReadLine().Split();
                 int n = int.Parse(firstLine[0]);
                 int q = int.Parse(firstLine[1]);

                 int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                 for (int i = 0; i < q; i++)
                 {
                     int x = int.Parse(Console.ReadLine());
                     int count = 0;
                     for (int j = 0; j < n; j++)
                     {
                         if (arr[j] > x)
                         {
                             count++;
                         }
                     }
                     Console.WriteLine(count);
                 }
             }
         }*/
        #endregion

        #region Q2
        /*
         class Q2
         {
             public static void Run()
             {
                 int n = int.Parse(Console.ReadLine());
                 int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                 bool isPalindrome = true;
                 for (int i = 0; i < n / 2; i++)
                 {
                     if (arr[i] != arr[n - i - 1])
                     {
                         isPalindrome = false;
                         break;
                     }
                 }
                 Console.WriteLine(isPalindrome ? "YES" : "NO");
             }
         }*/
        #endregion

        #region Q3
        /*
        class Q3
        {
            public static void Run()
            {
                int n = int.Parse(Console.ReadLine());
                Queue<int> queue = new Queue<int>();
                foreach (var val in Console.ReadLine().Split())
                {
                    queue.Enqueue(int.Parse(val));
                }
                Stack<int> stack = new Stack<int>();
                while (queue.Count > 0) stack.Push(queue.Dequeue());
                while (stack.Count > 0) queue.Enqueue(stack.Pop());
                foreach (var item in queue) Console.Write(item + " ");
                Console.WriteLine();
            }
        }*/
        #endregion

        #region Q4
        /*
        class Q4
        {
            public static void main()
            {
                string s = Console.ReadLine();
                Stack<char> stack = new Stack<char>();
                foreach (char c in s)
                {
                    if (c == '(' || c == '[' || c == '{') stack.Push(c);
                    else
                    {
                        if (stack.Count == 0) { Console.WriteLine("Not Balanced"); return; }
                        char top = stack.Pop();
                        if ((c == ')' && top != '(') || (c == ']' && top != '[') || (c == '}' && top != '{'))
                        {
                            Console.WriteLine("Not Balanced");
                            return;
                        }
                    }
                }
                Console.WriteLine(stack.Count == 0 ? "Balanced" : "Not Balanced");
            }
        }*/
        #endregion

        #region Q5
        class Q5
        {
            public static void Run()
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int[] result = arr.Distinct().ToArray();
                Console.WriteLine(string.Join(" ", result));
            }
        }
        #endregion


    }
}
