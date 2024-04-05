using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    public class Reservation
    {
        public int ReservationNumber { get; set; }
        public DateTime StartTime;
        public DateTime EndTime;
        public HotelRoom Room { get; set; }
        public int DurationInDays { get; set; }
        public decimal Total {  get; set; }

        public Reservation() { }
    }
}
