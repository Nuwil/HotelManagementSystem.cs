using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    public class HotelRoom
    {
        public int RoomNumber { get; set; }

        public RoomStyle Style { get; set; }    
        public bool Status { get; set; }
        public decimal BookingPrice { get; set; }

        public HotelRoom(int roomNumber, RoomStyle style, decimal bookingPrice, bool status) 
        {
            RoomNumber = roomNumber;
            BookingPrice = bookingPrice;
            Style = style;
            Status = status;
        }


    }
}
