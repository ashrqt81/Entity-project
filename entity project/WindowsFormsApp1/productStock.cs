using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class productStock
    {
        [Key]
        public int proStockId { get; set; }
        [ForeignKey("stock")]
        public int stockId { get; set; }
        [ForeignKey("product")]
        public int ProductId { get; set; }
        public product product { get; set; }
        public stock stock { get; set; }//navigation property
        public double quantity { get; set; }
    }
}
