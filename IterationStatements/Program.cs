namespace IterationStatements
{
    public class Program
    {
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature: void PrintNumbers()
        public static void PrintNumbers()
        {
            int i = 1000;
            while (i >= -1000)
            {
                Console.WriteLine(i);
                i = i - 1;
            }
        }
        
        // 2. Write a method that prints every third number from 3 to 999 to the console.
        //    - Method Signature: void PrintEveryThirdNumber()
        public static void PrintEveryThirdNumber()
        {
            int i = 3;
            while (i <= 999)
            {
                Console.WriteLine(i);
                i = i + 3;
            }
        }

        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.
        public static bool AreNumbersEqual(int num1, int num2)
        {
            switch (num1 == num2)
            {
            case true:
                return true;
                break;
            default:
                return false;
                break;
            }

        }

        // 4. Write a method that checks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.
        public static bool IsEven(int number)
        {
            switch (number % 2 == 0)
            {
                case true:
                    return true;
                    break;
                default:
                    return false;
                    break;
            }
        }

        // 5. Write a method that checks if a given number is positive or negative.
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.
        public static bool IsPositive(int number)
        {
            switch (number > 0)
            {
                case true:
                    return true;
                    break;
                default:
                    return false;
                    break;
            }
        }

        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.
        public static bool CanVote(int age)
        {
            Console.WriteLine("Please, tell me the number of your last birthday. Enter an integer.");
            var canParse = int.TryParse(Console.ReadLine(), out age);

            while (!canParse)
            {
                Console.WriteLine("Please, enter an integer.");
                canParse = int.TryParse(Console.ReadLine(), out age);
            }

            switch (age >= 18)
            {
                case true:
                    return true;
                    break;
                default:
                    return false;
                    break;
            }
        }
        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.
        public static bool IsInRange(int number)
        {
            Console.WriteLine("Please, enter an integer.");
            var canParse = int.TryParse(Console.ReadLine(), out number);

            while (!canParse)
            {
                Console.WriteLine("Please, enter an integer.");
                canParse = int.TryParse(Console.ReadLine(), out number);
            }

            switch (number <= 10 && number >= -10)
            {
                case true:
                    return true;
                    break;
                default:
                    return false;
                    break;
            }
        }
        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"
        public static void DisplayMultiplicationTable(int number)
        {
            int i = 1;
            while (i <= 12)
            {
                Console.WriteLine($"{i} x {number} = {i * number}");
                i = i + 1;
            }
        }
        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.        
        static void Main(string[] args)
        {
            //PrintNumbers();
            //PrintEveryThirdNumber();
            //Console.WriteLine($"It is {AreNumbersEqual(3,7)} that the numbers are the same.");
            //Console.WriteLine($"It is {IsEven(7)} that the number is even.");
            //Console.WriteLine($"It is {IsPositive(-3)} that the number is positive.");
            //The instructions required the Method Signature: bool CanVote(int age) 
            //The program requires me to type some integer into the argument to call the method;
            //Ignore that integer. That integer is not the candidate age which the program will run.
            //The program will run the integer which the user types.
            //Console.WriteLine($"It is {CanVote(17)} that the candidate is voting age!");
            //Console.WriteLine($"It is {IsInRange(7)} that the number is within the range of -10 to 10");
            //DisplayMultiplicationTable(7);
        }
    }
}
