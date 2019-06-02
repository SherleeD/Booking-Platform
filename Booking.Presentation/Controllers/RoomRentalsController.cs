using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

using Booking.Application.RoomRental.Commands.CreateRoomRental;
using Booking.Application.RoomRental.Commands.DeleteRoomRental;
using Booking.Application.RoomRental.Commands.UpdateRoomRental;
using Booking.Application.RoomRental.Queries.GetRoomRentalDetail;
using Booking.Application.RoomRental.Queries.GetRoomRentalList;

using Booking.Domain;
using Booking.Persistence;
using Booking.Presentation.Filters;


namespace Booking.Presentation.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class RoomRentalsController : Controller
    {

        private readonly IGetRoomRentalListQuery _getRoomRentalListQuery;
        private readonly IGetRoomRentalDetailQuery _getRoomRentalDetailQuery;
        private readonly ICreateRoomRentalCommand _createRoomRentalCommand;
        private readonly IUpdateRoomRentalCommand _updateRoomRentalCommand;
        private readonly IDeleteRoomRentalCommand _deleteRoomRentalCommand;

        public RoomRentalsController(
        IGetRoomRentalListQuery getRoomRentalListQuery,
        IGetRoomRentalDetailQuery getRoomRentalDetailQuery,
        ICreateRoomRentalCommand createRoomRentalCommand,
        IUpdateRoomRentalCommand updateRoomRentalCommand,
        IDeleteRoomRentalCommand deleteRoomRentalCommand)
        {
            _getRoomRentalListQuery = getRoomRentalListQuery;
            _getRoomRentalDetailQuery = getRoomRentalDetailQuery;
            _createRoomRentalCommand = createRoomRentalCommand;
            _updateRoomRentalCommand = updateRoomRentalCommand;
            _deleteRoomRentalCommand = deleteRoomRentalCommand;
        }

        // GET: api/RoomRentals
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<RoomRentalListModel>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetRoomRentals()
        {
            return Ok(await _getRoomRentalListQuery.Execute());
        }

        // GET: api/RoomRentals/5
        [HttpGet("{id}")]
        [ValidateRoomExists]
        public async Task<IActionResult> GetRoomRental(int id)
        {
            return Ok(await _getRoomRentalDetailQuery.Execute(id));
        }

        // PUT: api/RoomRentals/5
        [HttpPut("{id}")]
        [ValidateModel, ValidateRoomExists]
        public async Task<IActionResult> PutRoomRental([FromBody] UpdateRoomRentalModel roomRental)
        {
            await _updateRoomRentalCommand.Execute(roomRental);

            return NoContent();
        }

        // POST: api/RoomRentals
        [HttpPost]
        [ValidateModel]
        public async Task<IActionResult> PostRoomRental([FromBody] CreateRoomRentalModel roomRental)
        {               
            await _createRoomRentalCommand.Execute(roomRental);

            return CreatedAtAction("GetRoomRental", new { id = roomRental.RoomRentalID }, roomRental);

        }

        // DELETE: api/RoomRentals/5
        //[HttpDelete("{id}")]
        //[ValidateRoomExists]
        //public async Task<IActionResult> DeleteRoomRental(string id)
        //{
        //    await _deleteRoomRentalCommand.Execute(id);

        //    return NoContent();
        //}
    }
}
