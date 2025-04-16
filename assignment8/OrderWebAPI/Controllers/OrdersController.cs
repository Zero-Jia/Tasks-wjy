using OrderApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace OrderWebAPI.Controllers
{
    [RoutePrefix("api/orders")]
    public class OrdersController : ApiController
    {
        private readonly OrderService orderService = new OrderService();

        // GET: api/orders
        [HttpGet]
        [Route("")]
        public IHttpActionResult GetAllOrders()
        {
            try
            {
                var orders = orderService.Orders;
                return Ok(orders);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // GET: api/orders/5
        [HttpGet]
        [Route("{id}")]
        public IHttpActionResult GetOrder(string id)
        {
            try
            {
                var order = orderService.GetOrder(id);
                if (order == null)
                {
                    return NotFound();
                }
                return Ok(order);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // POST: api/orders
        [HttpPost]
        [Route("")]
        public IHttpActionResult CreateOrder([FromBody] Order order)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                orderService.AddOrder(order);
                return CreatedAtRoute("DefaultApi", new { id = order.OrderId }, order);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // PUT: api/orders/5
        [HttpPut]
        [Route("{id}")]
        public IHttpActionResult UpdateOrder(string id, [FromBody] Order order)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                if (id != order.OrderId)
                {
                    return BadRequest("Order ID mismatch");
                }

                orderService.UpdateOrder(order);
                return Ok(order);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // DELETE: api/orders/5
        [HttpDelete]
        [Route("{id}")]
        public IHttpActionResult DeleteOrder(string id)
        {
            try
            {
                var order = orderService.GetOrder(id);
                if (order == null)
                {
                    return NotFound();
                }

                orderService.RemoveOrder(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // GET: api/orders/bycustomer?name=xxx
        [HttpGet]
        [Route("bycustomer")]
        public IHttpActionResult GetOrdersByCustomer(string name)
        {
            try
            {
                var orders = orderService.QueryOrdersByCustomerName(name);
                return Ok(orders);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // GET: api/orders/byproduct?name=xxx
        [HttpGet]
        [Route("byproduct")]
        public IHttpActionResult GetOrdersByProduct(string name)
        {
            try
            {
                var orders = orderService.QueryOrdersByProductName(name);
                return Ok(orders);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // GET: api/orders/bytotalprice?price=xxx
        [HttpGet]
        [Route("bytotalprice")]
        public IHttpActionResult GetOrdersByTotalPrice(float price)
        {
            try
            {
                var orders = orderService.QueryByTotalPrice(price);
                return Ok(orders);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
