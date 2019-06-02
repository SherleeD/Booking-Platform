using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Booking.Application;
using Microsoft.EntityFrameworkCore;
using Booking.Persistence;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

using Booking.Application.Room.Queries.GetRoomDetail;

namespace Booking.Presentation.Filters
{
    public class ValidateBookedRoom 
    {
        private  BookingContext _context;

        private readonly IGetRoomDetailQuery _getRoomDetailQuery;
        

        public bool IsValidRoomCapacity(int roomID, int numberofPersons)
        {

            var room =  _getRoomDetailQuery.Execute(roomID);
            

            if (room.Result.Capacity <= numberofPersons)
            {
                return true;
            }
            return false;        
        }

    }
}
