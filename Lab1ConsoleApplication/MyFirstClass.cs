using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int myAge = 20;
            double myGPA = 3.5;
            bool likeCIS235 = true;

            Console.WriteLine("My Age: \t" + myAge);
            Console.WriteLine("My GPA: \t" + myGPA);
            Console.WriteLine("I Like CIS235? \t" + likeCIS235);

            Console.WriteLine("");
            Console.WriteLine("myAge + myGPA: \t" + (myAge + myGPA));
            Console.WriteLine("myAge - myGPA: \t" + (myAge - myGPA));
            Console.WriteLine("myAge * myGPA: \t" + (myAge * myGPA));
            Console.WriteLine("myAge / myGPA: \t" + (myAge / myGPA));

            Console.Write("");
            Console.WriteLine("myAge:    \t" + myAge);
            Console.WriteLine("++myAge: \t" + ++myAge);
            Console.WriteLine("myAge++: \t" + myAge++);
            Console.WriteLine("myAge++: \t" + myAge++);
            Console.WriteLine("--myAge: \t" + --myAge);
            Console.WriteLine("myAge--: \t" + myAge--);
            Console.WriteLine("myAge--: \t" + myAge--);
            Console.WriteLine("myAge:    \t" + myAge);

            Console.WriteLine("");
            if(likeCIS235)
            {
                Console.WriteLine("I like CIS235!");
            }

            if (likeCIS235 == true)
            {
                Console.WriteLine("I really like CIS235!");
            }

            if (likeCIS235 == false)
            {
                Console.WriteLine("I do not like CIS235");
            }

            Console.WriteLine("");
            Console.WriteLine("if/else test");
            if(likeCIS235)
            {
                Console.WriteLine("I think CIS235 is great!");
            }
            else
            {
                Console.WriteLine("I do not like CIS235!");
            }

            Console.WriteLine("");
            Console.WriteLine("switch statement example");
            switch (myAge)
            {
                case 20:
                    Console.WriteLine("I am 20 years old.");
                    break;
                case 21:
                    Console.WriteLine("I am 21 years old.");
                    break;
                default:
                    Console.WriteLine("Unknown age!");
                    break;
            }

            Console.WriteLine("");
            Console.WriteLine("5 element integer array created");

            int[] myStdAgeArray = new int[5];
            myStdAgeArray[0] = 20;
            myStdAgeArray[1] = 18;
            myStdAgeArray[2] = 21;
            myStdAgeArray[3] = 23;
            myStdAgeArray[4] = 28;

            Console.WriteLine("Student 1 age: \t" + myStdAgeArray[0]);
            Console.WriteLine("Student 2 age: \t" + myStdAgeArray[1]);
            Console.WriteLine("Student 3 age: \t" + myStdAgeArray[2]);
            Console.WriteLine("Student 4 age: \t" + myStdAgeArray[3]);
            Console.WriteLine("Student 5 age: \t" + myStdAgeArray[4]);

            Console.WriteLine("");
            Console.WriteLine("for loop example 1");
            for (int k=0; k<=4; k++)
            {
                Console.WriteLine("Student age: \t" + myStdAgeArray[k]);
            }

            Console.WriteLine("");
            Console.WriteLine("for loop example 2");
            int stdNo = 0;
            for (int k = 0; k < myStdAgeArray.Length; k++)
            {
                stdNo++;
                Console.WriteLine("Student " + stdNo + " age: \t" + myStdAgeArray[k]);
            }

            Console.WriteLine("");
            Console.WriteLine("while loop example");
            double[] myGPAArray = { 3.5, 4.0, 3.1, 2.8 };
            int noOfElements = myGPAArray.Length;
            int stdNum = 0;
            while (stdNum < noOfElements)
            {
                Console.WriteLine("Student " + stdNum + " GPA: \t" + myGPAArray[stdNum]);

                stdNum++;
            }

            Console.WriteLine("");
            Console.WriteLine("do-while loop example");
            int noOfElements2 = myGPAArray.Length;
            int stdNum2 = 0;
            do
            {
                Console.WriteLine("Student " + stdNum2 + " GPA: \t" + myGPAArray[stdNum2]);
                stdNum2++;
            } while (stdNum2 < noOfElements2);

            Console.WriteLine("");
            Console.WriteLine("Programmed By: Brittany Rowe");

            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();

        }
    }
}
