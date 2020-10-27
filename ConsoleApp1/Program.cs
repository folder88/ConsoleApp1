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


            class_cornel object_01 = new Cornel.class_cornel();

            object_01.exercise_01();
            object_01.exercise_02();
            object_01.exercises_03();

            ClassSamira newclass = new Samira.ClassSamira();
            //newclass.firstTask();
            //newclass.secondTask();
            //newclass.thirdTask();
            //newclass.forthTask();
            //newclass.fifthTask();
            //newclass.sixthTask();
            newclass.seventhTask();






            testOne one = new Kathi.testOne();
            // one.taskOne();
            // one.taskTwo();
            // one.taskThree();
            // one.taskFour();
            // one.taskFive();
            // one.taskSix();
            // one.taskSeven();

        }

       
    }
}
