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
    }
}
