namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine("Hello, " + args[0] + "!");
            }
            else
            {
                Console.WriteLine("Enter your name: ");

                string name= Console.ReadLine();
                if (String.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Hello");
                }
                else
                {
                    Console.WriteLine(name);
                }

            }

        }
    }
}
