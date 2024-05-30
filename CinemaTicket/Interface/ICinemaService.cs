using static CinemaTicket.Model.CinemaModel;

namespace CinemaTicket.Interface
{
    public interface ICinemaService
    {
        bool AddCinema(AddCinemaInputModel Input);
    }
}
