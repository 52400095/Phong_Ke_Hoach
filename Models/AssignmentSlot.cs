using System;

namespace PhongKeHoach.Models
{
    public class AssignmentSlot
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public int AssignedStaffId { get; set; }
        public string Type { get; set; }
    }
}