using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gurtas.DAL.Entities
{
    public class Projects : BaseEntity
    {
        public int ProjectId { get; set; }
        public string ProjectNumber { get; set; }
        public string ProjectName { get; set; }
        public bool IsFinished { get; set; }

        public int UserId { get; set; }
        public virtual Users User { get; set; }
        public int CustomerId { get; set; }
        public virtual Customers Customer { get; set; }
    }
}
