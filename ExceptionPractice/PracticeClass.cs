using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionPractice;

public class PracticeClass
{
    public static void exceptionMethod()
    {
        throw new Exception("Something bad happened");
        return;
    }

    public static void caughtException()
    {
        try
        {
            throw new Exception("Something bad happened, but its ok!");
        }
        catch(Exception ex)
        {
            Console.WriteLine($"LOG: An exception was thrown: {ex.Message}");
        }
    }

    public static void innerExceptionTest()
    {
        try
        {
            exceptionMethod();
        }
        catch(Exception ex)
        {
            Console.WriteLine($"LOG: Inner method threw an exception, but it was caught");
        }
    }

    public static void catchAndRethrow()
    {
        try
        {
            exceptionMethod();
        }
        catch(Exception ex)
        {
            Console.WriteLine("LOG: An exception was thrown, logging and rethrow");
            throw;
        }
    }

    public static void doubleThrowTest()
    {
        try
        {
            catchAndRethrow();
        }
        catch(Exception ex)
        {
            Console.WriteLine("LOG: Exception caught by the outer method");
        }
        finally 
        {
            Console.WriteLine("Made it to the finally code");
        }
        
        Console.WriteLine("Made it outside of the try catch block");
    }
}
