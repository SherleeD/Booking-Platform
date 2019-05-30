using System.Threading.Tasks;

namespace Booking.Application.Room.Commands.DeleteRoom
{
    public interface IDeleteRoomCommand
    {
        Task Execute(string id);
    }
}
