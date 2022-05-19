using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class buddy
    {
        public int buddyId { get; set; }
        public string name { get; set; }
        public buddyType buddyType { get; set; }
        public string phone { get; set; }
        public string fax { get; set; }
        public string mail { get; set; }
        public string website { get; set; }
        public ICollection<permission> permissions { get; set; }
        public ICollection<productTransfer> productTransfer { get; set; }

    }
}
