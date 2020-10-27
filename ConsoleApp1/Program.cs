using ConsoleApp1.Cornel;
using ConsoleApp1.Samira;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Class1 class_01 = new Cornel.Class1();

            class_01.method();

            ClassSamira newclass = new Samira.ClassSamira();
            newclass.myMethod();

        }

       
    }
}
