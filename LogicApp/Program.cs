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

            // Variants of OR statements
            // true || true -> true
            // true || false -> true
            // false || true -> true
            // false || false -> false

            // Variants of AND statements
            // true || true -> true
            // true || false -> false
            // false || true -> false
            // false || false -> false

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
