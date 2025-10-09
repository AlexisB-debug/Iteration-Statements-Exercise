namespace IterationStatements
{
    public class Program
    {
        static void Main(string[] args)
        {
            PrintNumbers();
            PrintEveryThirdNumber();
            //The instructions read:
            //"For training purposes, most if not all the data for these methods can come from user input."
            //That is why I created seven do-while loops in the Main Method (I learned this after I first submitted).
            Console.WriteLine("The method AreNumbersEqual checks whether two integers are the same number or different numbers.");
            
            bool num1IsAnInteger;
            int num1;
            do
            {
                Console.WriteLine("Please, type the first integer:");
                num1IsAnInteger = int.TryParse(Console.ReadLine(), out num1);
            }while(!num1IsAnInteger);
            
            bool num2IsAnInteger;
            int num2;
            do
            {
                Console.WriteLine("Please, type the second integer:");
                num2IsAnInteger = int.TryParse(Console.ReadLine(), out num2);
            }while(!num2IsAnInteger);
            
            Console.WriteLine($"It is {AreNumbersEqual(num1,num2)} that the numbers are the same.");
            
            Console.WriteLine("The method IsEven checks whether a number is even or odd.");
            
            bool num3IsAnInteger;
            int num3;
            do
            {
                Console.WriteLine("Please, type the integer:");
                num3IsAnInteger = int.TryParse(Console.ReadLine(), out num3);
            }while(!num3IsAnInteger);
            
            Console.WriteLine($"It is {IsEven(num3)} that the number is even.");
            
            Console.WriteLine("The method IsPositive checks whether an integer is positive or negative.");
            
            bool num4IsAnInteger;
            int num4;
            do
            {
                Console.WriteLine("Please, type the integer:");
                num4IsAnInteger = int.TryParse(Console.ReadLine(), out num4);
            }while(!num4IsAnInteger);

            Console.WriteLine($"It is {IsPositive(num4)} that the number is positive.");
            
            Console.WriteLine("The method CanVote checks whether a candidate is voting age.");
            
            bool num5IsAnInteger;
            int num5;
            do
            {
                Console.WriteLine("Please, tell me the number of your last birthday. Type an integer:");
                num5IsAnInteger = int.TryParse(Console.ReadLine(), out num5);
            }while(!num5IsAnInteger);
            
            Console.WriteLine($"It is {CanVote(num5)} that the candidate is voting age!");
            
            Console.WriteLine("The method IsInRange checks whether an integer is within the range of -10 to 10.");
            
            bool num6IsAnInteger;
            int num6;
            do
            {
                Console.WriteLine("Please, type the integer:");
                num6IsAnInteger = int.TryParse(Console.ReadLine(), out num6);
            }while(!num6IsAnInteger);

            Console.WriteLine($"It is {IsInRange(num6)} that the number is within the range of -10 to 10");
            
            Console.WriteLine("The method DisplayMultiplicationTable displays the multiplication table (from 1 to 12) for an integer.");
            
            bool num7IsAnInteger;
            int num7;
            do
            {
                Console.WriteLine("Please, type the integer:");
                num7IsAnInteger = int.TryParse(Console.ReadLine(), out num7);
            }while(!num7IsAnInteger);

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
                break;
            default:
                return false;
                break;
            }
        }
        
        public static bool IsEven(int num3)
        {
            switch (num3 % 2 == 0)
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
            for (int k = 1; k <= 12; k++)
            {
                Console.WriteLine($"{k} * {number} = {k * number}");
            }
        }
    }
}
