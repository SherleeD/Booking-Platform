using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Booking.Domain
{
    public partial class RoomRental
    {
        public RoomRental()
        {

        }

        [Column("RoomRentalID")]
        [Key]
        public int RoomRentalID { get; set; }

        public int RoomId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required]
        [MaxLength(200)]
        public string TenantName { get; set; }

        [Required]
        public DateTime? DateFrom { get; set; }

        [Required]
        public DateTime? DateTo { get; set; }

        [Required]
        public short? NumberOfPerson { get; set; }

        [ForeignKey("RoomId")]        
        public virtual Room Room { get; set; }
    }
}
