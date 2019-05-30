using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Application.RoomRental.Queries.GetRoomRentalDetail
{
    public class RoomRentalDetailModel
    {
        public int RoomRentalID { get; set; }
        public int RoomId { get; set; }        
        public string Email { get; set; }
        public string TenantName { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public short? NumberOfPerson { get; set; }
    }
}
