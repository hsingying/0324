using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _0317.Areas.Order.Models
{
    public class OrderService
    {
        public void InsertOrder(Models.Order order)
        {
 
        }
        public Models.Order GetOrderById(String id)
        {
            Models.Order result = new Order();
            result.CustId = "GSS";
            result.CustName = "叡揚";
            return result;
        }
        public List<Models.Order> GetOrderByCondition()
        {
            return new List<Order>();
        }
        public void DeleteOrderById()
        {

        }
        public void UpdateOrderById()
        {

        }
    }
}