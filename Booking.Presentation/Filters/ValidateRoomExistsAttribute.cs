using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Booking.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Booking.Presentation.Filters
{
    public class ValidateRoomExistsAttribute : TypeFilterAttribute
    {
        public ValidateRoomExistsAttribute() : base(typeof(ValidateRoomExistsFilterImpl)) { }

        private class ValidateRoomExistsFilterImpl : IAsyncActionFilter
        {
            private readonly BookingContext _context;

            public ValidateRoomExistsFilterImpl(BookingContext context)
            {
                _context = context;
            }

            public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
            {
                if (context.ActionArguments.ContainsKey("id"))
                {
                    var id = context.ActionArguments["id"] as string ;

                    if (id != null)
                    {
                        int roomID = int.Parse(id);

                        if (await _context.Rooms.AllAsync(r => r.RoomId != roomID))
                        {
                            context.Result = new NotFoundObjectResult(id);

                            return;
                        }
                    }
                }
                await next();
            }
        }


    }
}
