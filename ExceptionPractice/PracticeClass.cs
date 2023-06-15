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
            Console.WriteLine($"An exception was thrown: {ex.Message}");
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
            Console.WriteLine($"Inner method threw an exception, but it was caught");
        }
    }
}
