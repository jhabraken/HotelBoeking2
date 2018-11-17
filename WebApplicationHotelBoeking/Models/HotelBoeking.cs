using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationHotelBoeking.Models
{
    public class HotelBoeking
    {
        [Key]
        public int Id { get; set; }
        public string HotelName { get; set; }
        
        public string Address { get; set; }
        public int Booking_id { get; set; }
        public int Guest_No { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Room_No { get; set; }
       
    }
}
