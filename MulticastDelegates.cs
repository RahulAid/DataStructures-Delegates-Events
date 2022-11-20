using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class MulticastDelegates
{
    delegate void MultipleOperation(int x, int y);

    public static void ImplementMulticastDelegates()
    {
        Console.WriteLine("\nMulticast Delegates");
        MultipleOperation objMultiDel = Operation.Add;
        objMultiDel += Operation.Sub;

        objMultiDel(25, 15);
        objMultiDel(25, 15);
    }

    public class Operation
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine($"\nAddition Operation : {a + b}");
        }

        public static void Sub(int a, int b)
        {
            Console.WriteLine($"\nSubtraction Operation : {a - b}");
        }
    }
}
