using System;

namespace ClassJune16
{
    class Program
    {
        static void Main(string[] args)
        {
            //    try
            //    {
            //        var userInput = GetUserInput();
            //        var parsedValue = int.Parse(userInput);
            //        Console.WriteLine(parsedValue);
            //    }
            //    catch (Exception exception)
            //    {
            //        Console.WriteLine("Invalid input. Check that you entered a number.", exception.Message);

            //    }


            //Write a method that take two numbers and divides > print result to screen
            try
            {
                var parsedNumber = int.Parse("Lebron James is a GOAT");
                Console.WriteLine(divideNumber(10, 5));
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
                //you got the info but still want it to blow up
                throw; 
            }

                 //Catches any other mathematical error
            catch(ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //very broad way to catch any error (not very specific like the two above)
            catch (Exception ex)
            {             
                                          //this will provide a reasoning for you. nope is not needed.
                Console.WriteLine("Nope", ex.Message);
               
            }
            finally
            {
                //meant for classes or objects that are dealing with unmanaged resource
                //Write to a file 
                Console.WriteLine("I have executed.");
            }
           
        }

        
        static double divideNumber(double num1, double num2)
        {
            return num1 / num2;
        }

        //static string GetUserInput()
        //{
        //    Console.WriteLine("Enter a number");
        //    return Console.ReadLine();
        //}
    }
}
