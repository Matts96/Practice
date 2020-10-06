using System;
using System.IO;

namespace _3200
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] lines = { "First line", "Second Line", "Third Line" };
            //System.IO.File.WriteAllLines(@"C:\Users\bowle\OneDrive\Desktop\CSET 3200 HW3", lines);
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\bowle\OneDrive\Desktop\CSET 3200 HW3"))
            {
                file.WriteLine("Hello");
                string nameString;
                string addressString;
                Console.WriteLine("Enter your Name: ");
                nameString = Console.ReadLine();
                Console.WriteLine("Your name is {0} ", nameString);
                Console.WriteLine("Enter your Address: ");
                addressString = Console.ReadLine();
                Console.WriteLine("Your address is {0} ", addressString);

                //using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\bowle\OneDrive\Desktop\CSET 3200 HW3.txt"))
                file.WriteLine("Name: {0} ", nameString);
                file.WriteLine("Address: {0} ", addressString);
            }
        }
    }
}
