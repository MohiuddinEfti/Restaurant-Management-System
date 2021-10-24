using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restuarent
{
    class CustomerOrders
    {
        public int Id { get; set; }

        public string CustomerName { get; set; }

        public int TableNo { get; set; }
        public string TotalOrder { get; set; }
        public string Price { get; set; }
        public string OrderTime { get; set; }
        public string ChefOrderDone { get; set; }
        public string CustomerRecievedTime { get; set; }
        public string Date { get; set; }

        public string Payment { get; set; }

    }
}
