using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HTCMobile.Model
{
    [Table("HtcRegisterTestDrives")]
    public class HtcRegisterTestDrive : Entity<long>
    {
        public string Gender { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
        public string City { get; set; }
        public long? CarId { get; set; }
        [ForeignKey(nameof(CarId))]
        public HtcCar Car { get; set; }
        public long? AgencyId { get; set; }
        [ForeignKey(nameof(AgencyId))]
        public HtcAgency Agency { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public DateTime? ConfirmationDate { get; set; }
        public long? ConfirmationBy { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
    }
}
