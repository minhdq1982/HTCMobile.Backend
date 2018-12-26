using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HTCMobile.Model
{
    [Table("HtcInstructionBooks")]
    public class HtcInstructionBook : Entity<long>
    {
        public long? CarId { get; set; }
        [ForeignKey(nameof(CarId))]
        public HtcCar Car { get; set; }

        public string Title { get; set; }
        public string FileName { get; set; }
        public int OrderNumber { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
    }
}
