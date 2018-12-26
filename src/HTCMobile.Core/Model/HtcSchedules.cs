using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HTCMobile.Model
{
    [Table("HtcSchedules")]
    public class HtcSchedule : Entity<long>
    {
        //public long Id { get; set; }
        public long? CustomerId { get; set; }
        [ForeignKey(nameof(CustomerId))]
        public HtcCustomer Customer { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public DateTime ScheduleDate { get; set; }
        [Required]
        public TimeSpan ScheduleTime { get; set; }
        public string ServiceStaff { get; set; }
        [Required]
        public long AgencyId { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public string Description { get; set; }
        public long? CarId { get; set; }
        [ForeignKey(nameof(CarId))]
        public HtcCar Car { get; set; }
        public string CarVersion { get; set; }
        [Required]
        public string CarLicensePlate { get; set; }
        public int? CarManufactureYear { get; set; }
        public int? Status { get; set; }
        public bool? IsDeleted { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }






    }
}
