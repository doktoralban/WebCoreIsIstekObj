using System;
using System.Collections.Generic;
using WebCoreIsIstek.Core.Entities.Base;

namespace WebCoreIsIstek.Core.Entities
{
    public partial class TbLocations : Entity
    {
        public TbLocations()
        {
            TbJobRequests = new HashSet<TbJobRequests>();
            TbMachines = new HashSet<TbMachines>();
        }

        public int LocationId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<TbJobRequests> TbJobRequests { get; set; }
        public virtual ICollection<TbMachines> TbMachines { get; set; }
    }
}
