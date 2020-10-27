using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Kathi
{
    class testOne
    {
        public void sayHello()
        {
            Console.WriteLine("Hello from kathi's folder");
        }

        public void taskOne()
        {
            string myName = "Kathi";
            Console.WriteLine("Hello, my name is " + myName);
        }

        public void taskTwo()
        {
            string firstName = "Kathi";
            string lastName = "Schey";
            Console.WriteLine(firstName + " " + lastName);
        }

        public void taskThree()
        {
            string myName = "Kathi";
            int age = 35;
            float tall = 1.63f;
            Boolean what = true;
            char grade = 'D';
            Console.WriteLine("Hi, my name is "+ myName +". I am "+ age +" years old and i am "+ tall +" m tall. I like playing basketball. Sometimes, people ask me if it is "+ what +" that I had in school only "+ grade +" grades. Of course, it is not :).");
        }

        public void taskFour()
        { 
            Console.WriteLine("Enter first number");
            var first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            var second = Convert.ToInt32(Console.ReadLine());
                           
            Console.WriteLine("Is the first value "+ first +" less than 150 ? "+ (first < 150));
            
            Console.WriteLine("Is the second value " + second + " bigger than 300? " + (second > 300));
        }

        public void taskFive()
        {
            float miles = 0.6214f;
            Console.WriteLine("Enter the kilometers to get the miles");
            var distanz = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You have " + (distanz * miles) + " miles to drive");
        }

        public void taskSix()
        {
            Console.WriteLine("the adding part of two numbers");
            Console.WriteLine("give me the first");
            var addOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("give me the second");
            var addSec = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The output is: " + (addOne + addSec));
            Console.WriteLine(" ");

            Console.WriteLine("the subtracting part of two numbers :) ");
            Console.WriteLine("give me the first and than the second number");
            var subOne = Convert.ToInt32(Console.ReadLine());
            var subSec = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The result is: " + (subOne - subSec));
            Console.WriteLine(" ");

            Console.WriteLine("the multiplying part of two numbers start");
            Console.WriteLine("And again, enter two numbers, please");
            var multiOne = Convert.ToInt32(Console.ReadLine());
            var multiSec = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The result of this is: " + (multiOne * multiSec));
            Console.WriteLine(" ");

            Console.WriteLine("the dividing part of two numbers");
            Console.WriteLine("the last numbers.realy! i promis! :D");
            var diviOne = Convert.ToInt32(Console.ReadLine());
            var diviSec = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Aaaand the last result iiiiiiis: " + ((decimal)diviOne / (decimal)diviSec));
            Console.WriteLine(" ");
        }

        public void taskSeven()
        {
            Console.WriteLine("Now, the BMI starts! O- Oh....");
            Console.WriteLine("please, enter your kg");
            float kg = float.Parse(Console.ReadLine());
            Console.WriteLine("please, enter height");
            float height = float.Parse(Console.ReadLine());
            float m2 = height * height;
            float bmi = kg / m2;
            Console.WriteLine("Your BMI is: " + (decimal)bmi);

        }

        public void TaskEight()
        {
            Console.WriteLine("Please, enter a number");
            double some = Convert.ToDouble(Console.ReadLine());
            Console.Write("{0} {0} {0} {0}", some);
            Console.WriteLine("");
            Console.Write("{0}{0}{0}{0}", some);

        }
    }
}
