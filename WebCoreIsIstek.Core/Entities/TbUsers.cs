using System;
using System.Collections.Generic;
using WebCoreIsIstek.Core.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;



namespace WebCoreIsIstek.Core.Entities
{
    public partial class TbUsers : Entity
    { 
  
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string Type { get; set; }
        public string Email { get; set; }
        public byte[] Photo { get; set; }
        public bool IsActive { get; set; }
        public string RolGroups { get; set; }
    }
}
