using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HTCMobile.Model
{
    [Table("HtcCarMaintenances")]
    public class HtcCarMaintenance : Entity<long>
    {
        public long? CarId { get; set; }
        [ForeignKey(nameof(CarId))]
        public HtcCar Car { get; set; }
        public long? MaintenanceLevelId { get; set; }
        [ForeignKey(nameof(MaintenanceLevelId))]
        public HtcMaintenanceLevel MaintenanceLevel { get; set; }
        public double? LaborCost { get; set; }
        public double? CostOfMaterial { get; set; }
        public double? TotalPrice { get; set; }
        public double? Taxes { get; set; }
        public double? TotalAfterTaxes { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
    }
}
