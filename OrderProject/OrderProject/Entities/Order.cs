using OrderProject.Entities.Enums;


namespace OrderProject.Entities
{
    internal class Order
    {
        DateTime Moment { get; set; }
        OnderStatus Status { get; set; }

        List<OrderItem> items { get; set; } = new List<OrderItem>();

        public Order() { }

        public Order(DateTime moment, OnderStatus status)
        {
            Moment = moment;
            Status = status;
        }

        public void AddItem(OrderItem item)
        {
            items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {items.Remove(item);

        }
        public double Total()
        {
            double total = 0;
            foreach (OrderItem item in items)
            {
                total += item.subTotal();
            }

            return total;
        }
    }
}
