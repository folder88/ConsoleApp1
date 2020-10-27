using ConsoleApp1.Cornel;
using ConsoleApp1.Kathi;
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
            newclass.firstTask();
            newclass.secondTask();
            newclass.thirdTask();
            newclass.forthTask();



            testOne one = new Kathi.testOne();
            // one.taskOne();
            // one.taskTwo();
            // one.taskThree();
            // one.taskFour();
            // one.taskFive();
            // one.taskSix();
            // one.taskSeven();
            // one.TaskEight();

        }

       
    }
}
