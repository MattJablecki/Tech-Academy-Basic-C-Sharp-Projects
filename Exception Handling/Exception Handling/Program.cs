using System;


class Program
{
    static void Main(string[] args)
    {
        try
        {
            int[] numbers = { 10, 12, 14, 16, 18, 20 };
            Console.WriteLine("Please choose a number to be the divisor.");
            int divisor = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numbers.Length; i++)
            {
                int answer = numbers[i] / divisor;
                Console.WriteLine(numbers[i] + " divided by " + divisor + " equals " + answer);
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please type a whole number.");
            return;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please don't divide by zero.");
            return;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("You have emerged from the try/catch block unscathed. Please continue.");
            Console.ReadLine();
       }
    }
}
//        try
//        {
//            Console.WriteLine("Pick a number.");
//            int numberOne = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Pick a second number.");
//            int numberTwo = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Dividing the two...");
//            int numberThree = numberOne / numberTwo;
//            Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
//            Console.ReadLine();
//        }
//        catch (FormatException ex)
//        {
//            Console.WriteLine("Please type a whole number.");
//            return;
//        }
//        catch (DivideByZeroException ex)
//        {
//            Console.WriteLine("Please don't divide by zero.");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine(ex.Message);
//        }
//        finally
//        {
//            Console.ReadLine();
//        }
//    }
//}

