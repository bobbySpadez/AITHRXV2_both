using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airthwholesale.Data.Models
{
    public class AithrRepWholeSale
    {
        public int id { get; set; }

        public int WID { get; set; }

        public int AID { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public int? UpdatedBy { get; set; }

        public DateTime? UpdateDate { get; set; }
    }
}
