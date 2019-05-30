using System.ComponentModel.DataAnnotations;

namespace Booking.Application.Room.Commands.CreateRoom
{
    public class CreateRoomModel
    {
        public int RoomId { get; set; }
        
        [MaxLength(100)]
        public string Title { get; set; }
        
        [MaxLength(255)]
        public string ImagePath { get; set; }
        
        public byte[] RoomImage { get; set; }
        
        public decimal? Price { get; set; }

        [MaxLength(40)]
        public string Description { get; set; }

        [MaxLength(40)]
        public string Address { get; set; }

        public short? Capacity { get; set; }
        public bool? Status { get; set; }
    }
}
