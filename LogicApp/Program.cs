namespace LogicApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            bool isRainy = true;
            bool hasUmbrella = true;

            // Logical Operators
            // AND &&
            // OR  ||
            // NOT !

            if (isRainy && hasUmbrella)
            {
                Console.WriteLine("I am protected against rain");
            }

            if (!isRainy || hasUmbrella)
            {
                Console.WriteLine("I am not getting wet");
            }
            Console.WriteLine("Ay OK!");
            Console.ReadKey();
        }
    }
}
