using Microsoft.VisualStudio.TestTools.UnitTesting;
using Order_Management;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_Management.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        [TestMethod()]
        public void addOrderTest()
        {
            OrderService service = new OrderService();
            Order order = new Order { orderId = 1, customer = "Alice" };
            order.details.Add(new OrderDetails { productName = "Apple", price = 5, quantity = 10 });
            service.addOrder(order);
            var orders = service.getAllOrders();
            Assert.AreEqual(order, orders[0]);
        }

        [TestMethod()]
        public void removeOrderTest()
        {
            OrderService service = new OrderService();
            Order order = new Order { orderId = 1, customer = "Alice" };
            order.details.Add(new OrderDetails { productName = "Apple", price = 5, quantity = 10 });
            service.addOrder(order);
            service.removeOrder(1);
            var orders = service.getAllOrders();
            Assert.AreEqual(0, orders.Count);
        }

        [TestMethod()]
        public void modifyOrderTest()
        {
            OrderService service = new OrderService();
            Order order = new Order { orderId = 1, customer = "Alice" };
            order.details.Add(new OrderDetails { productName = "Apple", price = 5, quantity = 10 });
            service.addOrder(order);
            var modifiedOrder = new Order { orderId = 1, customer = "Alice" };
            modifiedOrder.details.Add(new OrderDetails { productName = "Banana", price = 3, quantity = 5 });
            service.modifyOrder(modifiedOrder);
            var orders = service.getAllOrders();
            Assert.AreEqual(modifiedOrder, orders[0]);
        }

        [TestMethod()]
        public void queryOrdersTest()
        {
            var service = new OrderService();
            var order1 = new Order { orderId = 1, customer = "Alice" };
            order1.details.Add(new OrderDetails { productName = "Apple", price = 5, quantity = 10 });
            var order2 = new Order { orderId = 2, customer = "Bob" };
            order2.details.Add(new OrderDetails { productName = "Orange", price = 4, quantity = 8 });
            service.addOrder(order1);
            service.addOrder(order2);
            var result = service.queryOrders(o => o.customer == "Alice");
            Assert.AreEqual(order1, result[0]);
        }

        [TestMethod()]
        public void sortOrdersTest()
        {
            var service = new OrderService();
            var order1 = new Order { orderId = 1, customer = "Alice" };
            order1.details.Add(new OrderDetails { productName = "Apple", price = 5, quantity = 10 });
            var order2 = new Order { orderId = 2, customer = "Bob" };
            order2.details.Add(new OrderDetails { productName = "Orange", price = 4, quantity = 8 });
            service.addOrder(order2);
            service.addOrder(order1);
            service.sortOrders();
            var orders = service.getAllOrders();
            Assert.AreEqual(order1, orders[0]);
            Assert.AreEqual(order2, orders[1]);
        }
    }
}