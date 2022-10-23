using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gurtas.DAL.Entities
{
    public class Customers : BaseEntity
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string ContactTitle { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string Address { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? PostalCode { get; set; }

        public int UserId { get; set; }
        public virtual Users User { get; set; }
        public List<Projects> Projects { get; set; }
    }
}
