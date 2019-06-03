using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Application.RoomRental.Queries.GetAvailableRoom
{
    public class AvailableRoomListViewModel
    {
        public AvailableRoomListViewModel()
        {
            
        }

        public int RoomRentalID { get; set; }
        public int RoomId { get; set; }
        public string Email { get; set; }
        public string TenantName { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public int NumberOfPerson { get; set; }
        public string Title { get; set; }       
        public decimal? Price { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public int Capacity { get; set; }     
    }
}
