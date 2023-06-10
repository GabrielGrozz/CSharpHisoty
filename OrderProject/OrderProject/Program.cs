using OrderProject.Entities;
using OrderProject.Entities.Enums;
using System.Globalization;

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

            Console.Write("Birth date (DD/MM/YYYY)");

            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(clientName, clientEmail, birthDate);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            string orderString = Console.ReadLine();
            OrderStatus orderStatus = (OrderStatus)Enum.Parse(typeof(OrderStatus), orderString);


            Console.Write("How many items to this order? ");
            int orderItems = int.Parse(Console.ReadLine());

            for (int i = 0; i < orderItems - 1; i++)
            {
                Order order = new Order(DateTime.Now, orderStatus, client);
                for (int j = 0; j < orderItems; j++)
                {

                    Console.WriteLine($"Enter #{j + 1} item data:");
                    Console.Write("Product Name: ");
                    string productName = Console.ReadLine();

                    Console.Write("Product Price: ");
                    double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Quantity: ");
                    int itemQuantity = int.Parse(Console.ReadLine());

                    OrderItem item = new OrderItem(itemQuantity, productPrice);
                    Product product = new Product(productName, productPrice);
                    item.ProductItem = product;
                    order.AddItem(item);
                }

                Console.WriteLine(order);
            }

        }
    }
}
