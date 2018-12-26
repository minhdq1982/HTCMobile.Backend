using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HTCMobile.Model
{
    [Table("HtcMemberships")]
    public class HtcMembership : Entity<long>
    {
        public long? CustomerId { get; set; }
        [ForeignKey(nameof(CustomerId))]
        public HtcCustomer Customer { get; set; }

        public string CardNumber { get; set; }
        public long? BenefitTypeId { get; set; }
        [ForeignKey(nameof(BenefitTypeId))]
        public HtcBenefitType BenefitType { get; set; }

        public long? CarId { get; set; }
        [ForeignKey(nameof(CarId))]
        public HtcCar Car { get; set; }

        public double? CumulativePoint { get; set; }
        public double? PeriodPoint { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
    }
}
