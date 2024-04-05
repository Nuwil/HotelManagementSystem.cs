using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    public class Hotel
    {
        public string HotelName {  get; set; }
        public string Location { get; set; }
        private List<HotelRoom> _allRooms;
       
        public Hotel(string hotelName, string location, List<HotelRoom> allRooms) 
        {
            HotelName = hotelName;
            Location = location;
            _allRooms = allRooms;
        }
    }
}
