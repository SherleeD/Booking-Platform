using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Booking.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Booking.Presentation.Filters
{
    public class ValidateRoomRentalInput : TypeFilterAttribute
    {
        public ValidateRoomRentalInput() : base(typeof(ValidateRoomRentalInputFilterImpl)) { }

        private class ValidateRoomRentalInputFilterImpl
        {
            

        }

    }
}
