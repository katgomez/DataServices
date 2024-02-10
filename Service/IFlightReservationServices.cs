using System.ServiceModel;
using WS.DataServices.Model;

namespace WS.DataServices.Service;

[ServiceContract(Namespace = "http://ws.agencytravel/flight/")]

public interface IFlightReservationServices
{
    [OperationContract]
    public FlighReservation[] GetFlights();
    [OperationContract]
    public FlighReservation GetFlight(string email, string? username);
    [OperationContract]
    public void CreateFlight(FlighReservation user);
    [OperationContract]
    public void UpdateFlight(FlighReservation user);

}