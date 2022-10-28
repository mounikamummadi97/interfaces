using System;
interface Icustomer1
{
    void print1();
}
interface Icustomer2 : Icustomer1
{
    void print2();
}
public class customer : Icustomer2
{
    public void print2()
    {
        Console.WriteLine("print2");
    }

    public void print1()
    {
        Console.WriteLine("print1");
    }
}
public class program
{
    public static void Main()
    {
        customer C1 = new customer();
        C1.print1();
    }
}
