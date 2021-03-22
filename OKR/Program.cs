using System;

namespace OKR
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer1 = new Computer(2001, 3, 2049, 321);
            Console.WriteLine(computer1.ToString());
            Computer computer2 = new Computer(1999, 1, 2047, 319);
            Console.WriteLine(computer2.ToString());
            Notebook notebook1 = new Notebook(2001, 3, 2049, 321, 61);
            Console.WriteLine(notebook1.ToString());
            Notebook notebook2 = new Notebook(2001, 3, 2049, 321, 59);
            Console.WriteLine(notebook2.ToString());
        }
    }
}