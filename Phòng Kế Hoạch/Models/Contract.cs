// Contract.cs

using System;

namespace PhongKeHoach.Models
{
    public class Contract
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}