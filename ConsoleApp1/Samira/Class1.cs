using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Samira
{
    class ClassSamira
    {
        public void firstTask()
        {
            string name = "Hello my name is Samira !!";
            Console.WriteLine(name);
        }

        public void secondTask()
        {
            string fName = "Samira";
            string lName = "Khadem";
            Console.WriteLine("Hello my name is" +" " +  fName +" " + lName);

        }
        public void thirdTask()
        {
            string myName = "Samira";
            int age = 37;
            float height = 163.4f;
            bool test = true;
            char grade = 'F';
            Console.WriteLine("Hi, my name is "  + myName + ".I am " + height + " m tall.I like playing basketball Sometimes, people ask me if it is " + test + " that I had in school only " + grade + " grades. Of course, it is not :)");

           // Hi, my name is < string >.I am<int> years old and i am<float> m tall.I like playing basketball
           //. Sometimes, people ask me if it is < boolean > that I had in school only<char> grades.Of course, it is not :).”.

        }

        public void forthTask()
        {
            Console.WriteLine("Enter a number: ");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Is the value " + number + " less than 150? " + (number<150));
            Console.WriteLine("Is the value " + number + " more than 300? " + (number > 300));
            


        }
    }
}
