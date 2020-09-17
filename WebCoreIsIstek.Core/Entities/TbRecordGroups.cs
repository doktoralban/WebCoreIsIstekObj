using System;
using System.Collections.Generic;
using WebCoreIsIstek.Core.Entities.Base;

namespace WebCoreIsIstek.Core.Entities
{
    public partial class TbRecordGroups : Entity
    {
        public int RecordGroupId { get; set; }
        public string GroupName { get; set; }
        public string Description { get; set; }
    }
}
