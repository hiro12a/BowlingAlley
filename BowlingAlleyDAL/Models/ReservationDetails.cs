using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BowlingAlleyDAL.Models
{
    public class ReservationDetails
    {
        [Key]
        public int ReservationId { get; set; }
        public string EmpName { get; set; }
        public DateTime ReservedOn { get; set; }
        public int SlotId { get; set; }
        public TimeSpan SlotStartTime { get; set; }
        public TimeSpan SlotEndTime { get; set; }
    }
}
