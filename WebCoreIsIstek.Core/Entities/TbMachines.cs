using System;
using System.Collections.Generic;
using WebCoreIsIstek.Core.Entities.Base;

namespace WebCoreIsIstek.Core.Entities
{
    public partial class TbMachines : Entity
    {
        public TbMachines()
        {
            TbJobRequests = new HashSet<TbJobRequests>();
        }

        public int MachineId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string GroupName { get; set; }
        public string TypeName { get; set; }
        public string SerialNumber { get; set; }
        public string ModelName { get; set; }
        public bool? IsActive { get; set; }
        public int? LocationId { get; set; }
        public bool? CanbePeriodicMaintenance { get; set; }
        public bool? CanbeCalibrating { get; set; }
        public bool? VisibleInJobRequest { get; set; }
        public string RecordCreatedBy { get; set; }
        public DateTime? RecordCreatedDateTime { get; set; }
        public string RecordLastUpdatedBy { get; set; }
        public DateTime? RecordLastUpdateTime { get; set; }
        public string Notes { get; set; }

        public virtual TbLocations Location { get; set; }
        public virtual ICollection<TbJobRequests> TbJobRequests { get; set; }
    }
}
