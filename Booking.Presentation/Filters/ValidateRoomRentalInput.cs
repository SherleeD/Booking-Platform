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

        private class ValidateRoomRentalInputFilterImpl : IAsyncActionFilter
        {
            private readonly BookingContext _dbcontext;

            public ValidateRoomRentalInputFilterImpl(BookingContext context)
            {
                _dbcontext = context;
            }

            public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
            {
                var test = context.ActionArguments.ToString();
                await next();
            }
        }

    }
}
