using System;

namespace CruisinV2.Models
{
    public class Maintenance
    {
        public int Id { get; set; }

        public string MaintenanceQuestion { get; set; }

        public string MaintenanceAnswer { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public Maintenance()
        {

        }
    }
}