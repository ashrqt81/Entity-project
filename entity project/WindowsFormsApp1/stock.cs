using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class stock
    {
        public int stockId { get; set; }
        public string name { get; set; }
        public DateTime createdDate { get; set; }
        public string address { get; set; }
        public string employeeName { get; set; }
        public ICollection<permission> permissions { get; set; }
        public ICollection<productStock> productStock { get; set; }
        public ICollection<productTransfer> productTransfer { get; set; }
    }
}
