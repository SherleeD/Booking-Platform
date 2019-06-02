using System;

namespace Booking.Application.RoomRental.Queries.GetRoomRentalList
{
    public class RoomRentalListModel
    {
        public int RoomRentalID { get; set; }
        public int RoomId { get; set; }        
        public string Email { get; set; }        
        public string TenantName { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public int NumberOfPerson { get; set; }
    }
}
