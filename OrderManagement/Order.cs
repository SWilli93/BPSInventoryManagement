using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPSInventoryManagement.OrderManagement
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime OrderFulfilmentDate { get; private set; }
        public List<OrderItem> OrderItems { get; set; }
        public bool Fulfilled { get; set; } = false;


        public Order()
        {
            Id = new Random().Next(9999999);

            int numberofSeconds = new Random().Next(100);

            OrderFulfilmentDate = DateTime.Now.AddSeconds(numberofSeconds);

            OrderItems = new List<OrderItem>();

        }
    }
}