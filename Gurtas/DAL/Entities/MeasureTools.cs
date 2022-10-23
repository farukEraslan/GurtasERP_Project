using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gurtas.DAL.Entities
{
    public class MeasureTools : BaseEntity
    {
        public int ToolId { get; set; }
        public string ToolName { get; set; }
        public string? Manufacturer { get; set; }
        public string? Model { get; set; }
        public string? Type { get; set; }
        public string? MeasureRange { get; set; }
        public string? Accuracy { get; set; }
        public string? SerialNumber { get; set; }
        public string CertificateNumber { get; set; }
        public DateTime CalibrationDate { get; set; }
        public DateTime NextCalibrationDate { get; set; }

        public int UserId { get; set; }
        public virtual Users User { get; set; }

    }
}
