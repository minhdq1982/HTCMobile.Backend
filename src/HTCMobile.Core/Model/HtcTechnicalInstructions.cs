using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HTCMobile.Model
{
    [Table("HtcTechnicalInstructions")]
    public class HtcTechnicalInstruction : Entity<long>
    {
        [StringLength(200)]
        public string Title { get; set; }
        [StringLength(500)]
        public string Image { get; set; }
        public string Content { get; set; }
        public int? OrderNumber { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted{ get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }

    }
}
