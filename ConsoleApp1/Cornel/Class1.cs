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

        public void exercise_03()
        {
            string name = "John Smith";
            int age = 35;
            char gender = 'M';
            float height = 185.80f;
            Boolean acces = true;

            Console.WriteLine("Hi,my name is 0" + name + ".I am " + age + "years old and i am " + height + "tall.I like playing basketball.Sometimes,people ask me if it is " + acces + " that I had in school only " + gender + "grades.Of course,it is not:).");
        }

        public void exercise_04()
        {
            var var_01 = 150;
            var var_02 = 300;


            Console.WriteLine("Enter your first number:");

          
            double num_01 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your second number:");
            double num_02 = Convert.ToDouble(Console.ReadLine());

            

            var variable_01 = num_01 < 150;
            var variable_02 = num_02 > 300;

           Console.WriteLine(" Is the first value " + num_01 + " less that 150 " + variable_01);
           Console.WriteLine(" Is the first value " + num_02 + " less that 300 " + variable_02);


        }

        public void exercise_05()
        {
            Console.WriteLine("Enter the distance:");


            double distance_01 = Convert.ToDouble(Console.ReadLine());

            double distance_02 = distance_01 * 0.6214;

            Console.WriteLine("Your distance in miles is " + distance_02);

        }

        public void exercises_06()
        {
            Console.WriteLine("Enter the first number");
            double num_01 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            double num_02 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the operation");

            var operation = Console.ReadLine();

            if(operation == "+")
            {
                Console.WriteLine(num_01 + num_02);
            }
            else if(operation == "-")
            {
                Console.WriteLine(num_01 - num_02);
            }
            else if (operation == "*")
            {
                Console.WriteLine(num_01 * num_02);
            }
            else if (operation == "/")
            {
                Console.WriteLine(num_01 / num_02);
            }


        }

        public void exercise_07()
        {
            Console.WriteLine("Enter your weight");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your height");
            double height = Convert.ToDouble(Console.ReadLine());


            double bmi = weight / (height * height);

            Console.WriteLine("Your bmi is " + bmi);
        }

    }
}
