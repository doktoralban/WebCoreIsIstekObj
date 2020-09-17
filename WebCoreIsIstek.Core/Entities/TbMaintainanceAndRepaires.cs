using System;
using System.Collections.Generic;
using WebCoreIsIstek.Core.Entities.Base;

namespace WebCoreIsIstek.Core.Entities
{
    public partial class TbMaintainanceAndRepaires : Entity
    {
        public long MaintainanceAndRepaireId { get; set; }
        public int RecordGroupId { get; set; }
        public int SituationId { get; set; }
        public bool IsPeriodic { get; set; }
        public int JobTypeId { get; set; }
        public int MaintainanceCategoryId { get; set; }
        public int? MachineId { get; set; }
        public DateTime StartDateTine { get; set; }
        public DateTime? EndDateTime { get; set; }
        public string StartDescription { get; set; }
        public string EndDescription { get; set; }
        public string RequestBy { get; set; }
        public string AccepptingBy { get; set; }
        public string RecordCreatedBy { get; set; }
        public DateTime? RecordCreatedDateTime { get; set; }
        public string RecordLastUpdatedBy { get; set; }
        public DateTime? RecordLastUpdateDateTime { get; set; }
    }
}
