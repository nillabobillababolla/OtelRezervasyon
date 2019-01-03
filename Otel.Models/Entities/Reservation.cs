using System;
using System.ComponentModel.DataAnnotations.Schema;
using Otel.Models.Abstracts;

namespace Otel.Models.Entities
{
    [Table("Reservations")]
   public class Reservation : BaseEntity<Guid>
    {
        public Reservation()
        {
            this.Id = Guid.NewGuid();
        }

        public DateTime ReservationTime { get; set; }
        public DateTime? CheckOutDate { get; set; }
        
    }
}
