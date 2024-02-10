using WS.DataServices.Model;
using WS.Unit06.Example2.Data.DAO;

namespace WS.DataServices.DAO.Impl;

public class ReservationDAO: GenericDAO<Reservation>, IReservationDAO
{
    public ReservationDAO(DataContext context) : base(context)
    {
    }
}