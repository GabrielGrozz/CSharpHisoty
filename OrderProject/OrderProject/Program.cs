namespace OrderProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();

            Console.Write("Email: ");
            string clientEmail = Console.ReadLine();

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            int orderStatus = int.Parse(Console.ReadLine());

            Console.Write("How many items to this order? ");
            int orderItems = int.Parse(Console.ReadLine());

            for (int i = 0; i < orderItems; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product Name: ");
                string productName = Console.ReadLine();

                Console.Write("Product Price: ");
                double itemPrice = int.Parse(Console.ReadLine());

                Console.Write("Quantity: ");
                int itemQuantity = int.Parse(Console.ReadLine());

            }
        }
    }
}