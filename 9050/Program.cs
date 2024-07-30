using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9050
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        //1
        public static bool what(int n1, int n2) 
        {
            if (n1 < 10 && n2 < 10)
                return n1 == n2;

            if (n1 < 10)
                return what(n1, n2 / 10);
            if (n2 < 10)
                return what(n1 / 10, n2);
            return what(n1 / 10, n2 / 10);
        }
        //follow with 25,286 -> what is returned?
        //follow with 65,71 -> what is returned
        //what is the purpose of what?


        //2
        static bool What2(int num) 
        {
            if (num < 10) return true; 
            if ((num / 10) % 2 != num % 2) return false; 
            return What2(num / 10);
        }
        //follow with 135, 246, 18
        //what is the purpose of what2?




        //3
        static int Sod (int n1, int n2)
        {
            if (n1 % n2 == 0)
                return n2;
            else
                return Sod(n1, n2 - 1);
        }
        //folow with n1 = 15, n2 = n1%2
        //folow with n1 = 7, n2 = n1%2
        //Q1: What is the purpose of Sod?
        //Q2: What does a return value of 1 mean?
        //Q3: Can we give do better than n2 = n1/2?


        //4
        //what will Print(1,1,3) print?
        static void Print (int i, int j, int n)
        {
            if (i <= n)
            {
                if (j<=i)
                {
                    Console.WriteLine(i);
                    Print(i, j + 1, n);
                }
                else
                {
                    Console.WriteLine();
                    Print(i + 1, 1, n);
                }
            }
        }

        //5
        //array lst = [5,1,10,12]
        //1.follow Sod1(lst, lst.Length-1)
        //2.what's the purpose of Sod1?
        //3.Follow Sod2 from ActivateSod(). What's returned? don't follow Sod1 again
        //4.What's the purpose of Sod2?
        //5.What's the complexity of Sod2?
        public static int Sod1(int[] a, int k)
        {
            if (k == 0)
                return a[k];
            return a[k] + Sod1(a, k - 1);
        }

        public static bool Sod2(int[] a, int n)
        {
            if (n == 0)
                return true;
            if (a[n] % 10 != Sod1(a, n - 1) % 10)
                return false;
            return Sod2(a, n - 1);
        }

        public static void ActivateSod()
        {
            int[] a = { 4, 24, 8, 26, 42 };
            Console.WriteLine(Sod2(a, a.Length - 1));
        }



        //6
        //האם אתם יודעים איך תופסים אריה במדבר
        //1. follow the 2 prints in Activate Fnc
        //2. what's the purpose of Fnc?
        //3. what's the complexity?
        static int Fnc(int[] a, int f, int h, int num)
        {
            int m;
            if (f == h)
            {
                if (num == a[f])
                    return 1;
                else
                    return -1;
            }
            m = (f + h) / 2;
            if (num <= a[m])
                return Fnc(a, f, m, num);
            else
                return Fnc(a, m + 1, h, num);
        }

        static void ActivateFnc()
        {
            int[] a = new int[] { 3, 5, 10, 12, 30, 45, 50, 57, 60 };
            Console.WriteLine(Fnc(a,0,8,5));
            Console.WriteLine(Fnc(a, 0, 8, 55));

        }


    }
}
