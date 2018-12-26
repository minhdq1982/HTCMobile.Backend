using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HTCMobile.Model
{
    [Table("HtcCustomerCars")]
    public class HtcCustomerCar : Entity<long>
    {
        public long? CarId { get; set; }
        [ForeignKey(nameof(CarId))]
        public HtcCar Car { get; set; }
        public long? AgencyId { get; set; }
        [ForeignKey(nameof(AgencyId))]
        public HtcAgency Agency { get; set; }
        public string LicensePlate { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
    }
}
