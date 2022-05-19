using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class product
    {
        public int productId { get; set; }
        public string name { get; set; }
        public int code { get; set; }
        public DateTime createddate { get; set; }
        public string measureUnit { get; set; }
        public string quantity { get; set; }
        public DateTime productionDate { get; set; }
        public DateTime expireDate { get; set; }
        public ICollection<productStock> productStock { get; set; }
        public ICollection<permission> permission { get; set; }
        public ICollection<productTransfer> productTransfer { get; set; }

    }
}
