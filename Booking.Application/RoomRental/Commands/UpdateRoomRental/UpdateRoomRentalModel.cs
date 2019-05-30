using System;
using System.ComponentModel.DataAnnotations;

namespace Booking.Application.RoomRental.Commands.UpdateRoomRental
{
    public class UpdateRoomRentalModel
    {
        public int RoomRentalID { get; set; }

        public int RoomId { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(200)]
        public string TenantName { get; set; }

        public DateTime? DateFrom { get; set; }

        public DateTime? DateTo { get; set; }

        public short? NumberOfPerson { get; set; }
    }
}
