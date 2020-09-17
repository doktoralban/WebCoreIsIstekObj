using System;
using System.Collections.Generic;
using WebCoreIsIstek.Core.Entities.Base;

namespace WebCoreIsIstek.Core.Entities
{
    public partial class TbMaintainanceGroups : Entity
    {
        public int MaintainanceGroupId { get; set; }
        public string MaintainanceGroupName { get; set; }
    }
}
