using System.Threading.Tasks;

namespace Booking.Application.Room.Commands.UpdateRoom
{
    public interface IUpdateRoomCommand
    {
        Task Execute(UpdateRoomModel model);
    }
}