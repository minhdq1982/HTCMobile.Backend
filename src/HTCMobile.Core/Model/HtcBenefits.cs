using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HTCMobile.Model
{
    [Table("HtcBenefits")]
    public class HtcBenefit : Entity<long>
    {
        public long? BenefitTypeId { get; set; }
        [ForeignKey(nameof(BenefitTypeId))]
        public HtcBenefitType BenefitType { get; set; }
        public string BenefitName { get; set; }
        public string BenefitDetail { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
    }
}
