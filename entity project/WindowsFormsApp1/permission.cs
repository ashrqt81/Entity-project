using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class permission
    {
        public int permissionId { get; set; }
        public DateTime createdDate { get; set; }
        public string empName { get; set; }
        public permissionType permissionType { get; set; }
        public int number { get; set; }//quantity
        [ForeignKey("stock")]
        public int StockId { get; set; }
        [ForeignKey("buddy")]
        public int buddyId { get; set; }
        [ForeignKey("product")]
        public int productId { get; set; }
        public buddy buddy { get; set; }
        public stock stock { get; set; }
        public product product { get; set; }

    }
}
