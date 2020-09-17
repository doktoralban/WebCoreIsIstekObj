using System;
using System.Collections.Generic;
using WebCoreIsIstek.Core.Entities.Base;

namespace WebCoreIsIstek.Core.Entities
{
    public partial class TbMaintainanceTypes : Entity
    {
        public int MaintainanceTypeId { get; set; }
        public int MaintainanceGroupId { get; set; }
        public string MaintainanceTypeName { get; set; }
    }
}
