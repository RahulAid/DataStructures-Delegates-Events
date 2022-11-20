namespace DataStructures_Delegates_Events
{
    public delegate int Operation(int x, int y);
    public class Program
    {
        static int Addition(int a, int b)
        {
            return a + b;
        }

        static int Subtraction(int a, int b)
        {
            return a - b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Delegates\n");
            Operation obj1 = new Operation(Addition);
            Operation obj2 = new Operation(Subtraction);

            Console.WriteLine($"\nAddition of two numbers : {obj1(25, 15)}");
            Console.WriteLine($"\nSubtraction of two numbers : {obj2(25, 15)}");

            MulticastDelegates.ImplementMulticastDelegates();

            Console.ReadLine();
        }
    }
}