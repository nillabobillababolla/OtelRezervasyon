using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Otel.Models.Abstracts;

namespace Otel.Models.Entities
{
    [Table("ReservationDetails")]
    public class ReservationDetail : BaseEntity2<Guid,int>
    {
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(11)]
        [RegularExpression(@"^(05)[0-9][0-9][1-9]([0-9]){6}$",ErrorMessage = "05xxx seklinde giriniz.")]
        public string TelephoneNumber { get; set; }

        [ForeignKey("Id")]
        public virtual Reservation Reservation { get; set; }
        [ForeignKey("Id2")]
        public virtual Room Room { get; set; }


    }
}
