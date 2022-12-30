using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gurtas.DAL.Entities
{
    public class InputControl : BaseEntity
    {
        public int FormId { get; set; }
        public string ReportNo { get; set; }
        public DateTime ReportDate { get; set; }
        public string Supplier { get; set; }
        public string Material { get; set; }
        public string BillNo { get; set; }
        public DateTime BillDate { get; set; }
        public string ProjectName { get; set; }
        public string Decision { get; set; }
        public string Quality { get; set; }
        public string Time { get; set; }
        public string Certificate { get; set; }
        public string Price { get; set; }
        public string Payment { get; set; }


        public int UserId { get; set; }
        public virtual Users User { get; set; }

    }
}
