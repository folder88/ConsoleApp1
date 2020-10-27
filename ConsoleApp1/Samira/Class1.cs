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

        public void fifthTask()
        {
            Console.WriteLine("Enter the distance  in kilometer : ");
            double dist = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The distance between New York and vienna is  " + (dist * 0.6214) + " miles." );

        }

        public void sixthTask()
        {
            Console.WriteLine("Ente a number : ");
            double firNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ente another number : ");
            double secNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The sum is : " + (firNumber + secNumber));
            Console.WriteLine("The substract is : " + (firNumber - secNumber));
            Console.WriteLine("The multiply is : " + (firNumber * secNumber));
            Console.WriteLine("The division is : " + (firNumber / secNumber));


        }
        public void seventhTask()
        {
            Console.WriteLine("Enter your weight : ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your height in meters : ");
            double height = Convert.ToDouble(Console.ReadLine());
        
            Console.WriteLine("Your BMI is : " + (weight / (height*height)));

        }
    }
}
