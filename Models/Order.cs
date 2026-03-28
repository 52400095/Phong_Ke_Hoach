using System;

namespace Phong_Ke_Hoach.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string LocationName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string HTName { get; set; }
        public string PTNName { get; set; }
        public string Status { get; set; }
    }
}