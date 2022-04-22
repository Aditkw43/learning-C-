using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            // one_drawing();
            // 2
            // two_variable();
            // 3
            // three_datatype();
            // 4
            // four_string();
            // 5
            // five_num();
            // 6
            // six_input();
            // 7
            // seven_cal();
            // 8
            // eight_madlibs();
            // 9
            // nine_arrays();
            // 10
            // ten_method("Adit", 23);
            // 11
            // int cudeNumber = eleven_return(5);
            // Console.WriteLine(eleven_return(cudeNumber));
            // 12
            // twelve_ifelse();
            // 13
            Console.WriteLine(thirteen_comparison(20, 10, 4));
        }

        public static void one_drawing()
        {
            Console.WriteLine("   /|");
            Console.WriteLine("  /_|");
            Console.WriteLine(" /__|");
            Console.WriteLine("/___|");
            Console.WriteLine(2 + 2);
        }

        public static void two_variable()
        {
            string characterName = "Tom";
            int characterAge;
            characterAge = 25;

            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");

            characterName = "Mike";

            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);
        }

        public static void three_datatype()
        {
            // string phrase = "Giraffe Academy";
            // char grade = 'A';
            // int age = 30;
            // double gpa = 3.81;
            // bool isMale = true;            

            Console.WriteLine("Hello");
        }

        public static void four_string()
        {
            string phrase = "Giraffe Academy" + " is cool ";
            Console.WriteLine(phrase.Substring(8, 3));
        }

        public static void five_num()
        {
            int num = 6;
            num++;
            Console.WriteLine(Math.Round(4.6));
        }

        public static void six_input()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + " you are " + age);
        }

        public static void seven_cal()
        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num1 + num2);
        }

        public static void eight_madlibs()
        {
            string color, pluralNoun, celebrity;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();
            Console.Write("Enter a pluralNoun: ");
            pluralNoun = Console.ReadLine();
            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I Love " + celebrity);
        }

        public static void nine_arrays()
        {
            int[] luckyNumbes = {
                4,8,15,16,23,42
            };

            string[] friends = new string[5];

            Console.WriteLine(luckyNumbes[0]);
        }

        public static void ten_method(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }

        public static int eleven_return(int num)
        {
            int result = num * num * num;
            return result;
        }

        public static void twelve_ifelse()
        {
            bool isMale = false;
            bool isTall = true;

            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short male");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are a not male but you are tall");
            }
            else
            {
                Console.WriteLine("You are either not male or not tall or both");
            }
        }

        public static int thirteen_comparison(int num1, int num2, int num3)
        {
            int result;
            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }

            return result;
        }

        public static void fourteen_betterCalc()
        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
        }
    }
}
