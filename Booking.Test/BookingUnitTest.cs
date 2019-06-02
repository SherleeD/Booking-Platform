using NUnit.Framework;
using Moq;
using System;
using Microsoft.AspNetCore.Mvc;

using Booking.Application;
using Booking.Domain;
using Booking.Presentation;
using Booking.Presentation.Filters;

namespace Booking.Test
{
    [TestFixture]
    public class BookingUnitTest
    {
        [Test]
        public void ReturnAvailableRooms()
        {
            //Test availability of the room based on capacity and date range specified

            //Arrange

            //var bookingServiceMock = new Mock<Application.Room.Queries.GetRoomList.IGetRoomListQuery>();

            var controller = new ValidateBookedRoom();
            int roomID = 1;
            int numberofPersons = 2;
            var result = controller.IsValidRoomCapacity(roomID, numberofPersons);

            Assert.IsTrue(result);


        }
    }
}
