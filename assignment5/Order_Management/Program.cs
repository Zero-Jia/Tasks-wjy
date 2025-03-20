using System.Globalization;
using static Order_Management.Program;

namespace Order_Management
{
    public class OrderDetails
    {
        public string productName { get; set; }
        public decimal price { get; set; }
        public int quantity { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is OrderDetails other)
            {
                return productName == other.productName &&
                       price == other.price &&
                       quantity == other.quantity;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(productName, price, quantity);
        }

        public override string ToString()
        {
            return $"productName:{productName},price:{price},quantity:{quantity}";
        }
    }
    public class Order
    {
        public int orderId { get; set; }
        public string customer { get; set; }
        public List<OrderDetails> details = new List<OrderDetails>();
        public decimal totalAmount => details.Sum(d => d.price * d.quantity);
        public override bool Equals(object obj)
        {
            if (obj is Order other)
            {
                return orderId == other.orderId && customer == other.customer && details.SequenceEqual(other.details);
            }
            return false;
        }
        public override int GetHashCode()
        {
            var hash = HashCode.Combine(orderId, customer);
            if (details != null)
            {
                foreach(var detail in details)
                {
                    hash = HashCode.Combine(hash, detail);
                }
            }
            return hash;
        }
        public override string ToString()
        {
            return $"order ID: {orderId}, customer: {customer}, Total Amount: {totalAmount}\nDetails:\n{string.Join("\n", details)}";
        }
    }
    public class OrderService
    {
        private List<Order> orders = new List<Order>();
        public void addOrder(Order order)
        {
            if (orders.Contains(order))
            {
                throw new InvalidOperationException("Order already exists.");
            }
            orders.Add(order);
        }
        public void removeOrder(int orderId)
        {
            var order = orders.FirstOrDefault(o => o.orderId == orderId);
            if (order == null)
            {
                throw new InvalidOperationException("Order not found.");
            }
            orders.Remove(order);
        }
        public void modifyOrder(Order order)
        {
            var existingOrder = orders.FirstOrDefault(o => o.orderId == order.orderId);
            if (existingOrder == null)
            {
                throw new InvalidOperationException("Order not found.");
            }
            orders.Remove(existingOrder);
            orders.Add(order);
        }
        public List<Order> queryOrders(Func<Order, bool> predicate)
        {
            return orders.Where(predicate).OrderBy(o => o.totalAmount).ToList();
        }
        public void sortOrders(Comparison<Order> comparison = null)
        {
            if (comparison == null)
            {
                orders.Sort((o1, o2) => o1.orderId - o2.orderId);
            }
            else
            {
                orders.Sort(comparison);
            }
        }
        public List<Order> getAllOrders()
        {
            return orders;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderService service = new OrderService();
            Order order1 = new Order { orderId = 1, customer = "Tom" };
            order1.details.Add(new OrderDetails { productName = "Apple", price = 5, quantity = 10 });
            order1.details.Add(new OrderDetails { productName = "Banana", price = 3, quantity = 5 });
            Order order2 = new Order { orderId = 2, customer = "Jerry" };
            order2.details.Add(new OrderDetails { productName = "Orange", price = 4, quantity = 15 });
            service.addOrder(order2);
            service.addOrder(order1);
            //显示所有订单
            Console.WriteLine("现在显示初始订单：");
            var allOrders1 = service.getAllOrders();
            foreach (var order in allOrders1)
            {
                Console.WriteLine(order);
            }
            //为订单排序并显示所有订单
            Console.WriteLine("为订单排序并显示所有订单：");
            service.sortOrders();
            var allOrders3 = service.getAllOrders();
            foreach (var order in allOrders3)
            {
                Console.WriteLine(order);
            }
            //查询订单
            Console.WriteLine("现在显示顾客为Tom的订单：");
            var queryResult = service.queryOrders(o => o.customer == "Tom");
            foreach(var order in queryResult)
            {
                Console.WriteLine(order);
            }
            //修改订单
            order1.details.Add(new OrderDetails { productName = "Grape", price = 6, quantity = 7 });
            service.modifyOrder(order1);
            //删除订单
            service.removeOrder(2);
            //显示所有订单
            Console.WriteLine("现在显示修改、删除后的订单：");
            var allOrders2 = service.getAllOrders();
            foreach(var order in allOrders2)
            {
                Console.WriteLine(order);
            }
        }
    }
}
