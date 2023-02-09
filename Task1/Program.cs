using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDelegate myDelegate = CalcCircumference;
            Console.WriteLine(myDelegate(5.5));
            myDelegate = CalcCircleArea;
            Console.WriteLine(myDelegate(5.5));
            myDelegate = CalcSphereVolume;
            Console.WriteLine(myDelegate(5.5));
            Console.ReadKey();
        }

        delegate double MyDelegate(double d);


       static double CalcCircumference(double r) => r * 2 * Math.PI;

        static double CalcCircleArea(double r) => r * r * Math.PI;

        static double CalcSphereVolume(double r) => r * r *r* Math.PI*4/3;



    }
}
