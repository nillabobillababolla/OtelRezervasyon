using System;
using System.ComponentModel.DataAnnotations;
using Otel.Models.Abstracts;
using System.ComponentModel.DataAnnotations.Schema;
using Otel.Models.Enums;

namespace Otel.Models.Entities
{
    [Table("Rooms")]
    public class Room:BaseEntity<int>
    {
        [StringLength(25)]
        [Required]
        public string Name { get; set; }

        public RoomTypes RoomType { get; set; }
        public decimal Price { get; set; }
        public bool IsEmpty { get; set; } = true;
        public bool IsUseable { get; set; } = true;

        public int? RoomCategoryId { get; set; }

        [ForeignKey("RoomCategoryId")]
        public RoomCategory RoomCategory { get; set; }

    }
}
