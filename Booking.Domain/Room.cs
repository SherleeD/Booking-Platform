using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Booking.Domain
{
    public partial class Room
    {
        //public Room()
        //{
           
        //    RoomRentals = new List<RoomRental>();
        //}

        [Column("RoomID")]
        [Key]
        public int RoomId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [MaxLength(255)]
        public string ImagePath { get; set; }

        [Column(TypeName = "image")]
        public byte[] RoomImage { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        [MaxLength(40)]
        public string Description { get; set; }

        [MaxLength(40)]
        public string Address { get; set; }

        public int Capacity { get; set; }
        public bool? Status { get; set; }
        
        //public virtual ICollection<RoomRental> RoomRentals { get; set; }
        
    }
}
