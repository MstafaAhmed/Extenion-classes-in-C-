// See https://aka.ms/new-console-template for more information


// Extenion Method in classes

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        method1 c = new method1();
        c.method();

        method1 c1 = new method1();
        c1.Extenion1();

        method1 c2 = new method1();
        c2.Extenion2();

        method1 c3 = new method1();
        c3.Extenion3();

        method1 c4 = new method1();
        c4.Extenion4();

        Console.ReadLine();
    }
}

//main class 
public class method1
{
    public void method()
    {
        Console.WriteLine(" Method 1");
    }
}

// Extenion class from class method1
static class method2                                     //static
{
    // this + name of class to be extended + name of object that usedin main
    public static void Extenion1(this method1 c1)              //  static  
    {
        Console.WriteLine("---- Hi from extenion one ---------");
                            
    }
}

// Extenion class from class method1
static class method3
{
    // this + name of class to be extended + name of object that usedin main
    public static void Extenion2(this method1 c2)
    {
        Console.WriteLine("---- Hi from extenion two ---------");
    }

}

// Extenion class from class method1
static class method4
{
    public static void Extenion3(this method1 c3)
    {
        Console.WriteLine("---- Hi from extenion three ---------");
    }
}

// Extenion class from class method1
static class method5
{
    public static void Extenion4(this method1 c4)
        {
        Console.WriteLine("---- Hi from extenion four ---------");
    }
}