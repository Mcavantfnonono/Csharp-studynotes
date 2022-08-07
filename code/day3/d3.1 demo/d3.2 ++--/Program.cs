using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d3._2_____
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 10;
            n++;            //11
            Console.WriteLine(n);
            Console.ReadKey();
            int n1 = 5;
            n1--;            //4
            Console.WriteLine(n1);
            Console.ReadKey();
            ++n;            //12
            Console.WriteLine(n);
            --n1;           //3
            Console.WriteLine(n1);
            Console.ReadKey();
            //n++ = ++ n=n=n+1   
            // n-- = --n=n=n-1
            int p1 = 2;
           // int p2 = p1 + p1++; //在运算当中后++先拿原值运算在把变量自身+1
            int p2 = p1 + ++p1;    //在运算当中前++先给变量+1 再带着+1的值进行运算
            Console.WriteLine(p2);
            Console.ReadKey();

            int u = 88;
            //int u1 = u - u--;//在运算当中后--先拿原值运算在把变量自身-1

            int u1 = u - --u;   //在运算当中前--先给变量-1 再带着-1的值进行运算
            Console.WriteLine(u1);
            Console.ReadKey();


        }
    }
}
