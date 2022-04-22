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
            // Console.WriteLine(thirteen_comparison(20, 10, 4));
            // 14
            // fourteen_betterCalc();
            // 15
            // Console.WriteLine(fifteen_switch(80));
            // 16
            // sixteen_while();
            // 17
            // seventeen_game();
            // 18
            // eighteen_forloops();
            // 19
            // Console.WriteLine(nineteen_exponent(3,2));
            // 20
            // twenty_array2d();
            // 21
            // twentyTwo_handling();
            // 22 - Class & object
            // Book book1 = new Book();
            // book1.title = "Harry Potter";
            // book1.author = "JK Rowling";
            // book1.pages = 400;

            // Book book2 = new Book();
            // book2.title = "Lord of the rings";
            // book2.author = "Tolkein";
            // book2.pages = 400;

            // Console.WriteLine(book1.title);
            // Console.WriteLine(book2.author);

            // 23 - Constructor
            // Book book1 = new Book("Harry Potter","JK Rowling",400);
            // book1.title = "The Hobbit";
            // Console.WriteLine(book1.title);
            // Console.WriteLine(book1.author);
            // Console.WriteLine(book1.pages);

            // 24 - Object Methods
            // Student student1 = new Student("Jim", "Business", 2.8);
            // Student student2 = new Student("Pam", "Art", 3.6);

            // Console.WriteLine(student1.hasHonors());
            // Console.WriteLine(student2.hasHonors());

            // 25 - getters & setters
            // Movie avangers = new Movie("The Avengers", "Joss Whedon", "Dog");
            // Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");
            // shrek.Rating = "R";
            // Console.WriteLine(avangers.Rating);
            // Console.WriteLine(shrek.Rating);

            // 26 - Static Class Attribute => atribut milik kelas
            // Song holiday = new Song("Holiday", "Green Day", 200);
            // Console.WriteLine(holiday.getSongCount());
            // Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            // Console.WriteLine(kashmir.getSongCount());
            // Console.WriteLine(holiday.artist);
            // Console.WriteLine(kashmir.artist);

            // 27 - Static method and classes => static Method milik kelas, static class kelas tidak bisa didefinisikan sebagai objek, seperti kelas Math.  
            // UsefulTools tools = new UsefulTools();
            // UsefulTools.SayHi("adit");
            // Console.WriteLine(Math.Sqrt(144));

            // 28 - inheritance
            // Virtual untuk menunjukkan bahwa sebuah method dapat dioverride oleh kelas turunannya, sedangkan pada subclass virtual diganti override            
            Chef chef = new Chef();
            chef.MakeSpecialDish();

            ItalianChef Italianchef = new ItalianChef();
            Italianchef.MakeSpecialDish();
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

            Console.Write("Enter Operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 + num2);
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }
        }

        public static string fifteen_switch(int dayNum)
        {
            string dayName;
            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "monday";
                    break;
                case 2:
                    dayName = "tuesday";
                    break;
                case 3:
                    dayName = "wednesday";
                    break;
                case 4:
                    dayName = "thursday";
                    break;
                case 5:
                    dayName = "friday";
                    break;
                case 6:
                    dayName = "saturday";
                    break;
                default:
                    dayName = "Invalid Day Number";
                    break;
            }
            return dayName;
        }

        public static void sixteen_while()
        {
            int index = 6;
            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }

            do
            {
                Console.WriteLine(index);
                index++;
            } while (index <= 5);
        }

        public static void seventeen_game()
        {
            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while (guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.WriteLine("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
            }
            if (outOfGuesses)
            {
                Console.WriteLine("You lose!");
            }
            else
            {
                Console.WriteLine("You win!");
            }
        }

        public static void eighteen_forloops()
        {
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }
        }

        public static int nineteen_exponent(int baseNum, int powNum)
        {
            int result = 1;
            for (int i = 0; i < powNum; i++)
            {
                result *= baseNum;
            };

            return result;
        }

        public static void twenty_array2d()
        {
            int[,] numberGrid = {
                {1,2},
                {2,3},
                {3,4}
            };
            // 2 is rows, and 3 is cols
            int[,] myArray = new int[2, 3];

            Console.WriteLine(numberGrid[1, 1]);
        }

        public static void twentyOne_comments()
        {
            // Single comment
            /*
            Long Comment             
            */
        }

        public static void twentyTwo_handling()
        {
            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }



    }
}
