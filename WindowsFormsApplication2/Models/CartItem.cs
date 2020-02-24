using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.Models
{
    public class CartItem
    {
        public int DrugID { get; set; }
        [DisplayName("Brand Name")]
        public string BrandName { get; set; }


        public int Quantity { get; set; }

        [DisplayName("Unit Price")]
        public decimal UnitPrice { get; set; }

        [DisplayName("Total Price")]
        public decimal TotalPrice { get; set; }
    }
}
