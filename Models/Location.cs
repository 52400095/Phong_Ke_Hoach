using System;

namespace Phong_Ke_Hoach.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string GPS { get; set; }
        public string HTParams { get; set; }
        public string PTNParams { get; set; }
        public bool HasData { get; set; }
    }
}