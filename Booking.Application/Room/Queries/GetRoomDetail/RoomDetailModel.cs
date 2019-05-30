using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Application.Room.Queries.GetRoomDetail
{
    public class RoomDetailModel
    {
        public int RoomId { get; set; }        
        public string Title { get; set; }        
        public string ImagePath { get; set; }
        public byte[] RoomImage { get; set; }
        public decimal? Price { get; set; }        
        public string Description { get; set; }        
        public string Address { get; set; }
        public short? Capacity { get; set; }
        public bool? Status { get; set; }
    }
}
