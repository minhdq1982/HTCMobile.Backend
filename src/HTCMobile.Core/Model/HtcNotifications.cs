using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HTCMobile.Model
{
    [Table("HtcNotifications")]
    public class HtcNotification : Entity<long>
    {
        public long? CustomerId { get; set; }
        [ForeignKey(nameof(CustomerId))]
        public HtcCustomer Customer { get; set; }
        public string Title { get; set; }
        public string ShortContent { get; set; }
        public string FullContent { get; set; }
        public string MessageType { get; set; }
        public DateTime? SentDate { get; set; }
        public long? ToPerson { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
    }
}
