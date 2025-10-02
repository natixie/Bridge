using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary
{
    public interface IStoreBaeltRepository
    {
        void AddTicket(Vehicle vehicle);
        List<Vehicle> GetAllTickets();
        List<Vehicle> GetTicketsByLicensePlate(string licensePlate);
        int GetTicketCount();
        void ClearAllTickets();
    }
}
