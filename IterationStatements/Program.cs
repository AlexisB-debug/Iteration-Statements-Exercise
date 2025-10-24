namespace IterationStatements
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The method PrintNumbers prints integers 1000 through -1000 inclusive.");
            PrintNumbers();
            
            Console.WriteLine("The method PrintEveryThirdNumber counts by threes printing the integers 3 to 999 inclusive.");
            PrintEveryThirdNumber();
           
            Console.WriteLine("The method AreNumbersEqual checks whether two integers are the same number or different numbers.");
            int num1 = TryParseDoWhileLoop();
            int num2  = TryParseDoWhileLoop();
            Console.WriteLine($"It is {AreNumbersEqual(num1,num2)} that the numbers are the same.");
            
            Console.WriteLine("The method IsEven checks whether a number is even or odd.");
            int num3 = TryParseDoWhileLoop();
            Console.WriteLine($"It is {IsEven(num3)} that the number is even.");
            
            Console.WriteLine("The method IsPositive checks whether an integer is positive or negative.");
            int num4 = TryParseDoWhileLoop();
            Console.WriteLine($"It is {IsPositive(num4)} that the number is positive.");
            
            Console.WriteLine("The method CanVote checks whether a candidate is voting age.");
            int num5 = TryParseDoWhileLoop();
            Console.WriteLine($"It is {CanVote(num5)} that the candidate is voting age!");
            
            Console.WriteLine("The method IsInRange checks whether an integer is within the range of -10 to 10 inclusive.");
            int num6 = TryParseDoWhileLoop();
            Console.WriteLine($"It is {IsInRange(num6)} that the number is within the range of -10 to 10");
            
            Console.WriteLine("The method DisplayMultiplicationTable displays the multiplication table (from 1 to 12) for an integer.");
            int num7 = TryParseDoWhileLoop();
            DisplayMultiplicationTable(num7);
        }
        public static void PrintNumbers()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        
        public static void PrintEveryThirdNumber()
        {
            for (int j = 3; j <= 999; j +=3)
            {
                Console.WriteLine(j);
            }
        }
        
        public static bool AreNumbersEqual(int num1, int num2)
        {
            switch (num1 == num2)
            {
            case true:
                return true;
            default:
                return false;
            }
        }
        
        public static bool IsEven(int num3)
        {
            switch (num3 % 2 == 0)
            {
                case true:
                    return true;
                default:
                    return false;
            }
        }
        
        public static bool IsPositive(int number)
        {
            switch (number > 0)
            {
                case true:
                    return true;
                default:
                    return false;
            }
        }
        
        public static bool CanVote(int age)
        {
            switch (age >= 18)
            {
                case true:
                    return true;
                default:
                    return false;
            }
        }
        
        public static bool IsInRange(int number)
        {
            switch (number <= 10 && number >= -10)
            {
                case true:
                    return true;
                default:
                    return false;
            }
        }
        
        public static void DisplayMultiplicationTable(int number)
        {
            for (int k = 1; k <= 12; k++)
            {
                Console.WriteLine($"{k} x {number} = {k * number}");
            }
        }

        public static int TryParseDoWhileLoop()
        {
            bool numIsAnInteger;
            int num;
            
            do
            {
                Console.WriteLine("Please, type the integer:");
                numIsAnInteger = int.TryParse(Console.ReadLine(), out num);
            }while(!numIsAnInteger);

            return num;
        }
    }
}
