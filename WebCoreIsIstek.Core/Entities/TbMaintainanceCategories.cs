using System;
using System.Collections.Generic;
using WebCoreIsIstek.Core.Entities.Base;

namespace WebCoreIsIstek.Core.Entities
{
    public partial class TbMaintainanceCategories : Entity
    {
        public int MaintainanceCategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
