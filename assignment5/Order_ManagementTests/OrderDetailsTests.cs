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
    public class OrderDetailsTests
    {
        [TestMethod()]
        public void EqualsTest()
        {
            OrderDetails details1 = new OrderDetails { productName = "Apple", price = 5, quantity = 10 };
            OrderDetails details2 = new OrderDetails { productName = "Apple", price = 5, quantity = 10 };
            Assert.IsTrue(details1.Equals(details2));
        }

        [TestMethod()]
        public void GetHashCodeTest()
        {
            var details1 = new OrderDetails { productName = "Apple", price = 5, quantity = 10 };
            var details2 = new OrderDetails { productName = "Apple", price = 5, quantity = 10 };
            Assert.AreEqual(details1.GetHashCode(), details2.GetHashCode());
        }

        [TestMethod()]
        public void ToStringTest()
        {
            var details1 = new OrderDetails { productName = "Apple", price = 5, quantity = 10 };
            string result = "productName:Apple,price:5,quantity:10";
            Assert.AreEqual(result, details1.ToString());
        }
    }
}