using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gurtas.DAL.Entities
{
    public class BaseEntity
    {
        public DateTime RecordDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
