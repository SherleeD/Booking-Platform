using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

using Booking.Application.Room.Commands.CreateRoom;
using Booking.Application.Room.Commands.DeleteRoom;
using Booking.Application.Room.Commands.UpdateRoom;
using Booking.Application.Room.Queries.GetRoomDetail;
using Booking.Application.Room.Queries.GetRoomList;

using Booking.Domain;
using Booking.Persistence;
using Booking.Presentation.Filters;


namespace Booking.Presentation.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class RoomsController : Controller
    {
        private readonly IGetRoomListQuery _getRoomListQuery;
        private readonly IGetRoomDetailQuery _getRoomDetailQuery;
        private readonly ICreateRoomCommand _createRoomCommand;
        private readonly IUpdateRoomCommand _updateRoomCommand;
        //private readonly IDeleteRoomCommand _deleteRoomCommand;       

        public RoomsController(
        IGetRoomListQuery getRoomListQuery,
        IGetRoomDetailQuery getRoomDetailQuery,
        ICreateRoomCommand createRoomCommand,
        IUpdateRoomCommand updateRoomCommand
        //IDeleteRoomCommand deleteRoomCommand
            )
        {
            _getRoomListQuery = getRoomListQuery;
            _getRoomDetailQuery = getRoomDetailQuery;
            _createRoomCommand = createRoomCommand;
            _updateRoomCommand = updateRoomCommand;
            //_deleteRoomCommand = deleteRoomCommand;
        }

        // GET: api/Rooms
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<RoomListModel>), (int)HttpStatusCode.OK)]        
        public async Task<IActionResult> GetRooms()
        {
            return Ok(await _getRoomListQuery.Execute());
        }

        // GET: api/Rooms/5
        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(RoomDetailModel), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetRoom(int id)
        {            
            return Ok(await _getRoomDetailQuery.Execute(id));
        }

        // PUT: api/Rooms/5
        [HttpPut("{id}")]
        [ValidateModel, ValidateRoomExists]
        [ProducesResponseType(typeof(IDictionary<string, string>), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public async Task<IActionResult> PutRoom([FromBody] UpdateRoomModel room)
        {           
            await _updateRoomCommand.Execute(room);

            return NoContent();
        }
               
        // POST: api/Rooms
        [HttpPost]
        [ValidateModel]
        [ProducesResponseType(typeof(IDictionary<string, string>), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(CreateRoomModel), (int)HttpStatusCode.Created)]
        public async Task<IActionResult> PostRoom([FromBody] CreateRoomModel room)
        {           
            await _createRoomCommand.Execute(room);

            return CreatedAtAction("GetRoom", new { id = room.RoomId }, room);
        }

        
        // DELETE: api/Rooms/5
        //[HttpDelete("{id}")]
        //[ValidateRoomExists]        
        //public async Task<IActionResult> DeleteRoom(string id)
        //{
        //    await _deleteRoomCommand.Execute(id);

        //    return NoContent();
        //}
        
    }
}
