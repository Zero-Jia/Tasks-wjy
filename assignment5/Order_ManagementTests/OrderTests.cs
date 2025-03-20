using Microsoft.VisualStudio.TestTools.UnitTesting;
using Order_Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_Management.Tests
{
    [TestClass()]
    public class OrderTests
    {
        [TestMethod()]
        public void EqualsTest()
        {
            var order1 = new Order
            {
                orderId = 1,
                customer = "Alice",
                details = new List<OrderDetails>
                {
                    new OrderDetails { productName = "Apple", price = 5, quantity = 10 },
                    new OrderDetails { productName = "Banana", price = 3, quantity = 5 }
                }
            };
            var order2 = new Order
            {
                orderId = 1,
                customer = "Alice",
                details = new List<OrderDetails>
                {
                    new OrderDetails { productName = "Apple", price = 5, quantity = 10 },
                    new OrderDetails { productName = "Banana", price = 3, quantity = 5 }
                }
            };
            Assert.IsTrue(order1.Equals(order2)); 
        }

        [TestMethod()]
        public void GetHashCodeTest()
        {
            var order1 = new Order
            {
                orderId = 1,
                customer = "Alice",
                details = new List<OrderDetails>
                {
                    new OrderDetails { productName = "Apple", price = 5, quantity = 10 },
                    new OrderDetails { productName = "Banana", price = 3, quantity = 5 }
                }
            };
            var order2 = new Order
            {
                orderId = 1,
                customer = "Alice",
                details = new List<OrderDetails>
                {
                    new OrderDetails { productName = "Apple", price = 5, quantity = 10 },
                    new OrderDetails { productName = "Banana", price = 3, quantity = 5 }
                }
            };
            Assert.AreEqual(order1.GetHashCode(), order2.GetHashCode()); 
        }

        [TestMethod()]
        public void ToStringTest()
        {
            var order = new Order
            {
                orderId = 1,
                customer = "Alice",
                details = new List<OrderDetails>
                {
                    new OrderDetails { productName = "Apple", price = 5, quantity = 10 },
                    new OrderDetails { productName = "Banana", price = 3, quantity = 5 }
                }
            };
            string expected = "order ID: 1, customer: Alice, Total Amount: 65\nDetails:\nproductName:Apple,price:5,quantity:10\nproductName:Banana,price:3,quantity:5";
            Assert.AreEqual(expected, order.ToString());
        }
    }
}