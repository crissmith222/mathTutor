//Cristian Cedeno
//N01369950
using System;
using static System.Console;

namespace mathTutor
{
    class MathTutorApp
    {
        static void Main(string[] args)
        {
            int num1, num2;
            int cAnswer = 0;
            int uAnswer = 0;
            bool flag = true;
            string whatNext = "";

            Write("Please Enter your name: ");
            String inName = ReadLine();
            Write("Please Enter your Grade from 1 to 5: ");
            String inGrade = ReadLine();
            Student student = new Student(inName, inGrade);


            while (true)
            {
                WriteLine("Enter the math skill that you like to be tested with the following options:");
                WriteLine("Addition--------ENTER 1--");
                WriteLine("Subtraction-----ENTER 2--");
                WriteLine("Multiplication--ENTER 3--");
                WriteLine("Random----------ENTER 4--");
                Write("Option: ");
                String inValue = ReadLine();
                int inOption = int.Parse(inValue);

                Console.Clear();

                while (inOption < 1 && inOption > 4)
                {
                    WriteLine("Incorrect option! Please Try again");
                    inValue = ReadLine();
                    inOption = int.Parse(inValue);
                }

                var rand = new Random();

                if (inOption == 4)
                {
                    inOption = rand.Next(1, 4);
                }

                while (true)
                {
                    switch (inOption)
                    {
                        case 1:
                            num1 = rand.Next(11);
                            num2 = rand.Next(11);
                            Write("What is {0} + {1} = ", num1, num2);
                            inValue = ReadLine();
                            uAnswer = int.Parse(inValue);
                            cAnswer = num1 + num2;
                            break;
                        case 2:
                            num1 = rand.Next(11);
                            num2 = rand.Next(11);
                            Write("What is {0} - {1} = ", num1, num2);
                            inValue = ReadLine();
                            uAnswer = int.Parse(inValue);
                            cAnswer = num1 - num2;
                            break;
                        case 3:
                            num1 = rand.Next(11);
                            num2 = rand.Next(11);
                            Write("What is {0} * {1} = ", num1, num2);
                            inValue = ReadLine();
                            uAnswer = int.Parse(inValue);
                            cAnswer = num1 * num2;
                            break;
                        default:
                            WriteLine("Incorrect option! Please try again");
                            break;
                    }


                    if (cAnswer == uAnswer)
                    {
                        WriteLine("Correct! Good Job!");
                        student.correct++;
                    }
                    else
                    {
                        WriteLine("Sorry That's inconrect. The Correct answer {0}", cAnswer);
                        student.incorrect++;
                    }

                    WriteLine("To continuo to next question press n. To display manu press m. To stop the press any other key.");
                    whatNext = ReadLine();

                    Console.Clear();

                    if (!whatNext.Equals("n"))
                    {
                        break;
                    }

                }

                if (!whatNext.Equals("m"))
                {
                    break;
                }
            }

            Console.Clear();
            WriteLine("----Student report----");
            WriteLine("Name: {0}", student.sName);
            WriteLine("Grade Level: K-{0}", student.sGrade);
            WriteLine("Correct answers: {0}", student.correct);
            WriteLine("Incorrect answer: {0}", student.incorrect);



        }

        

    }

    

    class Student
    {
        public string sName, sGrade;
        public int correct = 0;
        public int incorrect = 0;

        public Student(string n, string g)
        {
            sName = n;
            sGrade = g;
        }


    }
}
