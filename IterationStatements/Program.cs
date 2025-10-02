namespace IterationStatements
{
    public class Program
    {
        public static void PrintNumbers()
        {
            int i = 1000;
            while (i >= -1000)
            {
                Console.WriteLine(i);
                i = i - 1;
            }
        }
        
        public static void PrintEveryThirdNumber()
        {
            int i = 3;
            while (i <= 999)
            {
                Console.WriteLine(i);
                i = i + 3;
            }
        }
        
        public static bool AreNumbersEqual(int num1, int num2)
        {
            Console.WriteLine("This method checks whether two integers are the same number or different numbers.");
            Console.WriteLine("Please, enter the first integer");
            var canParse = int.TryParse(Console.ReadLine(), out num1);

            while (!canParse)
            {
                Console.WriteLine("Please, enter an integer");
                canParse = int.TryParse(Console.ReadLine(), out num1);
            }

            Console.WriteLine("Please, enter the second integer");
            var canParse2 = int.TryParse(Console.ReadLine(), out num2);

            while (!canParse2)
            {
                Console.WriteLine("Please, enter an integer");
                canParse2 = int.TryParse(Console.ReadLine(), out num2);
            }

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
        
        public static bool IsEven(int number)
        {
            Console.WriteLine("Please, enter a number to check whether it is even or odd.");
            var canParse = int.TryParse(Console.ReadLine(), out number);
            
            while (!canParse)
            {
                Console.WriteLine("Please, enter an integer.");
                canParse = int.TryParse(Console.ReadLine(), out number);
            }

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
        
        public static bool IsPositive(int number)
        {
            Console.WriteLine("This method checks whether an integer is positive or negative.\nPlease, enter an integer.");
            var canParse = int.TryParse(Console.ReadLine(), out number);
            
            while (!canParse)
            {
                Console.WriteLine("Please, enter an integer.");
                canParse = int.TryParse(Console.ReadLine(), out number);
            }

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
        
        public static bool IsInRange(int number)
        {
            Console.WriteLine("This method checks whether an integer is within the range of -10 to 10.\nPlease, enter an integer.");
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
        
        public static void DisplayMultiplicationTable(int number)
        {
            Console.WriteLine("This method displays the multiplication table (from 1 to 12) for an integer.\nPlease, enter an integer.");
            var canParse = int.TryParse(Console.ReadLine(), out number);
            
            while (!canParse)
            {
                Console.WriteLine("Please, enter an integer.");
                canParse = int.TryParse(Console.ReadLine(), out number);
            }

            int i = 1;
            while (i <= 12)
            {
                Console.WriteLine($"{i} * {number} = {i * number}");
                i = i + 1;
            }
        }
                
        static void Main(string[] args)
        {
            PrintNumbers();
            PrintEveryThirdNumber();
            //The instructions required the Method Signature: bool MethodName(parameters) for the methods below
            //The program requires me to type some integer into the argument to call the method;
            //Ignore that integer. That integer is not the user input.
            //The program will run what the user types when prompted and not the argument.
            Console.WriteLine($"It is {AreNumbersEqual(3,7)} that the numbers are the same.");
            Console.WriteLine($"It is {IsEven(7)} that the number is even.");
            Console.WriteLine($"It is {IsPositive(-3)} that the number is positive.");
            Console.WriteLine($"It is {CanVote(17)} that the candidate is voting age!");
            Console.WriteLine($"It is {IsInRange(7)} that the number is within the range of -10 to 10");
            DisplayMultiplicationTable(7);
        }
    }
}
