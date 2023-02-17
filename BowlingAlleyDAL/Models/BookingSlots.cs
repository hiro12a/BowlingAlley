using System;
using System.Collections.Generic;

namespace BowlingAlleyDAL.Models
{
    public partial class BookingSlots
    {
        public BookingSlots()
        {
            Reservations = new HashSet<Reservations>();
        }

        public int SlotId { get; set; }
        public TimeSpan SlotStartTime { get; set; }
        public TimeSpan SlotEndTime { get; set; }

        public ICollection<Reservations> Reservations { get; set; }
    }
}
