using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HTCMobile.Model
{
    [Table("HtcWarrantyPolicy")]
    public class HtcWarrantyPolicy : Entity<long>
    {
        [StringLength(50)]
        public string Category { get; set; }
        [StringLength(5000)]
        public string Content { get; set; }
        public int? OrderNumber { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        
    }
}
