using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Bridge;

namespace StoreBaeltTicketLibrary
{
    public class StoreBaeltRepository : IStoreBaeltRepository
    {
        private static readonly List<Vehicle> _tickets = new();

        public void AddTicket(Vehicle vehicle) => _tickets.Add(vehicle);

        public List<Vehicle> GetAllTickets() => _tickets;

        public List<Vehicle> GetTicketsByLicensePlate(string licensePlate) =>
            _tickets.Where(v => v.LicensePlate == licensePlate).ToList();

        public int GetTicketCount() => _tickets.Count;

        public void ClearAllTickets() => _tickets.Clear();
    }
}
