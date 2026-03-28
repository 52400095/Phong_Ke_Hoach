using System;
using System.Collections.Generic;

namespace Models
{
    public class Staff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string Type { get; set; }
        public int Load { get; set; }
        public List<DateTime> BusyDates { get; set; }

        public Staff()
        {
            BusyDates = new List<DateTime>();
        }
    }
}