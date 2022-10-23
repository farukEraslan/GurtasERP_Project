using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gurtas.DAL.Entities
{
    public class Suppliers : BaseEntity
    {
        public int SupplierId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string Address { get; set; }
        public string TaxOfficeAndNumber { get; set; }
        public string? Phone { get; set; }
        public int CompanyRating { get; set; }
        public string Goods { get; set; }
        public bool IsApproved { get; set; }


        public int UserId { get; set; }
        public virtual Users User { get; set; }
    }
}
