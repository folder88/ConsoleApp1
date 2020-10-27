using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Cornel
{
    class class_cornel
    {

        public void exercise_01()
        {
            var name = "John Doe";
            Console.WriteLine(name);
            
        }

        public void exercise_02()
        {
            var firstName = "Cornel";
            var lastName = "Gurin";

            Console.WriteLine(firstName + " " + lastName);



        }

        public void exercises_03()
        {
            string name = "John Smith";
            int age = 35;
            char gender = 'M';
            float height = 185.80f;
            Boolean acces = true;

            Console.WriteLine("Hi,my name is 0" + name + ".I am " + age + "years old and i am " + height + "tall.I like playing basketball.Sometimes,people ask me if it is " + acces + " that I had in school only " + gender + "grades.Of course,it is not:).");
        }
    }
}
