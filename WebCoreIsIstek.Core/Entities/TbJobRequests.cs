using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using WebCoreIsIstek.Core.Entities.Base;

namespace WebCoreIsIstek.Core.Entities
{

    [Table("TbJobRequests")]
    public partial class TbJobRequests : Entity
    {
        public long JobRequestId { get; set; }
        public int RecordGroupId { get; set; }
        public int RequestUserIid { get; set; }
        public int JobTypeId { get; set; }
        public int LocationId { get; set; }
        public int? MachineId { get; set; }
        public string JobSubject { get; set; }
        public string JobDescription { get; set; }
        public int JobSituationId { get; set; }
        public string ResultNotes { get; set; }
        public string RecordCreatedBy { get; set; }
        public DateTime? RecordCreatedDateTime { get; set; }
        public string RecordLastUpdatedBy { get; set; }
        public DateTime? RecordLastUpdateDateTime { get; set; }

        public virtual TbJobTypes JobType { get; set; }
        public virtual TbLocations Location { get; set; }
        public virtual TbMachines Machine { get; set; }
    }
}
