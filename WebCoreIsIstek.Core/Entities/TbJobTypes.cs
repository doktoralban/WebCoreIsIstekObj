using System;
using System.Collections.Generic;
using WebCoreIsIstek.Core.Entities.Base;

namespace WebCoreIsIstek.Core.Entities
{
    public partial class TbJobTypes : Entity
    {
        public TbJobTypes()
        {
            TbJobRequests = new HashSet<TbJobRequests>();
        }

        public int JobTypeId { get; set; }
        public string GroupName { get; set; }
        public string TypeName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<TbJobRequests> TbJobRequests { get; set; }
    }
}
