using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class productTransfer
    {
        public int id { get; set; }
        [ForeignKey("stock")]
        public int stockId1 { get; set; }
        public int stockId2 { get; set; }
        [ForeignKey("product")]
        public int productId { get; set; }
        public double quantity { get; set; }
        public DateTime productionDate { get; set; }
        public DateTime expireDate { get; set; }
        [ForeignKey("buddy")]
        public int buddyId { get; set; }
        public stock stock { get; set; }
        public product product { get; set; }
        public buddy buddy { get; set; }



    }
}
