using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HTCMobile.Model
{
    [Table("HtcCarDetails")]
    public class HtcCarDetail : Entity<long>
    {
        public long? CarId { get; set; }
        [ForeignKey(nameof(CarId))]
        public HtcCar Car { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public string YearOfProduction { get; set; }
    }
}
