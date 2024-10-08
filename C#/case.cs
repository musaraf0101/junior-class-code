// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {   
        //calculator +,-,*,/
        
        Console.WriteLine("Input 1st number");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input 2nd number");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("select a operator");
        string opr = Console.ReadLine();
        
        switch(opr){
            case "+":
                Console.WriteLine(num1+num2);
                break;
            case "-":
                 Console.WriteLine(num1-num2);
                 break;
            case "/":
                 Console.WriteLine(num1/num2);
                 break;
            case "*":
                 Console.WriteLine(num1*num2);
                 break;
            default:
                 Console.WriteLine("invalid input");
                 break;
        }
    }
}